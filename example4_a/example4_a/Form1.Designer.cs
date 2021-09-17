
namespace example4_a
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
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCarEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxNameEmployee = new System.Windows.Forms.TextBox();
            this.textBoxFindOrDelete = new System.Windows.Forms.TextBox();
            this.numericAgeEmployee = new System.Windows.Forms.NumericUpDown();
            this.radioButtonJson = new System.Windows.Forms.RadioButton();
            this.radioButtonXml = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeGridView
            // 
            this.employeeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(37)))), ((int)(((byte)(101)))));
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.employeeGridView.GridColor = System.Drawing.Color.Black;
            this.employeeGridView.Location = new System.Drawing.Point(241, 20);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.RowTemplate.Height = 25;
            this.employeeGridView.Size = new System.Drawing.Size(417, 299);
            this.employeeGridView.TabIndex = 0;
            // 
            // col1
            // 
            this.col1.Frozen = true;
            this.col1.HeaderText = "ID";
            this.col1.Name = "col1";
            this.col1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col1.Width = 60;
            // 
            // col2
            // 
            this.col2.Frozen = true;
            this.col2.HeaderText = "Name";
            this.col2.Name = "col2";
            this.col2.Width = 150;
            // 
            // col3
            // 
            this.col3.Frozen = true;
            this.col3.HeaderText = "Age";
            this.col3.Name = "col3";
            this.col3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col3.Width = 60;
            // 
            // col4
            // 
            this.col4.Frozen = true;
            this.col4.HeaderText = "Car";
            this.col4.Name = "col4";
            this.col4.Width = 150;
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
            this.comboBoxCarEmployee.Location = new System.Drawing.Point(21, 71);
            this.comboBoxCarEmployee.Name = "comboBoxCarEmployee";
            this.comboBoxCarEmployee.Size = new System.Drawing.Size(194, 23);
            this.comboBoxCarEmployee.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter name, age and car:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter format for save:";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(37)))), ((int)(((byte)(101)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSave.Location = new System.Drawing.Point(152, 122);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(37)))), ((int)(((byte)(101)))));
            this.buttonFind.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonFind.Location = new System.Drawing.Point(21, 296);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(63, 23);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(37)))), ((int)(((byte)(101)))));
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDelete.Location = new System.Drawing.Point(152, 294);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(63, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete);
            // 
            // textBoxNameEmployee
            // 
            this.textBoxNameEmployee.BackColor = System.Drawing.Color.White;
            this.textBoxNameEmployee.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNameEmployee.Location = new System.Drawing.Point(21, 42);
            this.textBoxNameEmployee.Name = "textBoxNameEmployee";
            this.textBoxNameEmployee.Size = new System.Drawing.Size(151, 23);
            this.textBoxNameEmployee.TabIndex = 8;
            this.textBoxNameEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNameEmployee_KeyPress);
            // 
            // textBoxFindOrDelete
            // 
            this.textBoxFindOrDelete.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFindOrDelete.Location = new System.Drawing.Point(21, 265);
            this.textBoxFindOrDelete.Name = "textBoxFindOrDelete";
            this.textBoxFindOrDelete.Size = new System.Drawing.Size(194, 23);
            this.textBoxFindOrDelete.TabIndex = 9;
            this.textBoxFindOrDelete.TextChanged += new System.EventHandler(this.TextBoxFindOrDelete_TextChanged);
            // 
            // numericAgeEmployee
            // 
            this.numericAgeEmployee.BackColor = System.Drawing.Color.White;
            this.numericAgeEmployee.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericAgeEmployee.Location = new System.Drawing.Point(179, 42);
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
            this.numericAgeEmployee.TabIndex = 10;
            this.numericAgeEmployee.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // radioButtonJson
            // 
            this.radioButtonJson.AutoSize = true;
            this.radioButtonJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.radioButtonJson.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButtonJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButtonJson.Location = new System.Drawing.Point(21, 124);
            this.radioButtonJson.Name = "radioButtonJson";
            this.radioButtonJson.Size = new System.Drawing.Size(60, 19);
            this.radioButtonJson.TabIndex = 11;
            this.radioButtonJson.TabStop = true;
            this.radioButtonJson.Text = ".json";
            this.radioButtonJson.UseVisualStyleBackColor = false;
            // 
            // radioButtonXml
            // 
            this.radioButtonXml.AutoSize = true;
            this.radioButtonXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.radioButtonXml.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButtonXml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButtonXml.Location = new System.Drawing.Point(90, 124);
            this.radioButtonXml.Name = "radioButtonXml";
            this.radioButtonXml.Size = new System.Drawing.Size(53, 19);
            this.radioButtonXml.TabIndex = 12;
            this.radioButtonXml.TabStop = true;
            this.radioButtonXml.Text = ".xml";
            this.radioButtonXml.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Click \"view\" for looking \r\ndata of employee.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 56);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter name, age or car emp-\r\nloyee for find or name for\r\ndelete:\r\n\r\n";
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(37)))), ((int)(((byte)(101)))));
            this.buttonOpen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOpen.Location = new System.Drawing.Point(152, 187);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(63, 23);
            this.buttonOpen.TabIndex = 15;
            this.buttonOpen.Text = "open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(674, 339);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonXml);
            this.Controls.Add(this.radioButtonJson);
            this.Controls.Add(this.numericAgeEmployee);
            this.Controls.Add(this.textBoxFindOrDelete);
            this.Controls.Add(this.textBoxNameEmployee);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCarEmployee);
            this.Controls.Add(this.employeeGridView);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.ComboBox comboBoxCarEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxNameEmployee;
        private System.Windows.Forms.TextBox textBoxFindOrDelete;
        private System.Windows.Forms.NumericUpDown numericAgeEmployee;
        private System.Windows.Forms.RadioButton radioButtonJson;
        private System.Windows.Forms.RadioButton radioButtonXml;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.Button button2;
    }
}

