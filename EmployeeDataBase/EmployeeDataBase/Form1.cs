using System;
using System.Windows.Forms;

namespace EmployeeDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool buttonViewWasClicked = false;

        private void ButtonView_Click(object sender, EventArgs e)
        {
            employeeGridView.Rows.Clear();

            buttonViewWasClicked = true;

            Helpers.GridHelper.Initialization(employeeGridView, textBoxNameEmployee);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (buttonViewWasClicked == true)
            {
                if (!string.IsNullOrEmpty(textBoxNameEmployee.Text) && !string.IsNullOrEmpty(comboBoxCarEmployee.Text))
                {
                    var nameEmployee = textBoxNameEmployee.Text.ToLower();
                    var ageEmployee = (int)numericAgeEmployee.Value;
                    var carEmployee = comboBoxCarEmployee.Text.ToLower();

                    Helpers.DataBaseManager.Save(employeeGridView, nameEmployee, ageEmployee, carEmployee);

                    MessageBox.Show("Information was saved.", "Message");
                }
                else
                {
                    MessageBox.Show("You not entered all information.", "Message");
                }

                textBoxNameEmployee.Text = string.Empty;
                comboBoxCarEmployee.SelectedIndex = -1;
                numericAgeEmployee.Value = 18;

                Helpers.GridHelper.Upgrade(buttonView, textBoxFindOrDelete);
            }
            else
            {
                MessageBox.Show("Please enter button 'View'.", "Message");
            }
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            if (buttonViewWasClicked == true)
            {
                int checkValue = 0;

                if (string.IsNullOrEmpty(textBoxFindOrDelete.Text))
                {
                    MessageBox.Show("Please, enter information.", "Message");
                }
                else
                {
                    buttonView.PerformClick();

                    checkValue = Helpers.GridHelper.FindInformation(employeeGridView, checkValue, textBoxFindOrDelete.Text);

                    if (checkValue == 0)
                    {
                        MessageBox.Show("Information not found.", "Message");
                    }
                }

                textBoxFindOrDelete.Clear();
            }
            else
            {
                MessageBox.Show("Please enter button 'View'.", "Message");
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (buttonViewWasClicked == true)
            {
                int checkValue = 0;

                if (string.IsNullOrEmpty(textBoxFindOrDelete.Text))
                {
                    MessageBox.Show("Please, enter name.", "Message");
                }
                else if (!string.IsNullOrEmpty(textBoxFindOrDelete.Text))
                {
                    Helpers.DataBaseManager.Remove(employeeGridView, textBoxFindOrDelete, checkValue);
                }

                Helpers.GridHelper.Upgrade(buttonView, textBoxFindOrDelete);
            }
            else
            {
                MessageBox.Show("Please enter button 'View'.", "Message");
            }
        }

        private void TextBoxNameEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (buttonViewWasClicked == true)
            {
                textBoxNameEmployee.ReadOnly = false;

                if (e.KeyChar != 8 && (e.KeyChar < 64 || e.KeyChar > 91) && (e.KeyChar > 123 || e.KeyChar < 96))
                {
                    e.Handled = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter button 'View'.", "Message");
                textBoxNameEmployee.ReadOnly = true;
            }
        }

        private void TextBoxFindOrDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (buttonViewWasClicked == true)
            {
                textBoxFindOrDelete.ReadOnly = false;

                if (e.KeyChar != 8 && (e.KeyChar < 64 || e.KeyChar > 91) && (e.KeyChar > 123 || e.KeyChar < 96) && (e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter button 'View'.", "Message");
                textBoxFindOrDelete.ReadOnly = true;
            }
        }
    }
}