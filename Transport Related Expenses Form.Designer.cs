namespace Pre_School_Managment_System
{
    partial class Transport_Related_Expenses_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transport_Related_Expenses_Form));
            this.Expense_Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Transport_Date_lbl = new System.Windows.Forms.Label();
            this.Transfer_Rate_lbl = new System.Windows.Forms.Label();
            this.Bank_Rate_lbl = new System.Windows.Forms.Label();
            this.Other_Rate_lbl = new System.Windows.Forms.Label();
            this.User_txt = new System.Windows.Forms.Label();
            this.Transport_Profit_txt = new System.Windows.Forms.Label();
            this.Transport_Profit_lbl = new System.Windows.Forms.Label();
            this.Total_Expenses_txt = new System.Windows.Forms.NumericUpDown();
            this.Total_Received_txt = new System.Windows.Forms.NumericUpDown();
            this.Other_radioButton = new System.Windows.Forms.RadioButton();
            this.Bank_radioButton = new System.Windows.Forms.RadioButton();
            this.Cash_radioButton = new System.Windows.Forms.RadioButton();
            this.Transfer_radioButton = new System.Windows.Forms.RadioButton();
            this.Add_Expense_btn = new System.Windows.Forms.Button();
            this.Expense_Amount_txt = new System.Windows.Forms.NumericUpDown();
            this.Total_Expenses_lbl = new System.Windows.Forms.Label();
            this.Equals_lbl = new System.Windows.Forms.Label();
            this.Expense_Description_txt = new System.Windows.Forms.TextBox();
            this.Figure_lbl = new System.Windows.Forms.Label();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.Total_Received_lbl = new System.Windows.Forms.Label();
            this.Expenses_groupBox = new System.Windows.Forms.GroupBox();
            this.School_Term_txt = new System.Windows.Forms.ComboBox();
            this.transportManagmenttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.Save_btn = new System.Windows.Forms.Button();
            this.School_Term_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Expense_Managment_dataGridView = new System.Windows.Forms.DataGridView();
            this.transport_Managment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Transport_Managment_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Expenses_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Received_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Amount_txt)).BeginInit();
            this.Expenses_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportManagmenttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Managment_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Expense_Date_dateTimePicker
            // 
            this.Expense_Date_dateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.Expense_Date_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Expense_Date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Expense_Date_dateTimePicker.Location = new System.Drawing.Point(808, 12);
            this.Expense_Date_dateTimePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.Expense_Date_dateTimePicker.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.Expense_Date_dateTimePicker.Name = "Expense_Date_dateTimePicker";
            this.Expense_Date_dateTimePicker.Size = new System.Drawing.Size(227, 29);
            this.Expense_Date_dateTimePicker.TabIndex = 110;
            this.Expense_Date_dateTimePicker.Value = new System.DateTime(2019, 12, 21, 0, 0, 0, 0);
            // 
            // Transport_Date_lbl
            // 
            this.Transport_Date_lbl.AutoSize = true;
            this.Transport_Date_lbl.Location = new System.Drawing.Point(686, 17);
            this.Transport_Date_lbl.Name = "Transport_Date_lbl";
            this.Transport_Date_lbl.Size = new System.Drawing.Size(64, 22);
            this.Transport_Date_lbl.TabIndex = 109;
            this.Transport_Date_lbl.Text = "Date :";
            // 
            // Transfer_Rate_lbl
            // 
            this.Transfer_Rate_lbl.AutoSize = true;
            this.Transfer_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Transfer_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Transfer_Rate_lbl.Location = new System.Drawing.Point(1000, 614);
            this.Transfer_Rate_lbl.Name = "Transfer_Rate_lbl";
            this.Transfer_Rate_lbl.Size = new System.Drawing.Size(135, 22);
            this.Transfer_Rate_lbl.TabIndex = 108;
            this.Transfer_Rate_lbl.Text = "Transfer Rate";
            this.Transfer_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Transfer_Rate_lbl.Visible = false;
            // 
            // Bank_Rate_lbl
            // 
            this.Bank_Rate_lbl.AutoSize = true;
            this.Bank_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bank_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Bank_Rate_lbl.Location = new System.Drawing.Point(1141, 614);
            this.Bank_Rate_lbl.Name = "Bank_Rate_lbl";
            this.Bank_Rate_lbl.Size = new System.Drawing.Size(105, 22);
            this.Bank_Rate_lbl.TabIndex = 107;
            this.Bank_Rate_lbl.Text = "Bank Rate";
            this.Bank_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bank_Rate_lbl.Visible = false;
            // 
            // Other_Rate_lbl
            // 
            this.Other_Rate_lbl.AutoSize = true;
            this.Other_Rate_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Other_Rate_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Other_Rate_lbl.Location = new System.Drawing.Point(1252, 614);
            this.Other_Rate_lbl.Name = "Other_Rate_lbl";
            this.Other_Rate_lbl.Size = new System.Drawing.Size(110, 22);
            this.Other_Rate_lbl.TabIndex = 106;
            this.Other_Rate_lbl.Text = "Other Rate";
            this.Other_Rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Other_Rate_lbl.Visible = false;
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(887, 614);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 105;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // Transport_Profit_txt
            // 
            this.Transport_Profit_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transport_Profit_txt.AutoSize = true;
            this.Transport_Profit_txt.BackColor = System.Drawing.Color.Transparent;
            this.Transport_Profit_txt.Font = new System.Drawing.Font("Arial Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transport_Profit_txt.ForeColor = System.Drawing.Color.Green;
            this.Transport_Profit_txt.Location = new System.Drawing.Point(332, 412);
            this.Transport_Profit_txt.Name = "Transport_Profit_txt";
            this.Transport_Profit_txt.Size = new System.Drawing.Size(94, 45);
            this.Transport_Profit_txt.TabIndex = 97;
            this.Transport_Profit_txt.Text = "0.00";
            // 
            // Transport_Profit_lbl
            // 
            this.Transport_Profit_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transport_Profit_lbl.AutoSize = true;
            this.Transport_Profit_lbl.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transport_Profit_lbl.ForeColor = System.Drawing.Color.Green;
            this.Transport_Profit_lbl.Location = new System.Drawing.Point(1, 413);
            this.Transport_Profit_lbl.Name = "Transport_Profit_lbl";
            this.Transport_Profit_lbl.Size = new System.Drawing.Size(341, 45);
            this.Transport_Profit_lbl.TabIndex = 96;
            this.Transport_Profit_lbl.Text = "Transport Profit: $";
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
            // Expense_Description_txt
            // 
            this.Expense_Description_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expense_Description_txt.Location = new System.Drawing.Point(6, 180);
            this.Expense_Description_txt.Name = "Expense_Description_txt";
            this.Expense_Description_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Expense_Description_txt.Size = new System.Drawing.Size(311, 32);
            this.Expense_Description_txt.TabIndex = 6;
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
            // Expenses_groupBox
            // 
            this.Expenses_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Expenses_groupBox.Controls.Add(this.Transport_Profit_txt);
            this.Expenses_groupBox.Controls.Add(this.Transport_Profit_lbl);
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
            this.Expenses_groupBox.Location = new System.Drawing.Point(5, 79);
            this.Expenses_groupBox.Name = "Expenses_groupBox";
            this.Expenses_groupBox.Size = new System.Drawing.Size(544, 489);
            this.Expenses_groupBox.TabIndex = 103;
            this.Expenses_groupBox.TabStop = false;
            this.Expenses_groupBox.Text = "Expenses";
            // 
            // School_Term_txt
            // 
            this.School_Term_txt.DataSource = this.transportManagmenttblBindingSource;
            this.School_Term_txt.DisplayMember = "School_Term";
            this.School_Term_txt.FormattingEnabled = true;
            this.School_Term_txt.Location = new System.Drawing.Point(195, 11);
            this.School_Term_txt.Name = "School_Term_txt";
            this.School_Term_txt.Size = new System.Drawing.Size(354, 30);
            this.School_Term_txt.TabIndex = 100;
            this.School_Term_txt.SelectedIndexChanged += new System.EventHandler(this.School_Term_txt_SelectedIndexChanged);
            // 
            // transportManagmenttblBindingSource
            // 
            this.transportManagmenttblBindingSource.DataMember = "Transport_Managment_tbl";
            this.transportManagmenttblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // system_DatabaseDataSet
            // 
            this.system_DatabaseDataSet.DataSetName = "System_DatabaseDataSet";
            this.system_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Save_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Save_btn.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(670, 585);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(122, 63);
            this.Save_btn.TabIndex = 102;
            this.Save_btn.Text = "&Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // School_Term_lbl
            // 
            this.School_Term_lbl.AutoSize = true;
            this.School_Term_lbl.Location = new System.Drawing.Point(19, 14);
            this.School_Term_lbl.Name = "School_Term_lbl";
            this.School_Term_lbl.Size = new System.Drawing.Size(136, 22);
            this.School_Term_lbl.TabIndex = 101;
            this.School_Term_lbl.Text = "School Term :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Expense_Managment_dataGridView
            // 
            this.Expense_Managment_dataGridView.AllowUserToAddRows = false;
            this.Expense_Managment_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Expense_Managment_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Expense_Managment_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Expense_Managment_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Expense_Managment_dataGridView.Location = new System.Drawing.Point(553, 79);
            this.Expense_Managment_dataGridView.Name = "Expense_Managment_dataGridView";
            this.Expense_Managment_dataGridView.Size = new System.Drawing.Size(979, 489);
            this.Expense_Managment_dataGridView.TabIndex = 104;
            // 
            // transport_Managment_tblTableAdapter
            // 
            this.transport_Managment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Transport_Related_Expenses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1532, 659);
            this.Controls.Add(this.Expense_Date_dateTimePicker);
            this.Controls.Add(this.Transport_Date_lbl);
            this.Controls.Add(this.Transfer_Rate_lbl);
            this.Controls.Add(this.Bank_Rate_lbl);
            this.Controls.Add(this.Other_Rate_lbl);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Expenses_groupBox);
            this.Controls.Add(this.School_Term_txt);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.School_Term_lbl);
            this.Controls.Add(this.Expense_Managment_dataGridView);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Transport_Related_Expenses_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transport Managment  Form";
            this.Load += new System.EventHandler(this.Transport_Related_Expenses_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Total_Expenses_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Received_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Amount_txt)).EndInit();
            this.Expenses_groupBox.ResumeLayout(false);
            this.Expenses_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportManagmenttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expense_Managment_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Expense_Date_dateTimePicker;
        private System.Windows.Forms.Label Transport_Date_lbl;
        private System.Windows.Forms.Label Transfer_Rate_lbl;
        private System.Windows.Forms.Label Bank_Rate_lbl;
        private System.Windows.Forms.Label Other_Rate_lbl;
        private System.Windows.Forms.Label User_txt;
        private System.Windows.Forms.Label Transport_Profit_txt;
        private System.Windows.Forms.Label Transport_Profit_lbl;
        private System.Windows.Forms.NumericUpDown Total_Expenses_txt;
        private System.Windows.Forms.NumericUpDown Total_Received_txt;
        private System.Windows.Forms.RadioButton Other_radioButton;
        private System.Windows.Forms.RadioButton Bank_radioButton;
        private System.Windows.Forms.RadioButton Cash_radioButton;
        private System.Windows.Forms.RadioButton Transfer_radioButton;
        private System.Windows.Forms.Button Add_Expense_btn;
        private System.Windows.Forms.NumericUpDown Expense_Amount_txt;
        private System.Windows.Forms.Label Total_Expenses_lbl;
        private System.Windows.Forms.Label Equals_lbl;
        private System.Windows.Forms.TextBox Expense_Description_txt;
        private System.Windows.Forms.Label Figure_lbl;
        private System.Windows.Forms.Label Description_lbl;
        private System.Windows.Forms.Label Total_Received_lbl;
        private System.Windows.Forms.GroupBox Expenses_groupBox;
        private System.Windows.Forms.ComboBox School_Term_txt;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label School_Term_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView Expense_Managment_dataGridView;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource transportManagmenttblBindingSource;
        private System_DatabaseDataSetTableAdapters.Transport_Managment_tblTableAdapter transport_Managment_tblTableAdapter;
    }
}