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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameEmployee.Text) && !string.IsNullOrEmpty(comboBoxCarEmployee.Text))
            {
                var nameEmployee = textBoxNameEmployee.Text.ToLower();
                var ageEmployee = (int)numericAgeEmployee.Value;
                var carEmployee = comboBoxCarEmployee.Text.ToLower();

                Helpers.DataBaseManager.SaveDB(employeeGridView, nameEmployee, ageEmployee, carEmployee);

                MessageBox.Show("Information was saved.", "Message");
            }
            else
            {
                MessageBox.Show("You not entered all information.", "Message");
            }

            textBoxNameEmployee.Text = string.Empty;
            comboBoxCarEmployee.SelectedIndex = -1;
            numericAgeEmployee.Value = 18;

            Helpers.GridHelper.UpgradeGride(employeeGridView, buttonView, textBoxFindOrDelete, 0);
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            employeeGridView.Rows.Clear();
            Helpers.GridHelper.InitializationGrid(employeeGridView, textBoxNameEmployee);
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            int checkValue = 0;

            Helpers.GridHelper.UpgradeGride(employeeGridView, buttonView, textBoxFindOrDelete, 1);

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

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int checkValue = 0;

            Helpers.GridHelper.UpgradeGride(employeeGridView, buttonView, textBoxFindOrDelete, 1);

            if (string.IsNullOrEmpty(textBoxFindOrDelete.Text))
            {
                MessageBox.Show("Please, enter name.", "Message");
            }
            else if (!string.IsNullOrEmpty(textBoxFindOrDelete.Text))
            {
                Helpers.DataBaseManager.DeleteFromBD(employeeGridView, textBoxFindOrDelete, checkValue);
            }

            Helpers.GridHelper.UpgradeGride(employeeGridView, buttonView, textBoxFindOrDelete, 0);
        }

        private void TextBoxFindOrDelete_TextChanged(object sender, EventArgs e)
        {
            Helpers.GridHelper.UpgradeGride(employeeGridView, buttonView, textBoxFindOrDelete, 1);
        }

        private void TextBoxNameEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 64 || e.KeyChar > 91) && (e.KeyChar > 123 || e.KeyChar < 96))
            {
                e.Handled = true;
            }
        }

        private void TextBoxFindOrDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 64 || e.KeyChar > 91) && (e.KeyChar > 123 || e.KeyChar < 96) && (e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        private void TextBoxNameEmployee_TextChanged(object sender, EventArgs e)
        {
            Helpers.GridHelper.UpgradeGride(employeeGridView, buttonView, textBoxFindOrDelete, 1);
        }
    }
}