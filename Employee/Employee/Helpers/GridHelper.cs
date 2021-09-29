using System.Drawing;
using System.Windows.Forms;

namespace Employee.Helpers
{
    public static class GridHelper
    {
        public static void Initialization(DataGridView employeeGridView, TextBox textBoxNameEmployee)
        {
            try
            {
                int checkValue = DataBaseManager.Open(employeeGridView);

                if (employeeGridView.Rows.Count == 1 && string.IsNullOrEmpty(textBoxNameEmployee.Text) && checkValue != 0)
                {
                    MessageBox.Show("Empty file. Please, save data at database.", "Message");
                }
            }
            catch
            {
                MessageBox.Show("Not correct file was entered.", "Message");
            }
        }

        public static void Filling(DataGridView employeeGridView, int idEmployee, string nameEmployee, int ageEmployee, string carEmployee)
        {
            int rowNumber = employeeGridView.Rows.Add();

            employeeGridView.Rows[rowNumber].Cells["col1"].Value = idEmployee;
            employeeGridView.Rows[rowNumber].Cells["col2"].Value = nameEmployee;
            employeeGridView.Rows[rowNumber].Cells["col3"].Value = ageEmployee;
            employeeGridView.Rows[rowNumber].Cells["col4"].Value = carEmployee;
        }

        public static int FindInformation(DataGridView employeeGridView, int checkValue, string information)
        {
            for (int i = 1; i < employeeGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < employeeGridView.RowCount - 1; j++)
                {
                    try
                    {
                        employeeGridView.Rows[i].Selected = false;
                        employeeGridView[i, j].Style.BackColor = Color.White;
                        employeeGridView[i, j].Style.ForeColor = Color.Black;
                    }
                    catch
                    {
                        MessageBox.Show("No information. Please, entered information.", "Message");
                    }
                }
            }

            for (int i = 1; i < employeeGridView.ColumnCount; i++)
            {
                for (int j = 0; j < employeeGridView.RowCount - 1; j++)
                {
                    if (employeeGridView[i, j].Value.ToString() == information)
                    {
                        employeeGridView[i, j].Style.BackColor = Color.MediumBlue;
                        employeeGridView[i, j].Style.ForeColor = Color.Gold;
                        checkValue = 1;
                    }
                }
            }

            return checkValue;
        }

        public static int FilterInformation(DataGridView employeeGridView, int checkValue, string information)
        {
            for (int i = 1; i < employeeGridView.ColumnCount; i++)
            {
                for (int j = 0; j < employeeGridView.RowCount - 1; j++)
                {
                    employeeGridView.Rows[j].Visible = false;
                }
            }

            for (int i = 1; i < employeeGridView.ColumnCount; i++)
            {
                for (int j = 0; j < employeeGridView.RowCount - 1; j++)
                {
                    if (employeeGridView[i, j].Value.ToString() == information)
                    {
                        employeeGridView.Rows[j].Visible = true;
                        checkValue = 1;
                    }
                }
            }

            return checkValue;
        }

        public static void Upgrade(Button buttonView, TextBox textBoxFindOrDelete)
        {
            textBoxFindOrDelete.Clear();
            buttonView.PerformClick();
        }
    }
}