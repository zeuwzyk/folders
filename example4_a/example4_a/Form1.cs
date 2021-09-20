using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace example4_a
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
                FileHelper.SaveFile(nameEmployee, ageEmployee, carEmployee, "json");
                MessageBox.Show($"{nameEmployee} {numericAgeEmployee.Value} {carEmployee}", "Message");
            }
            else if (nameEmployee != "" && carEmployee != "" && radioButtonXml.Checked)
            {
                FileHelper.SaveFile(nameEmployee, ageEmployee, carEmployee, "xml");
                MessageBox.Show($"{nameEmployee} {numericAgeEmployee.Value} {carEmployee}", "Message");
            }
            else
            {
                MessageBox.Show("You not entered all text or not entered radio button.", "Message");
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
                int idEmployee;
                int ageEmployee;
                string nameEmployee;
                string carEmployee;

                string jsonString = File.ReadAllText(fileName);
                var restoredData = new List<DataEmployee> { };

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
                XDocument docXml = XDocument.Load(fileName);
                XElement rootXml = docXml.Element("root");

                if (rootXml != null)
                {
                    foreach (XElement employeeData in rootXml.Elements("employee"))
                    {
                        XElement IdEmplX = employeeData.Element("id");
                        XElement nameEmplX = employeeData.Element("name");
                        XElement ageEmplX = employeeData.Element("age");
                        XElement carEmplX = employeeData.Element("car");

                        FillingGrid(int.Parse(IdEmplX.Value), nameEmplX.Value, int.Parse(ageEmplX.Value), carEmplX.Value);
                    }
                }
                else
                {
                    MessageBox.Show("Not correct file was entered.", "Message");
                }
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

        private void ButtonFind(object sender, EventArgs e)
        {
            int checkValue = 0;
            string fileName = FileHelper.OpenFile(0);

            if (fileName == null || fileName == "")
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
                            checkValue = 1;
                        }
                    }
                }

                if (checkValue == 0)
                {
                    MessageBox.Show(null, "Information not found.", "Message");
                }
            }
        }

        private void ButtonDelete(object sender, EventArgs e)
        {
            string fileName = FileHelper.OpenFile(0);

            if (fileName == null || fileName == "")
            {
                buttonOpen.PerformClick();
            }

            string nameFromTextBox = textBoxFindOrDelete.Text;
            nameFromTextBox = nameFromTextBox.ToLower();

            if (textBoxFindOrDelete.Text == "" || textBoxFindOrDelete.Text == null)
            {
                MessageBox.Show(null, "Please, enter name.", "Message");
            }
            else
            {
                if (fileName.Contains(".xml"))
                {
                    FileManager.RemoveFromFile(nameFromTextBox, fileName, "xml");
                }
                else if (fileName.Contains(".json"))
                {
                    FileManager.RemoveFromFile(nameFromTextBox, fileName, "json");
                }
            }

            textBoxFindOrDelete.Text = string.Empty;

            fileName = FileHelper.OpenFile(0);

            employeeGridView.Rows.Clear();
            InitializationValueGrid(fileName);
        }

        private void TextBoxFindOrDelete_TextChanged(object sender, EventArgs e)
        {
            string fileName = FileHelper.OpenFile(0);

            if (fileName == null || fileName == "")
            {
                buttonOpen.PerformClick();
            }
        }
    }
}
