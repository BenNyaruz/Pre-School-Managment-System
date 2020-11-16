namespace Pre_School_Managment_System
{
    partial class Activity_Creation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity_Creation_Form));
            this.From_Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Location_txt = new System.Windows.Forms.TextBox();
            this.Activity_Name_txt = new System.Windows.Forms.TextBox();
            this.Activity_Description_txt = new System.Windows.Forms.TextBox();
            this.From_Date_lbl = new System.Windows.Forms.Label();
            this.Location_lbl = new System.Windows.Forms.Label();
            this.Activity_Name_lbl = new System.Windows.Forms.Label();
            this.Activity_Description_lbl = new System.Windows.Forms.Label();
            this.To_Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.To_Date_lbl = new System.Windows.Forms.Label();
            this.Build_btn = new System.Windows.Forms.Button();
            this.Activity_Fees_groupBox = new System.Windows.Forms.GroupBox();
            this.Cash_txt = new System.Windows.Forms.NumericUpDown();
            this.User_txt = new System.Windows.Forms.Label();
            this.School_Term_txt = new System.Windows.Forms.ComboBox();
            this.feesManagmenttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.School_Term_lbl = new System.Windows.Forms.Label();
            this.fees_Managment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Fees_Managment_tblTableAdapter();
            this.Activity_Fees_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cash_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesManagmenttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // From_Date_dateTimePicker
            // 
            this.From_Date_dateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.From_Date_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.From_Date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From_Date_dateTimePicker.Location = new System.Drawing.Point(324, 309);
            this.From_Date_dateTimePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.From_Date_dateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.From_Date_dateTimePicker.Name = "From_Date_dateTimePicker";
            this.From_Date_dateTimePicker.Size = new System.Drawing.Size(377, 29);
            this.From_Date_dateTimePicker.TabIndex = 4;
            this.From_Date_dateTimePicker.Value = new System.DateTime(2020, 1, 12, 0, 0, 0, 0);
            // 
            // Location_txt
            // 
            this.Location_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location_txt.Location = new System.Drawing.Point(324, 185);
            this.Location_txt.Name = "Location_txt";
            this.Location_txt.Size = new System.Drawing.Size(377, 26);
            this.Location_txt.TabIndex = 2;
            // 
            // Activity_Name_txt
            // 
            this.Activity_Name_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_Name_txt.Location = new System.Drawing.Point(324, 125);
            this.Activity_Name_txt.Name = "Activity_Name_txt";
            this.Activity_Name_txt.Size = new System.Drawing.Size(377, 26);
            this.Activity_Name_txt.TabIndex = 1;
            // 
            // Activity_Description_txt
            // 
            this.Activity_Description_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_Description_txt.Location = new System.Drawing.Point(324, 435);
            this.Activity_Description_txt.Multiline = true;
            this.Activity_Description_txt.Name = "Activity_Description_txt";
            this.Activity_Description_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Activity_Description_txt.Size = new System.Drawing.Size(377, 129);
            this.Activity_Description_txt.TabIndex = 6;
            // 
            // From_Date_lbl
            // 
            this.From_Date_lbl.AutoSize = true;
            this.From_Date_lbl.Location = new System.Drawing.Point(222, 314);
            this.From_Date_lbl.Name = "From_Date_lbl";
            this.From_Date_lbl.Size = new System.Drawing.Size(68, 22);
            this.From_Date_lbl.TabIndex = 51;
            this.From_Date_lbl.Text = "From :";
            // 
            // Location_lbl
            // 
            this.Location_lbl.AutoSize = true;
            this.Location_lbl.Location = new System.Drawing.Point(191, 188);
            this.Location_lbl.Name = "Location_lbl";
            this.Location_lbl.Size = new System.Drawing.Size(99, 22);
            this.Location_lbl.TabIndex = 50;
            this.Location_lbl.Text = "Location :";
            // 
            // Activity_Name_lbl
            // 
            this.Activity_Name_lbl.AutoSize = true;
            this.Activity_Name_lbl.Location = new System.Drawing.Point(142, 125);
            this.Activity_Name_lbl.Name = "Activity_Name_lbl";
            this.Activity_Name_lbl.Size = new System.Drawing.Size(148, 22);
            this.Activity_Name_lbl.TabIndex = 49;
            this.Activity_Name_lbl.Text = "Activity Name :";
            // 
            // Activity_Description_lbl
            // 
            this.Activity_Description_lbl.AutoSize = true;
            this.Activity_Description_lbl.Location = new System.Drawing.Point(90, 485);
            this.Activity_Description_lbl.Name = "Activity_Description_lbl";
            this.Activity_Description_lbl.Size = new System.Drawing.Size(200, 22);
            this.Activity_Description_lbl.TabIndex = 48;
            this.Activity_Description_lbl.Text = "Activity Description :";
            // 
            // To_Date_dateTimePicker
            // 
            this.To_Date_dateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.To_Date_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.To_Date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To_Date_dateTimePicker.Location = new System.Drawing.Point(324, 372);
            this.To_Date_dateTimePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.To_Date_dateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.To_Date_dateTimePicker.Name = "To_Date_dateTimePicker";
            this.To_Date_dateTimePicker.Size = new System.Drawing.Size(377, 29);
            this.To_Date_dateTimePicker.TabIndex = 5;
            this.To_Date_dateTimePicker.Value = new System.DateTime(2020, 1, 12, 0, 0, 0, 0);
            // 
            // To_Date_lbl
            // 
            this.To_Date_lbl.AutoSize = true;
            this.To_Date_lbl.Location = new System.Drawing.Point(246, 377);
            this.To_Date_lbl.Name = "To_Date_lbl";
            this.To_Date_lbl.Size = new System.Drawing.Size(44, 22);
            this.To_Date_lbl.TabIndex = 58;
            this.To_Date_lbl.Text = "To :";
            // 
            // Build_btn
            // 
            this.Build_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Build_btn.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Build_btn.Location = new System.Drawing.Point(1065, 466);
            this.Build_btn.Name = "Build_btn";
            this.Build_btn.Size = new System.Drawing.Size(242, 97);
            this.Build_btn.TabIndex = 10;
            this.Build_btn.Text = "&Build";
            this.Build_btn.UseVisualStyleBackColor = false;
            this.Build_btn.Click += new System.EventHandler(this.Build_btn_Click);
            // 
            // Activity_Fees_groupBox
            // 
            this.Activity_Fees_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Activity_Fees_groupBox.Controls.Add(this.Cash_txt);
            this.Activity_Fees_groupBox.Location = new System.Drawing.Point(840, 125);
            this.Activity_Fees_groupBox.Name = "Activity_Fees_groupBox";
            this.Activity_Fees_groupBox.Size = new System.Drawing.Size(567, 267);
            this.Activity_Fees_groupBox.TabIndex = 62;
            this.Activity_Fees_groupBox.TabStop = false;
            this.Activity_Fees_groupBox.Text = "Activity Fees";
            // 
            // Cash_txt
            // 
            this.Cash_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cash_txt.DecimalPlaces = 2;
            this.Cash_txt.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Cash_txt.Location = new System.Drawing.Point(6, 101);
            this.Cash_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Cash_txt.Name = "Cash_txt";
            this.Cash_txt.Size = new System.Drawing.Size(555, 60);
            this.Cash_txt.TabIndex = 7;
            this.Cash_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cash_txt.ThousandsSeparator = true;
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(12, 9);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 63;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // School_Term_txt
            // 
            this.School_Term_txt.DataSource = this.feesManagmenttblBindingSource;
            this.School_Term_txt.DisplayMember = "School_Term";
            this.School_Term_txt.FormattingEnabled = true;
            this.School_Term_txt.Location = new System.Drawing.Point(324, 245);
            this.School_Term_txt.Name = "School_Term_txt";
            this.School_Term_txt.Size = new System.Drawing.Size(377, 30);
            this.School_Term_txt.TabIndex = 3;
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
            // School_Term_lbl
            // 
            this.School_Term_lbl.AutoSize = true;
            this.School_Term_lbl.Location = new System.Drawing.Point(154, 251);
            this.School_Term_lbl.Name = "School_Term_lbl";
            this.School_Term_lbl.Size = new System.Drawing.Size(136, 22);
            this.School_Term_lbl.TabIndex = 74;
            this.School_Term_lbl.Text = "School Term :";
            // 
            // fees_Managment_tblTableAdapter
            // 
            this.fees_Managment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Activity_Creation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1530, 658);
            this.Controls.Add(this.School_Term_txt);
            this.Controls.Add(this.School_Term_lbl);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Activity_Fees_groupBox);
            this.Controls.Add(this.Build_btn);
            this.Controls.Add(this.To_Date_dateTimePicker);
            this.Controls.Add(this.To_Date_lbl);
            this.Controls.Add(this.From_Date_dateTimePicker);
            this.Controls.Add(this.Location_txt);
            this.Controls.Add(this.Activity_Name_txt);
            this.Controls.Add(this.Activity_Description_txt);
            this.Controls.Add(this.From_Date_lbl);
            this.Controls.Add(this.Location_lbl);
            this.Controls.Add(this.Activity_Name_lbl);
            this.Controls.Add(this.Activity_Description_lbl);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Activity_Creation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Activity Creation Form";
            this.Load += new System.EventHandler(this.Activity_Creation_Form_Load);
            this.Activity_Fees_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cash_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feesManagmenttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker From_Date_dateTimePicker;
        private System.Windows.Forms.TextBox Location_txt;
        private System.Windows.Forms.TextBox Activity_Name_txt;
        private System.Windows.Forms.TextBox Activity_Description_txt;
        private System.Windows.Forms.Label From_Date_lbl;
        private System.Windows.Forms.Label Location_lbl;
        private System.Windows.Forms.Label Activity_Name_lbl;
        private System.Windows.Forms.Label Activity_Description_lbl;
        private System.Windows.Forms.DateTimePicker To_Date_dateTimePicker;
        private System.Windows.Forms.Label To_Date_lbl;
        private System.Windows.Forms.Button Build_btn;
        private System.Windows.Forms.GroupBox Activity_Fees_groupBox;
        private System.Windows.Forms.NumericUpDown Cash_txt;
        private System.Windows.Forms.Label User_txt;
        private System.Windows.Forms.ComboBox School_Term_txt;
        private System.Windows.Forms.Label School_Term_lbl;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource feesManagmenttblBindingSource;
        private System_DatabaseDataSetTableAdapters.Fees_Managment_tblTableAdapter fees_Managment_tblTableAdapter;
    }
}