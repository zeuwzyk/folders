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
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameEmployee.Text) && !string.IsNullOrEmpty(comboBoxCarEmployee.Text))
            {
                //id
                var nameEmployee = textBoxNameEmployee.Text.ToLower();
                var ageEmployee = (int)numericAgeEmployee.Value;
                var carEmployee = comboBoxCarEmployee.Text.ToLower();

                //FileManager.SaveDataBase(nameEmployee, ageEmployee,carEmployee);
                using (DataBaseManager db = new DataBaseManager())
                {
                    int id1 = 0;

                    if (employeeGridView.Rows.Count == 1)
                    {
                        id1 = 0;
                    }
                    else
                    {
                    var id = db.Employees.OrderBy(x => x.Id).Last();//при пустоте ошибка
                        id1 = id.Id;
                    }


                    DataEmployee employee = new DataEmployee
                    {
                        Id = id1+1,
                        Name = nameEmployee,
                        Age = ageEmployee,
                        Car = carEmployee
                    };

                    db.Employees.Add(employee);
                    db.SaveChanges();
                }

                MessageBox.Show("Information was saved.", "Message");
            }
            else
            {
                MessageBox.Show("You not entered all information.", "Message");
            }

            textBoxNameEmployee.Text = string.Empty;
            comboBoxCarEmployee.SelectedIndex = -1;
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            employeeGridView.Rows.Clear();
            //ActionWithGrid.InitializationValueGrid();
            InitializationValueGrid();
        }

        public void InitializationValueGrid()
        {
            try
            {
                //FileHelper.OpenFile();
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

        private void textBoxFindOrDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 64 || e.KeyChar > 91) && (e.KeyChar > 123 || e.KeyChar < 96)
                && (e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (employeeGridView.Rows.Count == 1)
            {
                buttonView.PerformClick();
            }
        }
    }
}