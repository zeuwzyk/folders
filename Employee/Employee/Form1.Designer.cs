
namespace Employee
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
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNameEmployee = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCarEmployee = new System.Windows.Forms.ComboBox();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.DimGray;
            this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Location = new System.Drawing.Point(562, 136);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(63, 23);
            this.buttonView.TabIndex = 43;
            this.buttonView.Text = "view";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(490, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 101);
            this.label3.TabIndex = 41;
            this.label3.Text = "CLICK \"VIEW\" FOR \r\nLOOKING DATA \r\nOF EMPLOYEE\r\nAND \r\nSTARTING WORK.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericAgeEmployee
            // 
            this.numericAgeEmployee.BackColor = System.Drawing.Color.White;
            this.numericAgeEmployee.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericAgeEmployee.Location = new System.Drawing.Point(138, 46);
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
            this.numericAgeEmployee.TabIndex = 40;
            this.numericAgeEmployee.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // textBoxFindOrDelete
            // 
            this.textBoxFindOrDelete.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFindOrDelete.Location = new System.Drawing.Point(6, 82);
            this.textBoxFindOrDelete.Name = "textBoxFindOrDelete";
            this.textBoxFindOrDelete.Size = new System.Drawing.Size(168, 23);
            this.textBoxFindOrDelete.TabIndex = 39;
            this.textBoxFindOrDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFindOrDelete_KeyPress);
            // 
            // col3
            // 
            this.col3.HeaderText = "Age";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col2
            // 
            this.col2.HeaderText = "Name";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col1
            // 
            this.col1.HeaderText = "ID";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DimGray;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(111, 149);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 23);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textBoxNameEmployee
            // 
            this.textBoxNameEmployee.BackColor = System.Drawing.Color.White;
            this.textBoxNameEmployee.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNameEmployee.Location = new System.Drawing.Point(6, 46);
            this.textBoxNameEmployee.Name = "textBoxNameEmployee";
            this.textBoxNameEmployee.Size = new System.Drawing.Size(126, 23);
            this.textBoxNameEmployee.TabIndex = 38;
            this.textBoxNameEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNameEmployee_KeyPress);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DimGray;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(110, 111);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(63, 23);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.DimGray;
            this.buttonFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFind.ForeColor = System.Drawing.Color.White;
            this.buttonFind.Location = new System.Drawing.Point(6, 111);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(63, 23);
            this.buttonFind.TabIndex = 36;
            this.buttonFind.Text = "find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Enter \"save\" for save da-\r\nta employee.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Enter name, age and car:";
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
            this.comboBoxCarEmployee.Location = new System.Drawing.Point(6, 80);
            this.comboBoxCarEmployee.Name = "comboBoxCarEmployee";
            this.comboBoxCarEmployee.Size = new System.Drawing.Size(168, 23);
            this.comboBoxCarEmployee.TabIndex = 32;
            // 
            // employeeGridView
            // 
            this.employeeGridView.AllowUserToResizeColumns = false;
            this.employeeGridView.AllowUserToResizeRows = false;
            this.employeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.employeeGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.employeeGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.employeeGridView.Location = new System.Drawing.Point(12, 12);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.RowHeadersVisible = false;
            this.employeeGridView.RowHeadersWidth = 70;
            this.employeeGridView.RowTemplate.Height = 25;
            this.employeeGridView.Size = new System.Drawing.Size(472, 370);
            this.employeeGridView.TabIndex = 31;
            // 
            // col4
            // 
            this.col4.HeaderText = "Car";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 48);
            this.label4.TabIndex = 42;
            this.label4.Text = "Enter name, age or car \r\nemployee for find or \r\nenter name for delete:";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFilter.Location = new System.Drawing.Point(203, 82);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(168, 23);
            this.textBoxFilter.TabIndex = 44;
            this.textBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFilter_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(308, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.Color.White;
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Skoda",
            "BMW",
            "Volkswagen"});
            this.comboBoxFilter.Location = new System.Drawing.Point(203, 111);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(168, 23);
            this.comboBoxFilter.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(203, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 48);
            this.label5.TabIndex = 47;
            this.label5.Text = "Enter name or age or \r\ncheck car for filter in-\r\nformation:\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxCarEmployee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNameEmployee);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.numericAgeEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox1.Location = new System.Drawing.Point(692, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 193);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENTER AND SAVE DATA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBoxFilter);
            this.groupBox2.Controls.Add(this.textBoxFilter);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxFindOrDelete);
            this.groupBox2.Controls.Add(this.buttonFind);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox2.Location = new System.Drawing.Point(495, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 171);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FIND, DELETE OR FILTER DATA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(893, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeeGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericAgeEmployee;
        private System.Windows.Forms.TextBox textBoxFindOrDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxNameEmployee;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCarEmployee;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

