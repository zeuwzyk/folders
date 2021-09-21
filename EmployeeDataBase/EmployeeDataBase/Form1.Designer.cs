
namespace EmployeeDataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericAgeEmployee = new System.Windows.Forms.NumericUpDown();
            this.textBoxFindOrDelete = new System.Windows.Forms.TextBox();
            this.textBoxNameEmployee = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxCarEmployee = new System.Windows.Forms.ComboBox();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonView.Location = new System.Drawing.Point(148, 191);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(63, 23);
            this.buttonView.TabIndex = 30;
            this.buttonView.Text = "view";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(165)))), ((int)(((byte)(107)))));
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "Click \"view\" for looking data\r\nof employee.";
            // 
            // numericAgeEmployee
            // 
            this.numericAgeEmployee.BackColor = System.Drawing.Color.White;
            this.numericAgeEmployee.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericAgeEmployee.Location = new System.Drawing.Point(175, 33);
            this.numericAgeEmployee.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericAgeEmployee.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericAgeEmployee.Name = "numericAgeEmployee";
            this.numericAgeEmployee.Size = new System.Drawing.Size(36, 23);
            this.numericAgeEmployee.TabIndex = 25;
            this.numericAgeEmployee.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // textBoxFindOrDelete
            // 
            this.textBoxFindOrDelete.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFindOrDelete.Location = new System.Drawing.Point(12, 271);
            this.textBoxFindOrDelete.Name = "textBoxFindOrDelete";
            this.textBoxFindOrDelete.Size = new System.Drawing.Size(199, 23);
            this.textBoxFindOrDelete.TabIndex = 24;
            this.textBoxFindOrDelete.TextChanged += new System.EventHandler(this.TextBoxFindOrDelete_TextChanged);
            // 
            // textBoxNameEmployee
            // 
            this.textBoxNameEmployee.BackColor = System.Drawing.Color.White;
            this.textBoxNameEmployee.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNameEmployee.Location = new System.Drawing.Point(12, 33);
            this.textBoxNameEmployee.Name = "textBoxNameEmployee";
            this.textBoxNameEmployee.Size = new System.Drawing.Size(156, 23);
            this.textBoxNameEmployee.TabIndex = 23;
            this.textBoxNameEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNameEmployee_KeyPress);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDelete.Location = new System.Drawing.Point(148, 300);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(63, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.buttonFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonFind.Location = new System.Drawing.Point(12, 300);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(63, 23);
            this.buttonFind.TabIndex = 21;
            this.buttonFind.Text = "find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(165)))), ((int)(((byte)(107)))));
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter \"save\" for save data \r\nemployee:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(165)))), ((int)(((byte)(107)))));
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter name, age and car:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(165)))), ((int)(((byte)(107)))));
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 48);
            this.label4.TabIndex = 29;
            this.label4.Text = "Enter name, age or car emp-\r\nloyee for find or name for\r\ndelete:";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSave.Location = new System.Drawing.Point(148, 126);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboBoxCarEmployee
            // 
            this.comboBoxCarEmployee.BackColor = System.Drawing.Color.White;
            this.comboBoxCarEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarEmployee.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCarEmployee.FormattingEnabled = true;
            this.comboBoxCarEmployee.Items.AddRange(new object[] {
            "Skoda",
            "BMW",
            "Volkswagen"});
            this.comboBoxCarEmployee.Location = new System.Drawing.Point(12, 61);
            this.comboBoxCarEmployee.Name = "comboBoxCarEmployee";
            this.comboBoxCarEmployee.Size = new System.Drawing.Size(199, 23);
            this.comboBoxCarEmployee.TabIndex = 17;
            // 
            // employeeGridView
            // 
            this.employeeGridView.AllowUserToResizeColumns = false;
            this.employeeGridView.AllowUserToResizeRows = false;
            this.employeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(165)))), ((int)(((byte)(167)))));
            this.employeeGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.employeeGridView.GridColor = System.Drawing.Color.Black;
            this.employeeGridView.Location = new System.Drawing.Point(242, 12);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.RowHeadersVisible = false;
            this.employeeGridView.RowHeadersWidth = 70;
            this.employeeGridView.RowTemplate.Height = 25;
            this.employeeGridView.Size = new System.Drawing.Size(427, 317);
            this.employeeGridView.TabIndex = 16;
            // 
            // col1
            // 
            this.col1.HeaderText = "ID";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col2
            // 
            this.col2.HeaderText = "Name";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.HeaderText = "Age";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col4
            // 
            this.col4.HeaderText = "Car";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(165)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(681, 341);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericAgeEmployee);
            this.Controls.Add(this.textBoxFindOrDelete);
            this.Controls.Add(this.textBoxNameEmployee);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCarEmployee);
            this.Controls.Add(this.employeeGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericAgeEmployee;
        private System.Windows.Forms.TextBox textBoxFindOrDelete;
        private System.Windows.Forms.TextBox textBoxNameEmployee;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxCarEmployee;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
    }
}

