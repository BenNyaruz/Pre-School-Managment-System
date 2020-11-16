namespace Pre_School_Managment_System
{
    partial class Student_Fees_Uniforms_n_Transport_Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Fees_Uniforms_n_Transport_Payment));
            this.School_Term_txt = new System.Windows.Forms.ComboBox();
            this.feesManagmenttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.studentRegistrationRecordtblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.systemDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.School_Term_lbl = new System.Windows.Forms.Label();
            this.Student_Name_lbl = new System.Windows.Forms.Label();
            this.Student_Name_txt = new System.Windows.Forms.ComboBox();
            this.studentRegistrationRecordtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Save_btn = new System.Windows.Forms.Button();
            this.User_txt = new System.Windows.Forms.Label();
            this.School_Fees_groupBox = new System.Windows.Forms.GroupBox();
            this.Fees_Balance_txt = new System.Windows.Forms.NumericUpDown();
            this.Fees_Balance_lbl = new System.Windows.Forms.Label();
            this.School_Fees_txt = new System.Windows.Forms.NumericUpDown();
            this.Fees_Other_radioButton = new System.Windows.Forms.RadioButton();
            this.Fees_Bank_radioButton = new System.Windows.Forms.RadioButton();
            this.Cash_Fees_radioButton = new System.Windows.Forms.RadioButton();
            this.Fees_Transfer_radioButton = new System.Windows.Forms.RadioButton();
            this.Transfer_Rate_lbl = new System.Windows.Forms.Label();
            this.Bank_Rate_lbl = new System.Windows.Forms.Label();
            this.Other_Rate_lbl = new System.Windows.Forms.Label();
            this.Payment_Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Transport_Date_lbl = new System.Windows.Forms.Label();
            this.Transport_Fees_groupBox = new System.Windows.Forms.GroupBox();
            this.Transport_Balance_txt = new System.Windows.Forms.NumericUpDown();
            this.Transport_Balance_lbl = new System.Windows.Forms.Label();
            this.Transport_Fees_txt = new System.Windows.Forms.NumericUpDown();
            this.Transport_Other_radioButton = new System.Windows.Forms.RadioButton();
            this.Transport_Bank_radioButton = new System.Windows.Forms.RadioButton();
            this.Cash_Transport_radioButton = new System.Windows.Forms.RadioButton();
            this.Transport_Transfer_radioButton = new System.Windows.Forms.RadioButton();
            this.Uniform_Prices_groupBox = new System.Windows.Forms.GroupBox();
            this.Uniform_Balance_txt = new System.Windows.Forms.NumericUpDown();
            this.Uniform_Balance_lbl = new System.Windows.Forms.Label();
            this.Uniforms_Prices_txt = new System.Windows.Forms.NumericUpDown();
            this.Uniforms_Other_radioButton = new System.Windows.Forms.RadioButton();
            this.Uniforms_Bank_radioButton = new System.Windows.Forms.RadioButton();
            this.Cash_Uniforms_radioButton = new System.Windows.Forms.RadioButton();
            this.Uniforms_Transfer_radioButton = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.Surname_lbl = new System.Windows.Forms.Label();
            this.REGISTERED_lbl = new System.Windows.Forms.Label();
            this.student_Registration_Record_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Student_Registration_Record_tblTableAdapter();
            this.fees_Managment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Fees_Managment_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.feesManagmenttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource)).BeginInit();
            this.School_Fees_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fees_Balance_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.School_Fees_txt)).BeginInit();
            this.Transport_Fees_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transport_Balance_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transport_Fees_txt)).BeginInit();
            this.Uniform_Prices_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Uniform_Balance_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uniforms_Prices_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // School_Term_txt
            // 
            this.School_Term_txt.DataSource = this.feesManagmenttblBindingSource;
            this.School_Term_txt.DisplayMember = "School_Term";
            this.School_Term_txt.FormattingEnabled = true;
            this.School_Term_txt.Location = new System.Drawing.Point(1195, 40);
            this.School_Term_txt.Name = "School_Term_txt";
            this.School_Term_txt.Size = new System.Drawing.Size(303, 30);
            this.School_Term_txt.TabIndex = 3;
            this.School_Term_txt.SelectedIndexChanged += new System.EventHandler(this.School_Term_txt_SelectedIndexChanged);
            // 
            // feesManagmenttblBindingSource
            // 
            this.feesManagmenttblBindingSource.DataMember = "Fees_Managment_tbl";
            this.feesManagmenttblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // system_DatabaseDataSet
            // 
            this.system_DatabaseDataSet.DataSetName = "System_DatabaseDataSet";
            this.system_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentRegistrationRecordtblBindingSource1
            // 
            this.studentRegistrationRecordtblBindingSource1.DataMember = "Student_Registration_Record_tbl";
            this.studentRegistrationRecordtblBindingSource1.DataSource = this.systemDatabaseDataSetBindingSource;
            // 
            // systemDatabaseDataSetBindingSource
            // 
            this.systemDatabaseDataSetBindingSource.DataSource = this.system_DatabaseDataSet;
            this.systemDatabaseDataSetBindingSource.Position = 0;
            // 
            // School_Term_lbl
            // 
            this.School_Term_lbl.AutoSize = true;
            this.School_Term_lbl.Location = new System.Drawing.Point(1052, 43);
            this.School_Term_lbl.Name = "School_Term_lbl";
            this.School_Term_lbl.Size = new System.Drawing.Size(136, 22);
            this.School_Term_lbl.TabIndex = 81;
            this.School_Term_lbl.Text = "School Term :";
            // 
            // Student_Name_lbl
            // 
            this.Student_Name_lbl.AutoSize = true;
            this.Student_Name_lbl.Location = new System.Drawing.Point(30, 45);
            this.Student_Name_lbl.Name = "Student_Name_lbl";
            this.Student_Name_lbl.Size = new System.Drawing.Size(151, 22);
            this.Student_Name_lbl.TabIndex = 83;
            this.Student_Name_lbl.Text = "Student Name :";
            // 
            // Student_Name_txt
            // 
            this.Student_Name_txt.DataSource = this.studentRegistrationRecordtblBindingSource;
            this.Student_Name_txt.DisplayMember = "First_Name";
            this.Student_Name_txt.FormattingEnabled = true;
            this.Student_Name_txt.Location = new System.Drawing.Point(184, 42);
            this.Student_Name_txt.Name = "Student_Name_txt";
            this.Student_Name_txt.Size = new System.Drawing.Size(292, 30);
            this.Student_Name_txt.TabIndex = 1;
            this.Student_Name_txt.SelectedIndexChanged += new System.EventHandler(this.Student_Name_txt_SelectedIndexChanged);
            // 
            // studentRegistrationRecordtblBindingSource
            // 
            this.studentRegistrationRecordtblBindingSource.DataMember = "Student_Registration_Record_tbl";
            this.studentRegistrationRecordtblBindingSource.DataSource = this.systemDatabaseDataSetBindingSource;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.Lime;
            this.Save_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Save_btn.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(664, 546);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(173, 78);
            this.Save_btn.TabIndex = 86;
            this.Save_btn.Text = "&Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(28, 615);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 90;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // School_Fees_groupBox
            // 
            this.School_Fees_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.School_Fees_groupBox.Controls.Add(this.Fees_Balance_txt);
            this.School_Fees_groupBox.Controls.Add(this.Fees_Balance_lbl);
            this.School_Fees_groupBox.Controls.Add(this.School_Fees_txt);
            this.School_Fees_groupBox.Controls.Add(this.Fees_Other_radioButton);
            this.School_Fees_groupBox.Controls.Add(this.Fees_Bank_radioButton);
            this.School_Fees_groupBox.Controls.Add(this.Cash_Fees_radioButton);
            this.School_Fees_groupBox.Controls.Add(this.Fees_Transfer_radioButton);
            this.School_Fees_groupBox.ForeColor = System.Drawing.Color.Black;
            this.School_Fees_groupBox.Location = new System.Drawing.Point(34, 157);
            this.School_Fees_groupBox.Name = "School_Fees_groupBox";
            this.School_Fees_groupBox.Size = new System.Drawing.Size(442, 290);
            this.School_Fees_groupBox.TabIndex = 91;
            this.School_Fees_groupBox.TabStop = false;
            this.School_Fees_groupBox.Text = "School Fees";
            // 
            // Fees_Balance_txt
            // 
            this.Fees_Balance_txt.AutoSize = true;
            this.Fees_Balance_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Fees_Balance_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fees_Balance_txt.DecimalPlaces = 2;
            this.Fees_Balance_txt.ForeColor = System.Drawing.Color.Red;
            this.Fees_Balance_txt.Location = new System.Drawing.Point(230, 40);
            this.Fees_Balance_txt.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Fees_Balance_txt.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.Fees_Balance_txt.Name = "Fees_Balance_txt";
            this.Fees_Balance_txt.ReadOnly = true;
            this.Fees_Balance_txt.Size = new System.Drawing.Size(204, 25);
            this.Fees_Balance_txt.TabIndex = 93;
            this.Fees_Balance_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fees_Balance_txt.ThousandsSeparator = true;
            // 
            // Fees_Balance_lbl
            // 
            this.Fees_Balance_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fees_Balance_lbl.AutoSize = true;
            this.Fees_Balance_lbl.ForeColor = System.Drawing.Color.Red;
            this.Fees_Balance_lbl.Location = new System.Drawing.Point(36, 43);
            this.Fees_Balance_lbl.Name = "Fees_Balance_lbl";
            this.Fees_Balance_lbl.Size = new System.Drawing.Size(143, 22);
            this.Fees_Balance_lbl.TabIndex = 92;
            this.Fees_Balance_lbl.Text = "Fees Balance :";
            // 
            // School_Fees_txt
            // 
            this.School_Fees_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.School_Fees_txt.DecimalPlaces = 2;
            this.School_Fees_txt.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.School_Fees_txt.ForeColor = System.Drawing.Color.Blue;
            this.School_Fees_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.School_Fees_txt.Location = new System.Drawing.Point(6, 176);
            this.School_Fees_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.School_Fees_txt.Name = "School_Fees_txt";
            this.School_Fees_txt.Size = new System.Drawing.Size(430, 60);
            this.School_Fees_txt.TabIndex = 8;
            this.School_Fees_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.School_Fees_txt.ThousandsSeparator = true;
            // 
            // Fees_Other_radioButton
            // 
            this.Fees_Other_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fees_Other_radioButton.AutoSize = true;
            this.Fees_Other_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fees_Other_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Fees_Other_radioButton.Location = new System.Drawing.Point(356, 106);
            this.Fees_Other_radioButton.Name = "Fees_Other_radioButton";
            this.Fees_Other_radioButton.Size = new System.Drawing.Size(79, 26);
            this.Fees_Other_radioButton.TabIndex = 7;
            this.Fees_Other_radioButton.TabStop = true;
            this.Fees_Other_radioButton.Text = "Other";
            this.Fees_Other_radioButton.UseVisualStyleBackColor = true;
            this.Fees_Other_radioButton.CheckedChanged += new System.EventHandler(this.Fees_Other_radioButton_CheckedChanged);
            // 
            // Fees_Bank_radioButton
            // 
            this.Fees_Bank_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fees_Bank_radioButton.AutoSize = true;
            this.Fees_Bank_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fees_Bank_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Fees_Bank_radioButton.Location = new System.Drawing.Point(249, 106);
            this.Fees_Bank_radioButton.Name = "Fees_Bank_radioButton";
            this.Fees_Bank_radioButton.Size = new System.Drawing.Size(74, 26);
            this.Fees_Bank_radioButton.TabIndex = 6;
            this.Fees_Bank_radioButton.TabStop = true;
            this.Fees_Bank_radioButton.Text = "Bank";
            this.Fees_Bank_radioButton.UseVisualStyleBackColor = true;
            this.Fees_Bank_radioButton.CheckedChanged += new System.EventHandler(this.Fees_Bank_radioButton_CheckedChanged);
            // 
            // Cash_Fees_radioButton
            // 
            this.Cash_Fees_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cash_Fees_radioButton.AutoSize = true;
            this.Cash_Fees_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cash_Fees_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Cash_Fees_radioButton.Location = new System.Drawing.Point(6, 106);
            this.Cash_Fees_radioButton.Name = "Cash_Fees_radioButton";
            this.Cash_Fees_radioButton.Size = new System.Drawing.Size(73, 26);
            this.Cash_Fees_radioButton.TabIndex = 4;
            this.Cash_Fees_radioButton.TabStop = true;
            this.Cash_Fees_radioButton.Text = "Cash";
            this.Cash_Fees_radioButton.UseVisualStyleBackColor = true;
            this.Cash_Fees_radioButton.CheckedChanged += new System.EventHandler(this.Cash_Fees_radioButton_CheckedChanged);
            // 
            // Fees_Transfer_radioButton
            // 
            this.Fees_Transfer_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fees_Transfer_radioButton.AutoSize = true;
            this.Fees_Transfer_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fees_Transfer_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Fees_Transfer_radioButton.Location = new System.Drawing.Point(112, 106);
            this.Fees_Transfer_radioButton.Name = "Fees_Transfer_radioButton";
            this.Fees_Transfer_radioButton.Size = new System.Drawing.Size(104, 26);
            this.Fees_Transfer_radioButton.TabIndex = 5;
            this.Fees_Transfer_radioButton.TabStop = true;
            this.Fees_Transfer_radioButton.Text = "Transfer";
            this.Fees_Transfer_radioButton.UseVisualStyleBackColor = true;
            this.Fees_Transfer_radioButton.CheckedChanged += new System.EventHandler(this.Fees_Transfer_radioButton_CheckedChanged);
            // 
            // Transfer_Rate_lbl
            // 
            this.Transfer_Rate_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transfer_Rate_lbl.AutoSize = true;
            this.Transfer_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Transfer_Rate_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transfer_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Transfer_Rate_lbl.Location = new System.Drawing.Point(168, 609);
            this.Transfer_Rate_lbl.Name = "Transfer_Rate_lbl";
            this.Transfer_Rate_lbl.Size = new System.Drawing.Size(171, 28);
            this.Transfer_Rate_lbl.TabIndex = 94;
            this.Transfer_Rate_lbl.Text = "Transfer Rate";
            this.Transfer_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bank_Rate_lbl
            // 
            this.Bank_Rate_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bank_Rate_lbl.AutoSize = true;
            this.Bank_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bank_Rate_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bank_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Bank_Rate_lbl.Location = new System.Drawing.Point(339, 609);
            this.Bank_Rate_lbl.Name = "Bank_Rate_lbl";
            this.Bank_Rate_lbl.Size = new System.Drawing.Size(130, 28);
            this.Bank_Rate_lbl.TabIndex = 93;
            this.Bank_Rate_lbl.Text = "Bank Rate";
            this.Bank_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Other_Rate_lbl
            // 
            this.Other_Rate_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Other_Rate_lbl.AutoSize = true;
            this.Other_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Other_Rate_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Other_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Other_Rate_lbl.Location = new System.Drawing.Point(469, 609);
            this.Other_Rate_lbl.Name = "Other_Rate_lbl";
            this.Other_Rate_lbl.Size = new System.Drawing.Size(137, 28);
            this.Other_Rate_lbl.TabIndex = 92;
            this.Other_Rate_lbl.Text = "Other Rate";
            this.Other_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Payment_Date_dateTimePicker
            // 
            this.Payment_Date_dateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.Payment_Date_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Payment_Date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Payment_Date_dateTimePicker.Location = new System.Drawing.Point(664, 467);
            this.Payment_Date_dateTimePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.Payment_Date_dateTimePicker.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.Payment_Date_dateTimePicker.Name = "Payment_Date_dateTimePicker";
            this.Payment_Date_dateTimePicker.Size = new System.Drawing.Size(324, 29);
            this.Payment_Date_dateTimePicker.TabIndex = 97;
            this.Payment_Date_dateTimePicker.Value = new System.DateTime(2020, 4, 30, 0, 0, 0, 0);
            // 
            // Transport_Date_lbl
            // 
            this.Transport_Date_lbl.AutoSize = true;
            this.Transport_Date_lbl.Location = new System.Drawing.Point(542, 472);
            this.Transport_Date_lbl.Name = "Transport_Date_lbl";
            this.Transport_Date_lbl.Size = new System.Drawing.Size(64, 22);
            this.Transport_Date_lbl.TabIndex = 96;
            this.Transport_Date_lbl.Text = "Date :";
            // 
            // Transport_Fees_groupBox
            // 
            this.Transport_Fees_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Transport_Fees_groupBox.Controls.Add(this.Transport_Balance_txt);
            this.Transport_Fees_groupBox.Controls.Add(this.Transport_Balance_lbl);
            this.Transport_Fees_groupBox.Controls.Add(this.Transport_Fees_txt);
            this.Transport_Fees_groupBox.Controls.Add(this.Transport_Other_radioButton);
            this.Transport_Fees_groupBox.Controls.Add(this.Transport_Bank_radioButton);
            this.Transport_Fees_groupBox.Controls.Add(this.Cash_Transport_radioButton);
            this.Transport_Fees_groupBox.Controls.Add(this.Transport_Transfer_radioButton);
            this.Transport_Fees_groupBox.ForeColor = System.Drawing.Color.Black;
            this.Transport_Fees_groupBox.Location = new System.Drawing.Point(545, 157);
            this.Transport_Fees_groupBox.Name = "Transport_Fees_groupBox";
            this.Transport_Fees_groupBox.Size = new System.Drawing.Size(442, 290);
            this.Transport_Fees_groupBox.TabIndex = 98;
            this.Transport_Fees_groupBox.TabStop = false;
            this.Transport_Fees_groupBox.Text = "Transport Fees";
            // 
            // Transport_Balance_txt
            // 
            this.Transport_Balance_txt.AutoSize = true;
            this.Transport_Balance_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Transport_Balance_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Transport_Balance_txt.DecimalPlaces = 2;
            this.Transport_Balance_txt.ForeColor = System.Drawing.Color.Red;
            this.Transport_Balance_txt.Location = new System.Drawing.Point(225, 40);
            this.Transport_Balance_txt.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Transport_Balance_txt.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.Transport_Balance_txt.Name = "Transport_Balance_txt";
            this.Transport_Balance_txt.ReadOnly = true;
            this.Transport_Balance_txt.Size = new System.Drawing.Size(204, 25);
            this.Transport_Balance_txt.TabIndex = 88;
            this.Transport_Balance_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Transport_Balance_txt.ThousandsSeparator = true;
            // 
            // Transport_Balance_lbl
            // 
            this.Transport_Balance_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Transport_Balance_lbl.AutoSize = true;
            this.Transport_Balance_lbl.ForeColor = System.Drawing.Color.Red;
            this.Transport_Balance_lbl.Location = new System.Drawing.Point(21, 43);
            this.Transport_Balance_lbl.Name = "Transport_Balance_lbl";
            this.Transport_Balance_lbl.Size = new System.Drawing.Size(190, 22);
            this.Transport_Balance_lbl.TabIndex = 87;
            this.Transport_Balance_lbl.Text = "Transport Balance :";
            // 
            // Transport_Fees_txt
            // 
            this.Transport_Fees_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transport_Fees_txt.DecimalPlaces = 2;
            this.Transport_Fees_txt.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transport_Fees_txt.ForeColor = System.Drawing.Color.Blue;
            this.Transport_Fees_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Transport_Fees_txt.Location = new System.Drawing.Point(6, 176);
            this.Transport_Fees_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Transport_Fees_txt.Name = "Transport_Fees_txt";
            this.Transport_Fees_txt.Size = new System.Drawing.Size(430, 60);
            this.Transport_Fees_txt.TabIndex = 8;
            this.Transport_Fees_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Transport_Fees_txt.ThousandsSeparator = true;
            // 
            // Transport_Other_radioButton
            // 
            this.Transport_Other_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transport_Other_radioButton.AutoSize = true;
            this.Transport_Other_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Transport_Other_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Transport_Other_radioButton.Location = new System.Drawing.Point(356, 106);
            this.Transport_Other_radioButton.Name = "Transport_Other_radioButton";
            this.Transport_Other_radioButton.Size = new System.Drawing.Size(79, 26);
            this.Transport_Other_radioButton.TabIndex = 7;
            this.Transport_Other_radioButton.TabStop = true;
            this.Transport_Other_radioButton.Text = "Other";
            this.Transport_Other_radioButton.UseVisualStyleBackColor = true;
            this.Transport_Other_radioButton.CheckedChanged += new System.EventHandler(this.Transport_Other_radioButton_CheckedChanged);
            // 
            // Transport_Bank_radioButton
            // 
            this.Transport_Bank_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transport_Bank_radioButton.AutoSize = true;
            this.Transport_Bank_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Transport_Bank_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Transport_Bank_radioButton.Location = new System.Drawing.Point(249, 106);
            this.Transport_Bank_radioButton.Name = "Transport_Bank_radioButton";
            this.Transport_Bank_radioButton.Size = new System.Drawing.Size(74, 26);
            this.Transport_Bank_radioButton.TabIndex = 6;
            this.Transport_Bank_radioButton.TabStop = true;
            this.Transport_Bank_radioButton.Text = "Bank";
            this.Transport_Bank_radioButton.UseVisualStyleBackColor = true;
            this.Transport_Bank_radioButton.CheckedChanged += new System.EventHandler(this.Transport_Bank_radioButton_CheckedChanged);
            // 
            // Cash_Transport_radioButton
            // 
            this.Cash_Transport_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cash_Transport_radioButton.AutoSize = true;
            this.Cash_Transport_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cash_Transport_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Cash_Transport_radioButton.Location = new System.Drawing.Point(6, 106);
            this.Cash_Transport_radioButton.Name = "Cash_Transport_radioButton";
            this.Cash_Transport_radioButton.Size = new System.Drawing.Size(73, 26);
            this.Cash_Transport_radioButton.TabIndex = 4;
            this.Cash_Transport_radioButton.TabStop = true;
            this.Cash_Transport_radioButton.Text = "Cash";
            this.Cash_Transport_radioButton.UseVisualStyleBackColor = true;
            this.Cash_Transport_radioButton.CheckedChanged += new System.EventHandler(this.Cash_Transport_radioButton_CheckedChanged);
            // 
            // Transport_Transfer_radioButton
            // 
            this.Transport_Transfer_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transport_Transfer_radioButton.AutoSize = true;
            this.Transport_Transfer_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Transport_Transfer_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Transport_Transfer_radioButton.Location = new System.Drawing.Point(112, 106);
            this.Transport_Transfer_radioButton.Name = "Transport_Transfer_radioButton";
            this.Transport_Transfer_radioButton.Size = new System.Drawing.Size(104, 26);
            this.Transport_Transfer_radioButton.TabIndex = 5;
            this.Transport_Transfer_radioButton.TabStop = true;
            this.Transport_Transfer_radioButton.Text = "Transfer";
            this.Transport_Transfer_radioButton.UseVisualStyleBackColor = true;
            this.Transport_Transfer_radioButton.CheckedChanged += new System.EventHandler(this.Transport_Transfer_radioButton_CheckedChanged);
            // 
            // Uniform_Prices_groupBox
            // 
            this.Uniform_Prices_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Uniform_Prices_groupBox.Controls.Add(this.Uniform_Balance_txt);
            this.Uniform_Prices_groupBox.Controls.Add(this.Uniform_Balance_lbl);
            this.Uniform_Prices_groupBox.Controls.Add(this.Uniforms_Prices_txt);
            this.Uniform_Prices_groupBox.Controls.Add(this.Uniforms_Other_radioButton);
            this.Uniform_Prices_groupBox.Controls.Add(this.Uniforms_Bank_radioButton);
            this.Uniform_Prices_groupBox.Controls.Add(this.Cash_Uniforms_radioButton);
            this.Uniform_Prices_groupBox.Controls.Add(this.Uniforms_Transfer_radioButton);
            this.Uniform_Prices_groupBox.ForeColor = System.Drawing.Color.Black;
            this.Uniform_Prices_groupBox.Location = new System.Drawing.Point(1056, 157);
            this.Uniform_Prices_groupBox.Name = "Uniform_Prices_groupBox";
            this.Uniform_Prices_groupBox.Size = new System.Drawing.Size(442, 290);
            this.Uniform_Prices_groupBox.TabIndex = 99;
            this.Uniform_Prices_groupBox.TabStop = false;
            this.Uniform_Prices_groupBox.Text = "Uniform Prices";
            // 
            // Uniform_Balance_txt
            // 
            this.Uniform_Balance_txt.AutoSize = true;
            this.Uniform_Balance_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Uniform_Balance_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Uniform_Balance_txt.DecimalPlaces = 2;
            this.Uniform_Balance_txt.ForeColor = System.Drawing.Color.Red;
            this.Uniform_Balance_txt.Location = new System.Drawing.Point(229, 40);
            this.Uniform_Balance_txt.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Uniform_Balance_txt.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.Uniform_Balance_txt.Name = "Uniform_Balance_txt";
            this.Uniform_Balance_txt.ReadOnly = true;
            this.Uniform_Balance_txt.Size = new System.Drawing.Size(204, 25);
            this.Uniform_Balance_txt.TabIndex = 88;
            this.Uniform_Balance_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Uniform_Balance_txt.ThousandsSeparator = true;
            // 
            // Uniform_Balance_lbl
            // 
            this.Uniform_Balance_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Uniform_Balance_lbl.AutoSize = true;
            this.Uniform_Balance_lbl.ForeColor = System.Drawing.Color.Red;
            this.Uniform_Balance_lbl.Location = new System.Drawing.Point(14, 43);
            this.Uniform_Balance_lbl.Name = "Uniform_Balance_lbl";
            this.Uniform_Balance_lbl.Size = new System.Drawing.Size(172, 22);
            this.Uniform_Balance_lbl.TabIndex = 87;
            this.Uniform_Balance_lbl.Text = "Uniform Balance :";
            // 
            // Uniforms_Prices_txt
            // 
            this.Uniforms_Prices_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Uniforms_Prices_txt.DecimalPlaces = 2;
            this.Uniforms_Prices_txt.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uniforms_Prices_txt.ForeColor = System.Drawing.Color.Blue;
            this.Uniforms_Prices_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Uniforms_Prices_txt.Location = new System.Drawing.Point(6, 176);
            this.Uniforms_Prices_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Uniforms_Prices_txt.Name = "Uniforms_Prices_txt";
            this.Uniforms_Prices_txt.Size = new System.Drawing.Size(430, 60);
            this.Uniforms_Prices_txt.TabIndex = 8;
            this.Uniforms_Prices_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Uniforms_Prices_txt.ThousandsSeparator = true;
            // 
            // Uniforms_Other_radioButton
            // 
            this.Uniforms_Other_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Uniforms_Other_radioButton.AutoSize = true;
            this.Uniforms_Other_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Uniforms_Other_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Uniforms_Other_radioButton.Location = new System.Drawing.Point(356, 106);
            this.Uniforms_Other_radioButton.Name = "Uniforms_Other_radioButton";
            this.Uniforms_Other_radioButton.Size = new System.Drawing.Size(79, 26);
            this.Uniforms_Other_radioButton.TabIndex = 7;
            this.Uniforms_Other_radioButton.TabStop = true;
            this.Uniforms_Other_radioButton.Text = "Other";
            this.Uniforms_Other_radioButton.UseVisualStyleBackColor = true;
            this.Uniforms_Other_radioButton.CheckedChanged += new System.EventHandler(this.Uniforms_Other_radioButton_CheckedChanged);
            // 
            // Uniforms_Bank_radioButton
            // 
            this.Uniforms_Bank_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Uniforms_Bank_radioButton.AutoSize = true;
            this.Uniforms_Bank_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Uniforms_Bank_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Uniforms_Bank_radioButton.Location = new System.Drawing.Point(249, 106);
            this.Uniforms_Bank_radioButton.Name = "Uniforms_Bank_radioButton";
            this.Uniforms_Bank_radioButton.Size = new System.Drawing.Size(74, 26);
            this.Uniforms_Bank_radioButton.TabIndex = 6;
            this.Uniforms_Bank_radioButton.TabStop = true;
            this.Uniforms_Bank_radioButton.Text = "Bank";
            this.Uniforms_Bank_radioButton.UseVisualStyleBackColor = true;
            this.Uniforms_Bank_radioButton.CheckedChanged += new System.EventHandler(this.Uniforms_Bank_radioButton_CheckedChanged);
            // 
            // Cash_Uniforms_radioButton
            // 
            this.Cash_Uniforms_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cash_Uniforms_radioButton.AutoSize = true;
            this.Cash_Uniforms_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cash_Uniforms_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Cash_Uniforms_radioButton.Location = new System.Drawing.Point(6, 106);
            this.Cash_Uniforms_radioButton.Name = "Cash_Uniforms_radioButton";
            this.Cash_Uniforms_radioButton.Size = new System.Drawing.Size(73, 26);
            this.Cash_Uniforms_radioButton.TabIndex = 4;
            this.Cash_Uniforms_radioButton.TabStop = true;
            this.Cash_Uniforms_radioButton.Text = "Cash";
            this.Cash_Uniforms_radioButton.UseVisualStyleBackColor = true;
            this.Cash_Uniforms_radioButton.CheckedChanged += new System.EventHandler(this.Cash_Uniforms_radioButton_CheckedChanged);
            // 
            // Uniforms_Transfer_radioButton
            // 
            this.Uniforms_Transfer_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Uniforms_Transfer_radioButton.AutoSize = true;
            this.Uniforms_Transfer_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Uniforms_Transfer_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Uniforms_Transfer_radioButton.Location = new System.Drawing.Point(112, 106);
            this.Uniforms_Transfer_radioButton.Name = "Uniforms_Transfer_radioButton";
            this.Uniforms_Transfer_radioButton.Size = new System.Drawing.Size(104, 26);
            this.Uniforms_Transfer_radioButton.TabIndex = 5;
            this.Uniforms_Transfer_radioButton.TabStop = true;
            this.Uniforms_Transfer_radioButton.Text = "Transfer";
            this.Uniforms_Transfer_radioButton.UseVisualStyleBackColor = true;
            this.Uniforms_Transfer_radioButton.CheckedChanged += new System.EventHandler(this.Uniforms_Transfer_radioButton_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Surname_txt
            // 
            this.Surname_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname_txt.Location = new System.Drawing.Point(648, 43);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(339, 26);
            this.Surname_txt.TabIndex = 2;
            // 
            // Surname_lbl
            // 
            this.Surname_lbl.AutoSize = true;
            this.Surname_lbl.Location = new System.Drawing.Point(541, 45);
            this.Surname_lbl.Name = "Surname_lbl";
            this.Surname_lbl.Size = new System.Drawing.Size(103, 22);
            this.Surname_lbl.TabIndex = 101;
            this.Surname_lbl.Text = "Surname :";
            // 
            // REGISTERED_lbl
            // 
            this.REGISTERED_lbl.AutoSize = true;
            this.REGISTERED_lbl.Font = new System.Drawing.Font("Arial Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTERED_lbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.REGISTERED_lbl.Location = new System.Drawing.Point(639, 93);
            this.REGISTERED_lbl.Name = "REGISTERED_lbl";
            this.REGISTERED_lbl.Size = new System.Drawing.Size(244, 50);
            this.REGISTERED_lbl.TabIndex = 102;
            this.REGISTERED_lbl.Text = "Fully Paid !!";
            this.REGISTERED_lbl.Visible = false;
            // 
            // student_Registration_Record_tblTableAdapter
            // 
            this.student_Registration_Record_tblTableAdapter.ClearBeforeFill = true;
            // 
            // fees_Managment_tblTableAdapter
            // 
            this.fees_Managment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Student_Fees_Uniforms_n_Transport_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1529, 660);
            this.Controls.Add(this.REGISTERED_lbl);
            this.Controls.Add(this.Surname_txt);
            this.Controls.Add(this.Surname_lbl);
            this.Controls.Add(this.Uniform_Prices_groupBox);
            this.Controls.Add(this.Transport_Fees_groupBox);
            this.Controls.Add(this.Payment_Date_dateTimePicker);
            this.Controls.Add(this.Transport_Date_lbl);
            this.Controls.Add(this.Transfer_Rate_lbl);
            this.Controls.Add(this.Bank_Rate_lbl);
            this.Controls.Add(this.Other_Rate_lbl);
            this.Controls.Add(this.School_Fees_groupBox);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Student_Name_txt);
            this.Controls.Add(this.Student_Name_lbl);
            this.Controls.Add(this.School_Term_txt);
            this.Controls.Add(this.School_Term_lbl);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Student_Fees_Uniforms_n_Transport_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Fees, Uniforms n Transport Payments Form";
            this.Load += new System.EventHandler(this.Student_Fees_Uniforms_n_Transport_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feesManagmenttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource)).EndInit();
            this.School_Fees_groupBox.ResumeLayout(false);
            this.School_Fees_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fees_Balance_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.School_Fees_txt)).EndInit();
            this.Transport_Fees_groupBox.ResumeLayout(false);
            this.Transport_Fees_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transport_Balance_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transport_Fees_txt)).EndInit();
            this.Uniform_Prices_groupBox.ResumeLayout(false);
            this.Uniform_Prices_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Uniform_Balance_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uniforms_Prices_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox School_Term_txt;
        private System.Windows.Forms.Label School_Term_lbl;
        private System.Windows.Forms.Label Student_Name_lbl;
        private System.Windows.Forms.ComboBox Student_Name_txt;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label User_txt;
        private System.Windows.Forms.GroupBox School_Fees_groupBox;
        private System.Windows.Forms.NumericUpDown School_Fees_txt;
        private System.Windows.Forms.RadioButton Fees_Other_radioButton;
        private System.Windows.Forms.RadioButton Fees_Bank_radioButton;
        private System.Windows.Forms.RadioButton Cash_Fees_radioButton;
        private System.Windows.Forms.RadioButton Fees_Transfer_radioButton;
        private System.Windows.Forms.Label Transfer_Rate_lbl;
        private System.Windows.Forms.Label Bank_Rate_lbl;
        private System.Windows.Forms.Label Other_Rate_lbl;
        private System.Windows.Forms.DateTimePicker Payment_Date_dateTimePicker;
        private System.Windows.Forms.Label Transport_Date_lbl;
        private System.Windows.Forms.GroupBox Transport_Fees_groupBox;
        private System.Windows.Forms.NumericUpDown Transport_Fees_txt;
        private System.Windows.Forms.RadioButton Transport_Other_radioButton;
        private System.Windows.Forms.RadioButton Transport_Bank_radioButton;
        private System.Windows.Forms.RadioButton Cash_Transport_radioButton;
        private System.Windows.Forms.RadioButton Transport_Transfer_radioButton;
        private System.Windows.Forms.GroupBox Uniform_Prices_groupBox;
        private System.Windows.Forms.NumericUpDown Uniforms_Prices_txt;
        private System.Windows.Forms.RadioButton Uniforms_Other_radioButton;
        private System.Windows.Forms.RadioButton Uniforms_Bank_radioButton;
        private System.Windows.Forms.RadioButton Cash_Uniforms_radioButton;
        private System.Windows.Forms.RadioButton Uniforms_Transfer_radioButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown Fees_Balance_txt;
        private System.Windows.Forms.Label Fees_Balance_lbl;
        private System.Windows.Forms.NumericUpDown Transport_Balance_txt;
        private System.Windows.Forms.Label Transport_Balance_lbl;
        private System.Windows.Forms.NumericUpDown Uniform_Balance_txt;
        private System.Windows.Forms.Label Uniform_Balance_lbl;
        private System.Windows.Forms.TextBox Surname_txt;
        private System.Windows.Forms.Label Surname_lbl;
        private System.Windows.Forms.Label REGISTERED_lbl;
        private System.Windows.Forms.BindingSource systemDatabaseDataSetBindingSource;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource studentRegistrationRecordtblBindingSource;
        private System_DatabaseDataSetTableAdapters.Student_Registration_Record_tblTableAdapter student_Registration_Record_tblTableAdapter;
        private System.Windows.Forms.BindingSource studentRegistrationRecordtblBindingSource1;
        private System.Windows.Forms.BindingSource feesManagmenttblBindingSource;
        private System_DatabaseDataSetTableAdapters.Fees_Managment_tblTableAdapter fees_Managment_tblTableAdapter;
    }
}