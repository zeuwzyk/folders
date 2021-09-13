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

namespace example_4
{
    enum Cars
    {
        bmw,
        volkswagen,
        skoda
    }
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
            MessageBox.Show($"{textBox1.Text} {numericUpDown1.Value} {comboBox1.Text}", null, MessageBoxButtons.OK);  //только те тачки, которое есть      

            int axualiryValue = 0, age;
            string name, car= "";
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

            pathFunc(name, age, car);



        }
        private void button2_Click(object sender, EventArgs e)
        {
            int age = 0, check = 0, ages = 0, id=0, axualiryValue = 0;
            string name = "", car = "";            

            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Data.DataClass>>(jsonString);
            foreach (var data in restoredData)
            {
                int rowNumber = dataGridView1.Rows.Add();
                id = int.Parse(data.Id.ToString());
                ages = int.Parse(data.Age.ToString());
                name = data.Name.ToString();
                car = data.Car.ToString();

                dataGridView1.Rows[rowNumber].Cells["ID"].Value= id;
                dataGridView1.Rows[rowNumber].Cells[1].Value = name;
                dataGridView1.Rows[rowNumber].Cells[2].Value = ages;
                dataGridView1.Rows[rowNumber].Cells[3].Value = car;
            }
        }

        private void button3_Click(object sender, EventArgs e)//работает на имя//подгрузка таблицы
        {
            int flag = 0;
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
                        flag++;
                    }
            if (flag == 0)
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
                {
                    restoredData.Remove(data);
                    axualiryValue++;
                    break;
                }
                else if (textBox2.Text != name && axualiryValue == 3)
                {
                    MessageBox.Show("Name not found.\n", null, MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    MessageBox.Show("Please, enter a name or click button 'view'.\n", null, MessageBoxButtons.OK);
                    break;
                }
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
                string data = JsonSerializer.Serialize<List<Data.DataClass>>(restoredData, options);
                file.Write(data);
            }
            textBox2.Text = String.Empty;

            //int a = dataGridView1.CurrentRow.Index;
            //dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }
        public static void pathFunc(string name, int age, string car)
        {
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            int id = 1;

            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Data.DataClass>>(jsonString);
            foreach (var data in restoredData)
            {
                id = int.Parse(data.Id.ToString());
            }
            id += 1;

            restoredData.Add(new Data.DataClass()
            {
                Id = id,
                Name = name,
                Age = age,
                Car = car
            }
            );

            using (StreamWriter file = File.CreateText(fileName))
            {
                string data = JsonSerializer.Serialize<List<Data.DataClass>>(restoredData, options);
                file.Write(data);
            }
        }
    }
}
