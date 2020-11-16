namespace Pre_School_Managment_System
{
    partial class Activity_Cost_Managment_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity_Cost_Managment_Form));
            this.Activity_Name_lbl = new System.Windows.Forms.Label();
            this.Activity_Name_txt = new System.Windows.Forms.ComboBox();
            this.activityManagmenttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.Activity_Profit_txt = new System.Windows.Forms.Label();
            this.Activity_Profit_lbl = new System.Windows.Forms.Label();
            this.Total_Expenses_txt = new System.Windows.Forms.NumericUpDown();
            this.Total_Received_txt = new System.Windows.Forms.NumericUpDown();
            this.Other_radioButton = new System.Windows.Forms.RadioButton();
            this.Bank_radioButton = new System.Windows.Forms.RadioButton();
            this.Cash_radioButton = new System.Windows.Forms.RadioButton();
            this.Transfer_radioButton = new System.Windows.Forms.RadioButton();
            this.Add_Expense_btn = new System.Windows.Forms.Button();
            this.Transport_Date_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Expense_Amount_txt = new System.Windows.Forms.NumericUpDown();
            this.Total_Expenses_lbl = new System.Windows.Forms.Label();
            this.Equals_lbl = new System.Windows.Forms.Label();
            this.Figure_lbl = new System.Windows.Forms.Label();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.Total_Received_lbl = new System.Windows.Forms.Label();
            this.Expense_Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Expenses_groupBox = new System.Windows.Forms.GroupBox();
            this.Expense_Description_txt = new System.Windows.Forms.TextBox();
            this.Expense_Managment_dataGridView = new System.Windows.Forms.DataGridView();
            this.School_Term_txt = new System.Windows.Forms.ComboBox();
            this.School_Term_lbl = new System.Windows.Forms.Label();
            this.Transfer_Rate_lbl = new System.Windows.Forms.Label();
            this.Bank_Rate_lbl = new System.Windows.Forms.Label();
            this.Other_Rate_lbl = new System.Windows.Forms.Label();
            this.User_txt = new System.Windows.Forms.Label();
            this.activity_Managment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Activity_Managment_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.activityManagmenttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Expenses_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Received_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Amount_txt)).BeginInit();
            this.Expenses_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Managment_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Activity_Name_lbl
            // 
            this.Activity_Name_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Activity_Name_lbl.AutoSize = true;
            this.Activity_Name_lbl.Location = new System.Drawing.Point(16, 24);
            this.Activity_Name_lbl.Name = "Activity_Name_lbl";
            this.Activity_Name_lbl.Size = new System.Drawing.Size(148, 22);
            this.Activity_Name_lbl.TabIndex = 3;
            this.Activity_Name_lbl.Text = "Activity Name :";
            // 
            // Activity_Name_txt
            // 
            this.Activity_Name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Activity_Name_txt.DataSource = this.activityManagmenttblBindingSource;
            this.Activity_Name_txt.DisplayMember = "Activity_Name";
            this.Activity_Name_txt.FormattingEnabled = true;
            this.Activity_Name_txt.Location = new System.Drawing.Point(192, 21);
            this.Activity_Name_txt.Name = "Activity_Name_txt";
            this.Activity_Name_txt.Size = new System.Drawing.Size(354, 30);
            this.Activity_Name_txt.TabIndex = 66;
            // 
            // activityManagmenttblBindingSource
            // 
            this.activityManagmenttblBindingSource.DataMember = "Activity_Managment_tbl";
            this.activityManagmenttblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // system_DatabaseDataSet
            // 
            this.system_DatabaseDataSet.DataSetName = "System_DatabaseDataSet";
            this.system_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Activity_Profit_txt
            // 
            this.Activity_Profit_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Activity_Profit_txt.AutoSize = true;
            this.Activity_Profit_txt.BackColor = System.Drawing.Color.Transparent;
            this.Activity_Profit_txt.Font = new System.Drawing.Font("Arial Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_Profit_txt.ForeColor = System.Drawing.Color.Green;
            this.Activity_Profit_txt.Location = new System.Drawing.Point(309, 413);
            this.Activity_Profit_txt.Name = "Activity_Profit_txt";
            this.Activity_Profit_txt.Size = new System.Drawing.Size(94, 45);
            this.Activity_Profit_txt.TabIndex = 97;
            this.Activity_Profit_txt.Text = "0.00";
            // 
            // Activity_Profit_lbl
            // 
            this.Activity_Profit_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Activity_Profit_lbl.AutoSize = true;
            this.Activity_Profit_lbl.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_Profit_lbl.ForeColor = System.Drawing.Color.Green;
            this.Activity_Profit_lbl.Location = new System.Drawing.Point(15, 413);
            this.Activity_Profit_lbl.Name = "Activity_Profit_lbl";
            this.Activity_Profit_lbl.Size = new System.Drawing.Size(306, 45);
            this.Activity_Profit_lbl.TabIndex = 96;
            this.Activity_Profit_lbl.Text = "Activity Profit: $";
            // 
            // Total_Expenses_txt
            // 
            this.Total_Expenses_txt.AutoSize = true;
            this.Total_Expenses_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Total_Expenses_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_Expenses_txt.DecimalPlaces = 2;
            this.Total_Expenses_txt.Enabled = false;
            this.Total_Expenses_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Expenses_txt.ForeColor = System.Drawing.Color.Red;
            this.Total_Expenses_txt.Location = new System.Drawing.Point(283, 327);
            this.Total_Expenses_txt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Total_Expenses_txt.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.Total_Expenses_txt.Name = "Total_Expenses_txt";
            this.Total_Expenses_txt.ReadOnly = true;
            this.Total_Expenses_txt.Size = new System.Drawing.Size(179, 28);
            this.Total_Expenses_txt.TabIndex = 95;
            this.Total_Expenses_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total_Expenses_txt.ThousandsSeparator = true;
            // 
            // Total_Received_txt
            // 
            this.Total_Received_txt.AutoSize = true;
            this.Total_Received_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Total_Received_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_Received_txt.DecimalPlaces = 2;
            this.Total_Received_txt.Enabled = false;
            this.Total_Received_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Received_txt.ForeColor = System.Drawing.Color.Black;
            this.Total_Received_txt.Location = new System.Drawing.Point(273, 24);
            this.Total_Received_txt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Total_Received_txt.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.Total_Received_txt.Name = "Total_Received_txt";
            this.Total_Received_txt.ReadOnly = true;
            this.Total_Received_txt.Size = new System.Drawing.Size(179, 28);
            this.Total_Received_txt.TabIndex = 94;
            this.Total_Received_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total_Received_txt.ThousandsSeparator = true;
            // 
            // Other_radioButton
            // 
            this.Other_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Other_radioButton.AutoSize = true;
            this.Other_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Other_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Other_radioButton.Location = new System.Drawing.Point(466, 84);
            this.Other_radioButton.Name = "Other_radioButton";
            this.Other_radioButton.Size = new System.Drawing.Size(71, 22);
            this.Other_radioButton.TabIndex = 5;
            this.Other_radioButton.TabStop = true;
            this.Other_radioButton.Text = "Other";
            this.Other_radioButton.UseVisualStyleBackColor = true;
            // 
            // Bank_radioButton
            // 
            this.Bank_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bank_radioButton.AutoSize = true;
            this.Bank_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bank_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Bank_radioButton.Location = new System.Drawing.Point(324, 84);
            this.Bank_radioButton.Name = "Bank_radioButton";
            this.Bank_radioButton.Size = new System.Drawing.Size(66, 22);
            this.Bank_radioButton.TabIndex = 4;
            this.Bank_radioButton.TabStop = true;
            this.Bank_radioButton.Text = "Bank";
            this.Bank_radioButton.UseVisualStyleBackColor = true;
            // 
            // Cash_radioButton
            // 
            this.Cash_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cash_radioButton.AutoSize = true;
            this.Cash_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cash_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Cash_radioButton.Location = new System.Drawing.Point(13, 84);
            this.Cash_radioButton.Name = "Cash_radioButton";
            this.Cash_radioButton.Size = new System.Drawing.Size(66, 22);
            this.Cash_radioButton.TabIndex = 2;
            this.Cash_radioButton.TabStop = true;
            this.Cash_radioButton.Text = "Cash";
            this.Cash_radioButton.UseVisualStyleBackColor = true;
            // 
            // Transfer_radioButton
            // 
            this.Transfer_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transfer_radioButton.AutoSize = true;
            this.Transfer_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Transfer_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.Transfer_radioButton.Location = new System.Drawing.Point(155, 84);
            this.Transfer_radioButton.Name = "Transfer_radioButton";
            this.Transfer_radioButton.Size = new System.Drawing.Size(93, 22);
            this.Transfer_radioButton.TabIndex = 3;
            this.Transfer_radioButton.TabStop = true;
            this.Transfer_radioButton.Text = "Transfer";
            this.Transfer_radioButton.UseVisualStyleBackColor = true;
            // 
            // Add_Expense_btn
            // 
            this.Add_Expense_btn.BackColor = System.Drawing.Color.Lime;
            this.Add_Expense_btn.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Expense_btn.Location = new System.Drawing.Point(170, 246);
            this.Add_Expense_btn.Name = "Add_Expense_btn";
            this.Add_Expense_btn.Size = new System.Drawing.Size(197, 47);
            this.Add_Expense_btn.TabIndex = 8;
            this.Add_Expense_btn.Text = "&Add Expense";
            this.Add_Expense_btn.UseVisualStyleBackColor = false;
            this.Add_Expense_btn.Click += new System.EventHandler(this.Add_Expense_btn_Click);
            // 
            // Transport_Date_lbl
            // 
            this.Transport_Date_lbl.AutoSize = true;
            this.Transport_Date_lbl.Location = new System.Drawing.Point(1149, 24);
            this.Transport_Date_lbl.Name = "Transport_Date_lbl";
            this.Transport_Date_lbl.Size = new System.Drawing.Size(64, 22);
            this.Transport_Date_lbl.TabIndex = 129;
            this.Transport_Date_lbl.Text = "Date :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(667, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 63);
            this.button1.TabIndex = 122;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Expense_Amount_txt
            // 
            this.Expense_Amount_txt.DecimalPlaces = 2;
            this.Expense_Amount_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Amount_txt.Location = new System.Drawing.Point(345, 180);
            this.Expense_Amount_txt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Expense_Amount_txt.Name = "Expense_Amount_txt";
            this.Expense_Amount_txt.Size = new System.Drawing.Size(193, 32);
            this.Expense_Amount_txt.TabIndex = 7;
            // 
            // Total_Expenses_lbl
            // 
            this.Total_Expenses_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_Expenses_lbl.AutoSize = true;
            this.Total_Expenses_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Expenses_lbl.ForeColor = System.Drawing.Color.Red;
            this.Total_Expenses_lbl.Location = new System.Drawing.Point(94, 326);
            this.Total_Expenses_lbl.Name = "Total_Expenses_lbl";
            this.Total_Expenses_lbl.Size = new System.Drawing.Size(192, 24);
            this.Total_Expenses_lbl.TabIndex = 69;
            this.Total_Expenses_lbl.Text = "Total Expenses : $";
            // 
            // Equals_lbl
            // 
            this.Equals_lbl.AutoSize = true;
            this.Equals_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Equals_lbl.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equals_lbl.Location = new System.Drawing.Point(319, 185);
            this.Equals_lbl.Name = "Equals_lbl";
            this.Equals_lbl.Size = new System.Drawing.Size(25, 27);
            this.Equals_lbl.TabIndex = 58;
            this.Equals_lbl.Text = "=";
            // 
            // Figure_lbl
            // 
            this.Figure_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Figure_lbl.AutoSize = true;
            this.Figure_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Figure_lbl.Location = new System.Drawing.Point(434, 136);
            this.Figure_lbl.Name = "Figure_lbl";
            this.Figure_lbl.Size = new System.Drawing.Size(21, 22);
            this.Figure_lbl.TabIndex = 8;
            this.Figure_lbl.Text = "$";
            // 
            // Description_lbl
            // 
            this.Description_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lbl.Location = new System.Drawing.Point(114, 136);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(105, 22);
            this.Description_lbl.TabIndex = 9;
            this.Description_lbl.Text = "Decription";
            // 
            // Total_Received_lbl
            // 
            this.Total_Received_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_Received_lbl.AutoSize = true;
            this.Total_Received_lbl.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Received_lbl.ForeColor = System.Drawing.Color.Black;
            this.Total_Received_lbl.Location = new System.Drawing.Point(76, 22);
            this.Total_Received_lbl.Name = "Total_Received_lbl";
            this.Total_Received_lbl.Size = new System.Drawing.Size(200, 27);
            this.Total_Received_lbl.TabIndex = 2;
            this.Total_Received_lbl.Text = "Total Received : $";
            // 
            // Expense_Date_dateTimePicker
            // 
            this.Expense_Date_dateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.Expense_Date_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Expense_Date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Expense_Date_dateTimePicker.Location = new System.Drawing.Point(1271, 19);
            this.Expense_Date_dateTimePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.Expense_Date_dateTimePicker.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.Expense_Date_dateTimePicker.Name = "Expense_Date_dateTimePicker";
            this.Expense_Date_dateTimePicker.Size = new System.Drawing.Size(227, 29);
            this.Expense_Date_dateTimePicker.TabIndex = 130;
            this.Expense_Date_dateTimePicker.Value = new System.DateTime(2019, 12, 21, 0, 0, 0, 0);
            // 
            // Expenses_groupBox
            // 
            this.Expenses_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Expenses_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Expenses_groupBox.Controls.Add(this.Activity_Profit_txt);
            this.Expenses_groupBox.Controls.Add(this.Activity_Profit_lbl);
            this.Expenses_groupBox.Controls.Add(this.Total_Expenses_txt);
            this.Expenses_groupBox.Controls.Add(this.Total_Received_txt);
            this.Expenses_groupBox.Controls.Add(this.Other_radioButton);
            this.Expenses_groupBox.Controls.Add(this.Bank_radioButton);
            this.Expenses_groupBox.Controls.Add(this.Cash_radioButton);
            this.Expenses_groupBox.Controls.Add(this.Transfer_radioButton);
            this.Expenses_groupBox.Controls.Add(this.Add_Expense_btn);
            this.Expenses_groupBox.Controls.Add(this.Expense_Amount_txt);
            this.Expenses_groupBox.Controls.Add(this.Total_Expenses_lbl);
            this.Expenses_groupBox.Controls.Add(this.Equals_lbl);
            this.Expenses_groupBox.Controls.Add(this.Expense_Description_txt);
            this.Expenses_groupBox.Controls.Add(this.Figure_lbl);
            this.Expenses_groupBox.Controls.Add(this.Description_lbl);
            this.Expenses_groupBox.Controls.Add(this.Total_Received_lbl);
            this.Expenses_groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_groupBox.Location = new System.Drawing.Point(2, 80);
            this.Expenses_groupBox.Name = "Expenses_groupBox";
            this.Expenses_groupBox.Size = new System.Drawing.Size(544, 489);
            this.Expenses_groupBox.TabIndex = 123;
            this.Expenses_groupBox.TabStop = false;
            this.Expenses_groupBox.Text = "Expenses";
            // 
            // Expense_Description_txt
            // 
            this.Expense_Description_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Description_txt.Location = new System.Drawing.Point(6, 180);
            this.Expense_Description_txt.Name = "Expense_Description_txt";
            this.Expense_Description_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Expense_Description_txt.Size = new System.Drawing.Size(311, 32);
            this.Expense_Description_txt.TabIndex = 6;
            // 
            // Expense_Managment_dataGridView
            // 
            this.Expense_Managment_dataGridView.AllowUserToAddRows = false;
            this.Expense_Managment_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Expense_Managment_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Expense_Managment_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Expense_Managment_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Expense_Managment_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Expense_Managment_dataGridView.Location = new System.Drawing.Point(550, 80);
            this.Expense_Managment_dataGridView.Name = "Expense_Managment_dataGridView";
            this.Expense_Managment_dataGridView.Size = new System.Drawing.Size(979, 489);
            this.Expense_Managment_dataGridView.TabIndex = 124;
            // 
            // School_Term_txt
            // 
            this.School_Term_txt.DataSource = this.activityManagmenttblBindingSource;
            this.School_Term_txt.DisplayMember = "School_Term";
            this.School_Term_txt.FormattingEnabled = true;
            this.School_Term_txt.Location = new System.Drawing.Point(754, 21);
            this.School_Term_txt.Name = "School_Term_txt";
            this.School_Term_txt.Size = new System.Drawing.Size(354, 30);
            this.School_Term_txt.TabIndex = 131;
            this.School_Term_txt.SelectedIndexChanged += new System.EventHandler(this.School_Term_txt_SelectedIndexChanged);
            // 
            // School_Term_lbl
            // 
            this.School_Term_lbl.AutoSize = true;
            this.School_Term_lbl.Location = new System.Drawing.Point(578, 24);
            this.School_Term_lbl.Name = "School_Term_lbl";
            this.School_Term_lbl.Size = new System.Drawing.Size(136, 22);
            this.School_Term_lbl.TabIndex = 132;
            this.School_Term_lbl.Text = "School Term :";
            // 
            // Transfer_Rate_lbl
            // 
            this.Transfer_Rate_lbl.AutoSize = true;
            this.Transfer_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Transfer_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Transfer_Rate_lbl.Location = new System.Drawing.Point(967, 613);
            this.Transfer_Rate_lbl.Name = "Transfer_Rate_lbl";
            this.Transfer_Rate_lbl.Size = new System.Drawing.Size(135, 22);
            this.Transfer_Rate_lbl.TabIndex = 136;
            this.Transfer_Rate_lbl.Text = "Transfer Rate";
            this.Transfer_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Transfer_Rate_lbl.Visible = false;
            // 
            // Bank_Rate_lbl
            // 
            this.Bank_Rate_lbl.AutoSize = true;
            this.Bank_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bank_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Bank_Rate_lbl.Location = new System.Drawing.Point(1108, 613);
            this.Bank_Rate_lbl.Name = "Bank_Rate_lbl";
            this.Bank_Rate_lbl.Size = new System.Drawing.Size(105, 22);
            this.Bank_Rate_lbl.TabIndex = 135;
            this.Bank_Rate_lbl.Text = "Bank Rate";
            this.Bank_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bank_Rate_lbl.Visible = false;
            // 
            // Other_Rate_lbl
            // 
            this.Other_Rate_lbl.AutoSize = true;
            this.Other_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Other_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Other_Rate_lbl.Location = new System.Drawing.Point(1219, 613);
            this.Other_Rate_lbl.Name = "Other_Rate_lbl";
            this.Other_Rate_lbl.Size = new System.Drawing.Size(110, 22);
            this.Other_Rate_lbl.TabIndex = 134;
            this.Other_Rate_lbl.Text = "Other Rate";
            this.Other_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Other_Rate_lbl.Visible = false;
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(854, 613);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 133;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // activity_Managment_tblTableAdapter
            // 
            this.activity_Managment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Activity_Cost_Managment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1530, 662);
            this.Controls.Add(this.Transfer_Rate_lbl);
            this.Controls.Add(this.Bank_Rate_lbl);
            this.Controls.Add(this.Other_Rate_lbl);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.School_Term_txt);
            this.Controls.Add(this.School_Term_lbl);
            this.Controls.Add(this.Transport_Date_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Expense_Date_dateTimePicker);
            this.Controls.Add(this.Expenses_groupBox);
            this.Controls.Add(this.Expense_Managment_dataGridView);
            this.Controls.Add(this.Activity_Name_txt);
            this.Controls.Add(this.Activity_Name_lbl);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Activity_Cost_Managment_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Activity Cost Managment ";
            this.Load += new System.EventHandler(this.Activity_Cost_Managment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityManagmenttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Expenses_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Received_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Amount_txt)).EndInit();
            this.Expenses_groupBox.ResumeLayout(false);
            this.Expenses_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Managment_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Activity_Name_lbl;
        private System.Windows.Forms.ComboBox Activity_Name_txt;
        private System.Windows.Forms.Label Activity_Profit_txt;
        private System.Windows.Forms.Label Activity_Profit_lbl;
        private System.Windows.Forms.NumericUpDown Total_Expenses_txt;
        private System.Windows.Forms.NumericUpDown Total_Received_txt;
        private System.Windows.Forms.RadioButton Other_radioButton;
        private System.Windows.Forms.RadioButton Bank_radioButton;
        private System.Windows.Forms.RadioButton Cash_radioButton;
        private System.Windows.Forms.RadioButton Transfer_radioButton;
        private System.Windows.Forms.Button Add_Expense_btn;
        private System.Windows.Forms.Label Transport_Date_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Expense_Amount_txt;
        private System.Windows.Forms.Label Total_Expenses_lbl;
        private System.Windows.Forms.Label Equals_lbl;
        private System.Windows.Forms.Label Figure_lbl;
        private System.Windows.Forms.Label Description_lbl;
        private System.Windows.Forms.Label Total_Received_lbl;
        private System.Windows.Forms.DateTimePicker Expense_Date_dateTimePicker;
        private System.Windows.Forms.GroupBox Expenses_groupBox;
        private System.Windows.Forms.TextBox Expense_Description_txt;
        private System.Windows.Forms.DataGridView Expense_Managment_dataGridView;
        private System.Windows.Forms.ComboBox School_Term_txt;
        private System.Windows.Forms.Label School_Term_lbl;
        private System.Windows.Forms.Label Transfer_Rate_lbl;
        private System.Windows.Forms.Label Bank_Rate_lbl;
        private System.Windows.Forms.Label Other_Rate_lbl;
        private System.Windows.Forms.Label User_txt;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource activityManagmenttblBindingSource;
        private System_DatabaseDataSetTableAdapters.Activity_Managment_tblTableAdapter activity_Managment_tblTableAdapter;
    }
}