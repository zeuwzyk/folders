using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using FileHelper;

namespace example_4
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 64 || e.KeyChar > 91) && (e.KeyChar > 123 || e.KeyChar < 96))//
                e.Handled = true;
            else if (e.KeyChar == null)
                Console.WriteLine("yoy");//замутить потом messagebox
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            int axualiryValue = 0, age;
            string name, car = "";
            Console.WriteLine("\nEnter data:");

            axualiryValue = 0;
            Console.Write("Enter name: ");
            name = textBox1.Text;
            name = name.ToLower();

            car = comboBox1.Text;
            car = car.ToLower();//сделать проверку на тачки

            age = (int)(numericUpDown1.Value);

            textBox1.Text = String.Empty;
            comboBox1.Text = String.Empty;

            if (name != "" && car != "")//обязательно выбрана кнопка
            {
                FileClass.pathFunc(name, age, car);
                MessageBox.Show($"{name} {numericUpDown1.Value} {car}", null, MessageBoxButtons.OK);  //только те тачки, которое есть      
            }
            else
                MessageBox.Show(null, "You not entered all text.", "jo");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            int check = 0, ageEmployee = 0, id = 0, axualiryValue = 0;
            string nameEmployee = "", carEmployee = "";

            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<DataClass>>(jsonString);
            foreach (var data in restoredData)
            {
                int rowNumber = dataGridView1.Rows.Add();
                id = int.Parse(data.Id.ToString());
                ageEmployee = int.Parse(data.Age.ToString());
                nameEmployee = data.Name.ToString();
                carEmployee = data.Car.ToString();

                dataGridView1.Rows[rowNumber].Cells["ID"].Value = id;
                dataGridView1.Rows[rowNumber].Cells[1].Value = nameEmployee;
                dataGridView1.Rows[rowNumber].Cells[2].Value = ageEmployee;
                dataGridView1.Rows[rowNumber].Cells[3].Value = carEmployee;
            }
        }
        private void button3_Click(object sender, EventArgs e)//работает на имя//подгрузка таблицы
        {
            int axualiryValue = 0;
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                    if (0 == String.Compare(dataGridView1[i, j].Value.ToString(), textBox2.Text))
                    {
                        dataGridView1[i, j].Style.BackColor = Color.MediumBlue;
                        dataGridView1[i, j].Style.ForeColor = Color.Lime;
                        axualiryValue++;
                    }
            if (axualiryValue == 0)
                MessageBox.Show(null, "нет совпадений", "ой");

            //this.tableAdapterManager.UpdateAll(this.hostinicaDataSet);
            //textBox1.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)//когда вводишь текст бокс, то авто появление гридки
        {
            string name = "";
            int axualiryValue = 0;
            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Data.DataClass>>(jsonString);

            foreach (var data in restoredData)
            {
                name = data.Name.ToString();
                if (textBox2.Text == name)
                    restoredData.Remove(data);
                else if (textBox2.Text != name && axualiryValue <restoredData.Count-1)
                    MessageBox.Show("Name not found.\n", null, MessageBoxButtons.OK);
                else 
                    MessageBox.Show("Please, enter a name.\n", null, MessageBoxButtons.OK);
                    axualiryValue++;
            }
            foreach (var data in restoredData)
                Console.WriteLine($"{JsonSerializer.Serialize(data)}");

            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };

            using (StreamWriter file = File.CreateText(fileName))
            {
                string data = JsonSerializer.Serialize<List<DataClass>>(restoredData, options);
                file.Write(data);
            }
            textBox2.Text = String.Empty;

            //int a = dataGridView1.CurrentRow.Index;
            //dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
    }
}
