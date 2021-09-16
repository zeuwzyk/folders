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
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Files (*.json, *.xml) | *.json; *.xml";
            openFileDialog1.RestoreDirectory = true;

            dataGridView1.RowHeadersVisible = false;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 64 || e.KeyChar > 91) && (e.KeyChar > 123 || e.KeyChar < 96))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 0)
            {
                MessageBox.Show("Not correct symbol was entered.\n", "Message", MessageBoxButtons.OK);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int ageEmployee;
            string nameEmployee, carEmployee;

            Console.WriteLine("\nEnter data:");
            Console.Write("Enter name: ");

            nameEmployee = textBox1.Text;
            nameEmployee = nameEmployee.ToLower();

            carEmployee = comboBox1.Text;
            carEmployee = carEmployee.ToLower();

            ageEmployee = (int)(numericUpDown1.Value);

            textBox1.Text = string.Empty;
            comboBox1.Text = string.Empty;

            if (nameEmployee != "" && carEmployee != "" && radioButton1.Checked)
            {
                FileHelper.SaveJson(nameEmployee, ageEmployee, carEmployee);
                MessageBox.Show($"{nameEmployee} {numericUpDown1.Value} {carEmployee}", "Message", MessageBoxButtons.OK);
            }
            else if (nameEmployee != "" && carEmployee != "" && radioButton2.Checked)
            {
                FileHelper.SaveXml(nameEmployee, ageEmployee, carEmployee);
                MessageBox.Show($"{nameEmployee} {numericUpDown1.Value} {carEmployee}", "Message", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "You not entered all text or not entered radio button.", "Message");
            }
        }

        public string fileName = "";//!!!!! 5-z кнопка
        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            InitializationValueGrid(fileName);
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            openFileDialog1.Title = "Upload file.";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
            }

            InitializationValueGrid(fileName);
        }

        public void InitializationValueGrid(string fileName)//***
        {
            if (fileName.Contains(".json"))
            {
                int ageEmployee, id;
                string nameEmployee, carEmployee;
                string jsonString = File.ReadAllText(fileName);
                List<DataEmployee> restoredData = new List<DataEmployee> { };

                try
                {
                    restoredData = JsonSerializer.Deserialize<List<DataEmployee>>(jsonString);
                }
                catch
                {
                    MessageBox.Show("Not correct file was entered.");
                }

                foreach (var data in restoredData)
                {
                    id = int.Parse(data.Id.ToString());
                    ageEmployee = int.Parse(data.Age.ToString());
                    nameEmployee = data.Name.ToString();
                    carEmployee = data.Car.ToString();

                    FillingGrid(id, nameEmployee, ageEmployee, carEmployee);
                }
            }
            else if (fileName.Contains(".xml"))
            {
                XDocument xdoc = XDocument.Load(fileName);
                XElement root = xdoc.Element("root");

                if (root != null)//!!!!!!!
                {
                    foreach (XElement employeeData in root.Elements("employee"))//туть
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
                    MessageBox.Show("Not correct file was entered.");
                }
            }
        }

        public void FillingGrid(int id, string nameEmployee, int ageEmployee, string carEmployee)//?? не могу из за грида вытащить
        {
            int rowNumber = dataGridView1.Rows.Add();

            dataGridView1.Rows[rowNumber].Cells["col1"].Value = id;
            dataGridView1.Rows[rowNumber].Cells["col2"].Value = nameEmployee;
            dataGridView1.Rows[rowNumber].Cells["col3"].Value = ageEmployee;
            dataGridView1.Rows[rowNumber].Cells["col4"].Value = carEmployee;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button2.PerformClick();

            int axualiryValue = 0;

            if (fileName == "")
            {
                button5.PerformClick();
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show(null, "Please, enter information.", "Message");
            }
            else
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                    {
                        dataGridView1.Rows[i].Selected = false;
                        dataGridView1[i, j].Style.BackColor = Color.White;
                        dataGridView1[i, j].Style.ForeColor = Color.Black;
                    }
                }

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                        if (0 == string.Compare(dataGridView1[i, j].Value.ToString(), textBox2.Text))
                        {
                            dataGridView1[i, j].Style.BackColor = Color.MediumBlue;
                            dataGridView1[i, j].Style.ForeColor = Color.Gold;
                            axualiryValue = 1;
                        }
                }

                if (axualiryValue == 0)
                {
                    MessageBox.Show(null, "Not found.", "Message");
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button2.PerformClick();

            if (fileName == "")
            {
                button5.PerformClick();
            }

            string name = textBox2.Text;
            name = name.ToLower();

            if (textBox2.Text == "")
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

            textBox2.Text = string.Empty;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            button2.PerformClick();

            if (fileName == "")
            {
                button5.PerformClick();
            }
        }
    }
}
