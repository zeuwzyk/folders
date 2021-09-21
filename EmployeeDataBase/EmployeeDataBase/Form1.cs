using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TextBoxNameEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 64 || e.KeyChar > 91) && (e.KeyChar > 123 || e.KeyChar < 96))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 0)
            {
                MessageBox.Show("Not correct symbol was entered.", "Message");
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameEmployee.Text) && !string.IsNullOrEmpty(comboBoxCarEmployee.Text))
            {
                using (DataBaseManager db = new DataBaseManager())//вызов функции из dataamanager <-> datahelper
                {
                    DataEmployee employee = new DataEmployee
                    {
                        //Id = db.Employees.Last().Id + 1,
                        Name = textBoxNameEmployee.Text.ToLower(),
                        Age = (int)numericAgeEmployee.Value,//не знаю как в стринг и есть ли смысл
                        Car = comboBoxCarEmployee.Text.ToLower()
                    };

                    db.Employees.Add(employee);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("You not entered all iformation.", "Message");
            }

            textBoxNameEmployee.Text = string.Empty;
            comboBoxCarEmployee.Text = string.Empty;
        }


        private void ButtonView_Click(object sender, EventArgs e)
        {
            employeeGridView.Rows.Clear();
            InitializationValueGrid();
        }
        public void InitializationValueGrid()//замутить проверку на файлы
        {
            try
            {
                using (DataBaseManager db = new DataBaseManager())//мб как-то вынести в fileManager
                {
                    var employee = db.Employees.ToList();
                    foreach (DataEmployee de in employee)
                    {
                        FillingGrid(de.Id, de.Name, de.Age, de.Car);
                    }
                }

                if (employeeGridView.Rows.Count == 1)
                {
                    MessageBox.Show("Empty file. Please save data at database.", "Message");
                }
            }
            catch
            {
                MessageBox.Show("Not correct file was entered.", "Message");
            }
        }

        public void FillingGrid(int idEmployee, string nameEmployee, int ageEmployee, string carEmployee)
        {
            int rowNumber = employeeGridView.Rows.Add();

            employeeGridView.Rows[rowNumber].Cells["col1"].Value = idEmployee;
            employeeGridView.Rows[rowNumber].Cells["col2"].Value = nameEmployee;
            employeeGridView.Rows[rowNumber].Cells["col3"].Value = ageEmployee;
            employeeGridView.Rows[rowNumber].Cells["col4"].Value = carEmployee;
        }
        private void ButtonFind_Click(object sender, EventArgs e)
        {
            int checkValue = 0;

            if (employeeGridView.Rows.Count == 1)
            {
                buttonView.PerformClick();
            }

            if (string.IsNullOrEmpty(textBoxFindOrDelete.Text))
            {
                MessageBox.Show("Please, enter information.", "Message");
            }
            else
            {
                FindInformation(checkValue, textBoxFindOrDelete.Text);

                if (checkValue == 0)
                {
                    MessageBox.Show("Information not found.", "Message");
                }
            }

            textBoxFindOrDelete.Clear();
        }

        private int FindInformation(int checkValue, string information)
        {
            for (int i = 1; i < employeeGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < employeeGridView.RowCount - 1; j++)
                {
                    employeeGridView.Rows[i].Selected = false;
                    employeeGridView[i, j].Style.BackColor = Color.White;
                    employeeGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 1; i < employeeGridView.ColumnCount; i++)
            {
                for (int j = 0; j < employeeGridView.RowCount - 1; j++)
                {
                    if (0 == string.Compare(employeeGridView[i, j].Value.ToString(), information))
                    {
                        employeeGridView[i, j].Style.BackColor = Color.MediumBlue;
                        employeeGridView[i, j].Style.ForeColor = Color.Gold;
                        checkValue = 1;
                    }
                }
            }

            return checkValue;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int checkValue = 0;
            if (employeeGridView.Rows.Count == 1)
            {
                buttonView.PerformClick();
            }

            if (string.IsNullOrEmpty(textBoxFindOrDelete.Text))
            {
                MessageBox.Show("Please, enter name.", "Message");
            }
            else if (!string.IsNullOrEmpty(textBoxFindOrDelete.Text))
            {
                using (DataBaseManager db = new DataBaseManager())
                {

                    db.Employees.RemoveRange(db.Employees.Where(x => x.Name == textBoxFindOrDelete.Text));
                    db.SaveChanges();

                    checkValue = FindInformation(checkValue, textBoxFindOrDelete.Text);

                    if (checkValue == 0)
                    {
                        MessageBox.Show("Information not found.", "Message");
                    }
                }
            }

            textBoxFindOrDelete.Clear();
            buttonView.PerformClick();
        }

        private void TextBoxFindOrDelete_TextChanged(object sender, EventArgs e)
        {
            if (employeeGridView.Rows.Count == 1)
            {
                buttonView.PerformClick();
            }
        }
    }
}
