using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Xml.Linq;

namespace example4_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            employeeGridView.RowHeadersVisible = false;
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

        private void ButtonSave(object sender, EventArgs e)
        {
            int ageEmployee;
            string nameEmployee;
            string carEmployee;

            nameEmployee = textBoxNameEmployee.Text;
            nameEmployee = nameEmployee.ToLower();

            carEmployee = comboBoxCarEmployee.Text;
            carEmployee = carEmployee.ToLower();

            ageEmployee = (int)(numericAgeEmployee.Value);

            textBoxNameEmployee.Text = string.Empty;
            comboBoxCarEmployee.Text = string.Empty;

            if (nameEmployee != "" && carEmployee != "" && radioButtonJson.Checked)
            {
                FileHelper.SaveJson(nameEmployee, ageEmployee, carEmployee);
                MessageBox.Show($"{nameEmployee} {numericAgeEmployee.Value} {carEmployee}", "Message");
            }
            else if (nameEmployee != "" && carEmployee != "" && radioButtonXml.Checked)
            {
                FileHelper.SaveXml(nameEmployee, ageEmployee, carEmployee);
                MessageBox.Show($"{nameEmployee} {numericAgeEmployee.Value} {carEmployee}", "Message");
            }
            else
            {
                MessageBox.Show(null, "You not entered all text or not entered radio button.", "Message");
            }
        }

        private void ButtonOpen(object sender, EventArgs e)
        {
            employeeGridView.Rows.Clear();

            string fileName = FileHelper.OpenFile(1);

            InitializationValueGrid(fileName);
        }

        public void InitializationValueGrid(string fileName)
        {
            if (fileName.Contains(".json"))
            {
                int ageEmployee;
                int idEmployee;
                string nameEmployee;
                string carEmployee;

                string jsonString = File.ReadAllText(fileName);
                List<DataEmployee> restoredData = new List<DataEmployee> { };

                try
                {
                    restoredData = JsonSerializer.Deserialize<List<DataEmployee>>(jsonString);
                }
                catch
                {
                    MessageBox.Show("Not correct file was entered.", "Message");
                }

                foreach (var data in restoredData)
                {
                    idEmployee = int.Parse(data.Id.ToString());
                    ageEmployee = int.Parse(data.Age.ToString());
                    nameEmployee = data.Name.ToString();
                    carEmployee = data.Car.ToString();

                    FillingGrid(idEmployee, nameEmployee, ageEmployee, carEmployee);
                }
            }
            else if (fileName.Contains(".xml"))
            {
                XDocument xdoc = XDocument.Load(fileName);
                XElement root = xdoc.Element("root");

                if (root != null)
                {
                    foreach (XElement employeeData in root.Elements("employee"))
                    {
                        XElement IdX = employeeData.Element("id");
                        XElement nameEmplX = employeeData.Element("name");
                        XElement ageEmplX = employeeData.Element("age");
                        XElement carEmplX = employeeData.Element("car");

                        FillingGrid(int.Parse(IdX.Value), nameEmplX.Value, int.Parse(ageEmplX.Value), carEmplX.Value);
                    }
                }
                else
                {
                    MessageBox.Show("Not correct file was entered.", "Message");
                }
            }
        }

        public void FillingGrid(int id, string nameEmployee, int ageEmployee, string carEmployee)
        {
            int rowNumber = employeeGridView.Rows.Add();

            employeeGridView.Rows[rowNumber].Cells["col1"].Value = id;
            employeeGridView.Rows[rowNumber].Cells["col2"].Value = nameEmployee;
            employeeGridView.Rows[rowNumber].Cells["col3"].Value = ageEmployee;
            employeeGridView.Rows[rowNumber].Cells["col4"].Value = carEmployee;
        }

        private void ButtonFind(object sender, EventArgs e)
        {
            int axualiryValue = 0;
            string fileName = FileHelper.OpenFile(0);

            if (fileName == "")
            {
                buttonOpen.PerformClick();
            }

            if (textBoxFindOrDelete.Text == "")
            {
                MessageBox.Show(null, "Please, enter information.", "Message");
            }
            else
            {
                for (int i = 1; i < employeeGridView.ColumnCount; i++)
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
                        if (0 == string.Compare(employeeGridView[i, j].Value.ToString(), textBoxFindOrDelete.Text))
                        {
                            employeeGridView[i, j].Style.BackColor = Color.MediumBlue;
                            employeeGridView[i, j].Style.ForeColor = Color.Gold;
                            axualiryValue = 1;
                        }
                    }
                }

                if (axualiryValue == 0)
                {
                    MessageBox.Show(null, "Not found.", "Message");
                }
            }
        }

        private void ButtonDelete(object sender, EventArgs e)
        {
            string fileName = FileHelper.OpenFile(0);

            if (fileName == "")
            {
                buttonOpen.PerformClick();
            }

            string name = textBoxFindOrDelete.Text;
            name = name.ToLower();

            if (textBoxFindOrDelete.Text == "")
            {
                MessageBox.Show(null, "Please, enter name.", "Message");
            }
            else
            {
                if (fileName.Contains(".xml"))
                {
                    FileManager.RemoveFromXml(name, fileName);
                }
                else if (fileName.Contains(".json"))
                {
                    FileManager.RemoveFromJson(name, fileName);
                }
            }

            textBoxFindOrDelete.Text = string.Empty;
        }

        private void TextBoxFindOrDelete_TextChanged(object sender, EventArgs e)
        {
            string fileName = FileHelper.OpenFile(0);

            if (fileName == "")
            {
                buttonOpen.PerformClick();
            }
        }
    }
}
