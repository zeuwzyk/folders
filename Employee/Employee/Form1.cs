using System;
using System.Windows.Forms;

namespace Employee
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

            int numberRowsSQL = Helpers.ConnectToDataBase.ReturnNumberRowsSQl();
            int numberRowsConfig = Helpers.ConnectToDataBase.ReturnNumberRowsConfig();

            if (numberRowsSQL > numberRowsConfig)
            {
                MessageBox.Show($"Maximum size of table is {numberRowsConfig} rows. Please, delete any row for continue.", "Message");
                buttonSave.Enabled = false;
            }
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

                    Helpers.DataBaseManager.Save(nameEmployee, ageEmployee, carEmployee);

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
                MessageBox.Show("Please, enter button 'View'.", "Message");
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

                    checkValue = Helpers.GridHelper.FindInformation(employeeGridView, checkValue, textBoxFindOrDelete.Text.ToLower());

                    if (checkValue == 0)
                    {
                        MessageBox.Show("Information is not found.", "Message");
                    }
                }

                textBoxFindOrDelete.Clear();
            }
            else
            {
                MessageBox.Show("Please, enter button 'View'.", "Message");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
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
                    Helpers.DataBaseManager.Delete(employeeGridView, textBoxFindOrDelete, checkValue);
                }

                Helpers.GridHelper.Upgrade(buttonView, textBoxFindOrDelete);
                buttonSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please, enter button 'View'.", "Message");
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            if (buttonViewWasClicked == true)
            {
                int checkValue = 0;

                if (string.IsNullOrEmpty(textBoxFilter.Text) && comboBoxFilter.SelectedIndex == -1)
                {
                    MessageBox.Show("Please, enter information.", "Message");
                }
                else if (textBoxFilter.Text.ToLower() == "skoda" || textBoxFilter.Text.ToLower() == "volkswagen" || textBoxFilter.Text.ToLower() == "bmw")
                {
                    MessageBox.Show("Please, select car from the list.", "Message");
                }
                else
                {
                    buttonView.PerformClick();

                    if ((textBoxFilter.Text.ToLower() != "skoda" || textBoxFilter.Text.ToLower() != "volkswagen" || textBoxFilter.Text.ToLower() != "bmw") && comboBoxFilter.SelectedIndex == -1)
                    {
                        checkValue = Helpers.GridHelper.FilterInformation(employeeGridView, checkValue, textBoxFilter.Text.ToLower());
                    }
                    else
                    {
                        checkValue = Helpers.GridHelper.FilterInformation(employeeGridView, checkValue, comboBoxFilter.Text.ToLower());
                    }

                    if (checkValue == 0)
                    {
                        buttonView.PerformClick();
                        MessageBox.Show("Information for filtration is not found.", "Message");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, enter button 'View'.", "Message");
            }

            comboBoxFilter.SelectedIndex = -1;
            textBoxFilter.Clear();
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
                MessageBox.Show("Please, enter button 'View'.", "Message");
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
                MessageBox.Show("Please, enter button 'View'.", "Message");
                textBoxFindOrDelete.ReadOnly = true;
            }
        }

        private void TextBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (buttonViewWasClicked == true)
            {
                textBoxFilter.ReadOnly = false;

                if (e.KeyChar != 8 && (e.KeyChar < 64 || e.KeyChar > 91) && (e.KeyChar > 123 || e.KeyChar < 96) && (e.KeyChar < 48 || e.KeyChar > 57))
                {
                    e.Handled = true;
                }
            }
            else
            {
                MessageBox.Show("Please, enter button 'View'.", "Message");
                textBoxFilter.ReadOnly = true;
            }
        }
    }
}