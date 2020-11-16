namespace Pre_School_Managment_System
{
    partial class Activity_Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity_Registration_Form));
            this.Save_btn = new System.Windows.Forms.Button();
            this.Student_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Cash_radioButton = new System.Windows.Forms.RadioButton();
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.Surname_lbl = new System.Windows.Forms.Label();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.Activity_Name_lbl = new System.Windows.Forms.Label();
            this.Student_Name_txt = new System.Windows.Forms.ComboBox();
            this.studentRegistrationRecordtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.Transfer_radioButton = new System.Windows.Forms.RadioButton();
            this.Bank_radioButton = new System.Windows.Forms.RadioButton();
            this.Accept_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Activity_Name_txt = new System.Windows.Forms.ComboBox();
            this.activityManagmenttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Student_Name_lbl = new System.Windows.Forms.Label();
            this.User_txt = new System.Windows.Forms.Label();
            this.School_Term_txt = new System.Windows.Forms.ComboBox();
            this.feesManagmenttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.School_Term_lbl = new System.Windows.Forms.Label();
            this.Activity_Balance_lbl = new System.Windows.Forms.Label();
            this.Other_radioButton = new System.Windows.Forms.RadioButton();
            this.Activity_Fees_groupBox = new System.Windows.Forms.GroupBox();
            this.Exchange_Rates_lbl = new System.Windows.Forms.Label();
            this.Transfer_Rate_lbl = new System.Windows.Forms.Label();
            this.Bank_Rate_lbl = new System.Windows.Forms.Label();
            this.Activity_Fee_txt = new System.Windows.Forms.NumericUpDown();
            this.Other_Rate_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Activity_Balance_txt = new System.Windows.Forms.NumericUpDown();
            this.REGISTERED_lbl = new System.Windows.Forms.Label();
            this.student_Registration_Record_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Student_Registration_Record_tblTableAdapter();
            this.activity_Managment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Activity_Managment_tblTableAdapter();
            this.fees_Managment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Fees_Managment_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityManagmenttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesManagmenttblBindingSource)).BeginInit();
            this.Activity_Fees_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Activity_Fee_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Activity_Balance_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Save_btn.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(644, 570);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(193, 73);
            this.Save_btn.TabIndex = 12;
            this.Save_btn.Text = "&SAVE";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Student_dateTimePicker
            // 
            this.Student_dateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.Student_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Student_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Student_dateTimePicker.Location = new System.Drawing.Point(314, 460);
            this.Student_dateTimePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.Student_dateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.Student_dateTimePicker.Name = "Student_dateTimePicker";
            this.Student_dateTimePicker.Size = new System.Drawing.Size(377, 29);
            this.Student_dateTimePicker.TabIndex = 5;
            this.Student_dateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // Cash_radioButton
            // 
            this.Cash_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cash_radioButton.AutoSize = true;
            this.Cash_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cash_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Cash_radioButton.Location = new System.Drawing.Point(81, 110);
            this.Cash_radioButton.Name = "Cash_radioButton";
            this.Cash_radioButton.Size = new System.Drawing.Size(73, 26);
            this.Cash_radioButton.TabIndex = 6;
            this.Cash_radioButton.TabStop = true;
            this.Cash_radioButton.Text = "Cash";
            this.Cash_radioButton.UseVisualStyleBackColor = true;
            this.Cash_radioButton.CheckedChanged += new System.EventHandler(this.Cash_radioButton_CheckedChanged);
            // 
            // Surname_txt
            // 
            this.Surname_txt.Enabled = false;
            this.Surname_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname_txt.Location = new System.Drawing.Point(314, 200);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(377, 26);
            this.Surname_txt.TabIndex = 2;
            // 
            // Surname_lbl
            // 
            this.Surname_lbl.AutoSize = true;
            this.Surname_lbl.Location = new System.Drawing.Point(138, 202);
            this.Surname_lbl.Name = "Surname_lbl";
            this.Surname_lbl.Size = new System.Drawing.Size(103, 22);
            this.Surname_lbl.TabIndex = 31;
            this.Surname_lbl.Text = "Surname :";
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Location = new System.Drawing.Point(177, 463);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(64, 22);
            this.Date_lbl.TabIndex = 29;
            this.Date_lbl.Text = "Date :";
            // 
            // Activity_Name_lbl
            // 
            this.Activity_Name_lbl.AutoSize = true;
            this.Activity_Name_lbl.Location = new System.Drawing.Point(93, 289);
            this.Activity_Name_lbl.Name = "Activity_Name_lbl";
            this.Activity_Name_lbl.Size = new System.Drawing.Size(148, 22);
            this.Activity_Name_lbl.TabIndex = 26;
            this.Activity_Name_lbl.Text = "Activity Name :";
            // 
            // Student_Name_txt
            // 
            this.Student_Name_txt.DataSource = this.studentRegistrationRecordtblBindingSource;
            this.Student_Name_txt.DisplayMember = "First_Name";
            this.Student_Name_txt.FormattingEnabled = true;
            this.Student_Name_txt.Location = new System.Drawing.Point(314, 112);
            this.Student_Name_txt.Name = "Student_Name_txt";
            this.Student_Name_txt.Size = new System.Drawing.Size(377, 30);
            this.Student_Name_txt.TabIndex = 1;
            this.Student_Name_txt.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // studentRegistrationRecordtblBindingSource
            // 
            this.studentRegistrationRecordtblBindingSource.DataMember = "Student_Registration_Record_tbl";
            this.studentRegistrationRecordtblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // system_DatabaseDataSet
            // 
            this.system_DatabaseDataSet.DataSetName = "System_DatabaseDataSet";
            this.system_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Transfer_radioButton
            // 
            this.Transfer_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transfer_radioButton.AutoSize = true;
            this.Transfer_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Transfer_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Transfer_radioButton.Location = new System.Drawing.Point(224, 110);
            this.Transfer_radioButton.Name = "Transfer_radioButton";
            this.Transfer_radioButton.Size = new System.Drawing.Size(104, 26);
            this.Transfer_radioButton.TabIndex = 7;
            this.Transfer_radioButton.TabStop = true;
            this.Transfer_radioButton.Text = "Transfer";
            this.Transfer_radioButton.UseVisualStyleBackColor = true;
            this.Transfer_radioButton.CheckedChanged += new System.EventHandler(this.Transfer_radioButton_CheckedChanged);
            // 
            // Bank_radioButton
            // 
            this.Bank_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bank_radioButton.AutoSize = true;
            this.Bank_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bank_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Bank_radioButton.Location = new System.Drawing.Point(395, 110);
            this.Bank_radioButton.Name = "Bank_radioButton";
            this.Bank_radioButton.Size = new System.Drawing.Size(74, 26);
            this.Bank_radioButton.TabIndex = 8;
            this.Bank_radioButton.TabStop = true;
            this.Bank_radioButton.Text = "Bank";
            this.Bank_radioButton.UseVisualStyleBackColor = true;
            this.Bank_radioButton.CheckedChanged += new System.EventHandler(this.Bank_radioButton_CheckedChanged);
            // 
            // Accept_checkBox
            // 
            this.Accept_checkBox.AutoSize = true;
            this.Accept_checkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Accept_checkBox.Location = new System.Drawing.Point(1055, 463);
            this.Accept_checkBox.Name = "Accept_checkBox";
            this.Accept_checkBox.Size = new System.Drawing.Size(95, 26);
            this.Accept_checkBox.TabIndex = 11;
            this.Accept_checkBox.Text = "&Accept";
            this.Accept_checkBox.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(821, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Terms n Conditions :";
            // 
            // Activity_Name_txt
            // 
            this.Activity_Name_txt.DataSource = this.activityManagmenttblBindingSource;
            this.Activity_Name_txt.DisplayMember = "Activity_Name";
            this.Activity_Name_txt.FormattingEnabled = true;
            this.Activity_Name_txt.Location = new System.Drawing.Point(314, 284);
            this.Activity_Name_txt.Name = "Activity_Name_txt";
            this.Activity_Name_txt.Size = new System.Drawing.Size(377, 30);
            this.Activity_Name_txt.TabIndex = 3;
            this.Activity_Name_txt.SelectedIndexChanged += new System.EventHandler(this.Activity_Name_txt_SelectedIndexChanged);
            // 
            // activityManagmenttblBindingSource
            // 
            this.activityManagmenttblBindingSource.DataMember = "Activity_Managment_tbl";
            this.activityManagmenttblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // Student_Name_lbl
            // 
            this.Student_Name_lbl.AutoSize = true;
            this.Student_Name_lbl.Location = new System.Drawing.Point(93, 115);
            this.Student_Name_lbl.Name = "Student_Name_lbl";
            this.Student_Name_lbl.Size = new System.Drawing.Size(151, 22);
            this.Student_Name_lbl.TabIndex = 55;
            this.Student_Name_lbl.Text = "Student Name :";
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(4, 6);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(53, 22);
            this.User_txt.TabIndex = 59;
            this.User_txt.Text = "User";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // School_Term_txt
            // 
            this.School_Term_txt.DataSource = this.feesManagmenttblBindingSource;
            this.School_Term_txt.DisplayMember = "School_Term";
            this.School_Term_txt.FormattingEnabled = true;
            this.School_Term_txt.Location = new System.Drawing.Point(314, 372);
            this.School_Term_txt.Name = "School_Term_txt";
            this.School_Term_txt.Size = new System.Drawing.Size(377, 30);
            this.School_Term_txt.TabIndex = 4;
            this.School_Term_txt.SelectedIndexChanged += new System.EventHandler(this.School_Term_txt_SelectedIndexChanged);
            // 
            // feesManagmenttblBindingSource
            // 
            this.feesManagmenttblBindingSource.DataMember = "Fees_Managment_tbl";
            this.feesManagmenttblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // School_Term_lbl
            // 
            this.School_Term_lbl.AutoSize = true;
            this.School_Term_lbl.Location = new System.Drawing.Point(105, 376);
            this.School_Term_lbl.Name = "School_Term_lbl";
            this.School_Term_lbl.Size = new System.Drawing.Size(136, 22);
            this.School_Term_lbl.TabIndex = 76;
            this.School_Term_lbl.Text = "School Term :";
            // 
            // Activity_Balance_lbl
            // 
            this.Activity_Balance_lbl.AutoSize = true;
            this.Activity_Balance_lbl.Location = new System.Drawing.Point(809, 39);
            this.Activity_Balance_lbl.Name = "Activity_Balance_lbl";
            this.Activity_Balance_lbl.Size = new System.Drawing.Size(169, 22);
            this.Activity_Balance_lbl.TabIndex = 83;
            this.Activity_Balance_lbl.Text = "Activity Balance :";
            // 
            // Other_radioButton
            // 
            this.Other_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Other_radioButton.AutoSize = true;
            this.Other_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Other_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Other_radioButton.Location = new System.Drawing.Point(536, 110);
            this.Other_radioButton.Name = "Other_radioButton";
            this.Other_radioButton.Size = new System.Drawing.Size(79, 26);
            this.Other_radioButton.TabIndex = 9;
            this.Other_radioButton.TabStop = true;
            this.Other_radioButton.Text = "Other";
            this.Other_radioButton.UseVisualStyleBackColor = true;
            this.Other_radioButton.CheckedChanged += new System.EventHandler(this.Other_radioButton1_CheckedChanged);
            // 
            // Activity_Fees_groupBox
            // 
            this.Activity_Fees_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Activity_Fees_groupBox.Controls.Add(this.Exchange_Rates_lbl);
            this.Activity_Fees_groupBox.Controls.Add(this.Transfer_Rate_lbl);
            this.Activity_Fees_groupBox.Controls.Add(this.Bank_Rate_lbl);
            this.Activity_Fees_groupBox.Controls.Add(this.Activity_Fee_txt);
            this.Activity_Fees_groupBox.Controls.Add(this.Other_Rate_lbl);
            this.Activity_Fees_groupBox.Controls.Add(this.Other_radioButton);
            this.Activity_Fees_groupBox.Controls.Add(this.Bank_radioButton);
            this.Activity_Fees_groupBox.Controls.Add(this.Cash_radioButton);
            this.Activity_Fees_groupBox.Controls.Add(this.Transfer_radioButton);
            this.Activity_Fees_groupBox.ForeColor = System.Drawing.Color.Black;
            this.Activity_Fees_groupBox.Location = new System.Drawing.Point(813, 112);
            this.Activity_Fees_groupBox.Name = "Activity_Fees_groupBox";
            this.Activity_Fees_groupBox.Size = new System.Drawing.Size(651, 290);
            this.Activity_Fees_groupBox.TabIndex = 85;
            this.Activity_Fees_groupBox.TabStop = false;
            this.Activity_Fees_groupBox.Text = "Activity Fees";
            // 
            // Exchange_Rates_lbl
            // 
            this.Exchange_Rates_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exchange_Rates_lbl.AutoSize = true;
            this.Exchange_Rates_lbl.Location = new System.Drawing.Point(8, 48);
            this.Exchange_Rates_lbl.Name = "Exchange_Rates_lbl";
            this.Exchange_Rates_lbl.Size = new System.Drawing.Size(169, 22);
            this.Exchange_Rates_lbl.TabIndex = 89;
            this.Exchange_Rates_lbl.Text = "Exchange Rates :";
            // 
            // Transfer_Rate_lbl
            // 
            this.Transfer_Rate_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transfer_Rate_lbl.AutoSize = true;
            this.Transfer_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Transfer_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Transfer_Rate_lbl.Location = new System.Drawing.Point(206, 48);
            this.Transfer_Rate_lbl.Name = "Transfer_Rate_lbl";
            this.Transfer_Rate_lbl.Size = new System.Drawing.Size(135, 22);
            this.Transfer_Rate_lbl.TabIndex = 88;
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
            this.Bank_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Bank_Rate_lbl.Location = new System.Drawing.Point(363, 48);
            this.Bank_Rate_lbl.Name = "Bank_Rate_lbl";
            this.Bank_Rate_lbl.Size = new System.Drawing.Size(105, 22);
            this.Bank_Rate_lbl.TabIndex = 87;
            this.Bank_Rate_lbl.Text = "Bank Rate";
            this.Bank_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Activity_Fee_txt
            // 
            this.Activity_Fee_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Activity_Fee_txt.DecimalPlaces = 2;
            this.Activity_Fee_txt.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_Fee_txt.ForeColor = System.Drawing.Color.Blue;
            this.Activity_Fee_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Activity_Fee_txt.Location = new System.Drawing.Point(6, 176);
            this.Activity_Fee_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Activity_Fee_txt.Name = "Activity_Fee_txt";
            this.Activity_Fee_txt.Size = new System.Drawing.Size(639, 60);
            this.Activity_Fee_txt.TabIndex = 7;
            this.Activity_Fee_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Activity_Fee_txt.ThousandsSeparator = true;
            // 
            // Other_Rate_lbl
            // 
            this.Other_Rate_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Other_Rate_lbl.AutoSize = true;
            this.Other_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Other_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Other_Rate_lbl.Location = new System.Drawing.Point(505, 48);
            this.Other_Rate_lbl.Name = "Other_Rate_lbl";
            this.Other_Rate_lbl.Size = new System.Drawing.Size(110, 22);
            this.Other_Rate_lbl.TabIndex = 86;
            this.Other_Rate_lbl.Text = "Other Rate";
            this.Other_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Activity_Balance_txt
            // 
            this.Activity_Balance_txt.AutoSize = true;
            this.Activity_Balance_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Activity_Balance_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Activity_Balance_txt.DecimalPlaces = 2;
            this.Activity_Balance_txt.Location = new System.Drawing.Point(991, 36);
            this.Activity_Balance_txt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Activity_Balance_txt.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.Activity_Balance_txt.Name = "Activity_Balance_txt";
            this.Activity_Balance_txt.ReadOnly = true;
            this.Activity_Balance_txt.Size = new System.Drawing.Size(165, 25);
            this.Activity_Balance_txt.TabIndex = 86;
            this.Activity_Balance_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Activity_Balance_txt.ThousandsSeparator = true;
            // 
            // REGISTERED_lbl
            // 
            this.REGISTERED_lbl.AutoSize = true;
            this.REGISTERED_lbl.Font = new System.Drawing.Font("Arial Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTERED_lbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.REGISTERED_lbl.Location = new System.Drawing.Point(359, 39);
            this.REGISTERED_lbl.Name = "REGISTERED_lbl";
            this.REGISTERED_lbl.Size = new System.Drawing.Size(307, 50);
            this.REGISTERED_lbl.TabIndex = 87;
            this.REGISTERED_lbl.Text = "REGISTERED !!";
            this.REGISTERED_lbl.Visible = false;
            // 
            // student_Registration_Record_tblTableAdapter
            // 
            this.student_Registration_Record_tblTableAdapter.ClearBeforeFill = true;
            // 
            // activity_Managment_tblTableAdapter
            // 
            this.activity_Managment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // fees_Managment_tblTableAdapter
            // 
            this.fees_Managment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Activity_Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1531, 661);
            this.Controls.Add(this.REGISTERED_lbl);
            this.Controls.Add(this.Activity_Balance_txt);
            this.Controls.Add(this.Activity_Fees_groupBox);
            this.Controls.Add(this.Activity_Balance_lbl);
            this.Controls.Add(this.School_Term_txt);
            this.Controls.Add(this.School_Term_lbl);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Student_Name_lbl);
            this.Controls.Add(this.Activity_Name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Accept_checkBox);
            this.Controls.Add(this.Student_Name_txt);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Student_dateTimePicker);
            this.Controls.Add(this.Surname_txt);
            this.Controls.Add(this.Surname_lbl);
            this.Controls.Add(this.Date_lbl);
            this.Controls.Add(this.Activity_Name_lbl);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Activity_Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Activity Registration Form";
            this.Load += new System.EventHandler(this.Activity_Registration_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityManagmenttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesManagmenttblBindingSource)).EndInit();
            this.Activity_Fees_groupBox.ResumeLayout(false);
            this.Activity_Fees_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Activity_Fee_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Activity_Balance_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.DateTimePicker Student_dateTimePicker;
        private System.Windows.Forms.RadioButton Cash_radioButton;
        private System.Windows.Forms.TextBox Surname_txt;
        private System.Windows.Forms.Label Surname_lbl;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.Label Activity_Name_lbl;
        private System.Windows.Forms.ComboBox Student_Name_txt;
        private System.Windows.Forms.RadioButton Transfer_radioButton;
        private System.Windows.Forms.RadioButton Bank_radioButton;
        private System.Windows.Forms.CheckBox Accept_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Activity_Name_txt;
        private System.Windows.Forms.Label Student_Name_lbl;
        private System.Windows.Forms.Label User_txt;
        private System.Windows.Forms.ComboBox School_Term_txt;
        private System.Windows.Forms.Label School_Term_lbl;
        private System.Windows.Forms.Label Activity_Balance_lbl;
        private System.Windows.Forms.RadioButton Other_radioButton;
        private System.Windows.Forms.GroupBox Activity_Fees_groupBox;
        private System.Windows.Forms.NumericUpDown Activity_Fee_txt;
        private System.Windows.Forms.Label Other_Rate_lbl;
        private System.Windows.Forms.Label Bank_Rate_lbl;
        private System.Windows.Forms.Label Transfer_Rate_lbl;
        private System.Windows.Forms.Label Exchange_Rates_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown Activity_Balance_txt;
        private System.Windows.Forms.Label REGISTERED_lbl;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource studentRegistrationRecordtblBindingSource;
        private System_DatabaseDataSetTableAdapters.Student_Registration_Record_tblTableAdapter student_Registration_Record_tblTableAdapter;
        private System.Windows.Forms.BindingSource activityManagmenttblBindingSource;
        private System_DatabaseDataSetTableAdapters.Activity_Managment_tblTableAdapter activity_Managment_tblTableAdapter;
        private System.Windows.Forms.BindingSource feesManagmenttblBindingSource;
        private System_DatabaseDataSetTableAdapters.Fees_Managment_tblTableAdapter fees_Managment_tblTableAdapter;
    }
}