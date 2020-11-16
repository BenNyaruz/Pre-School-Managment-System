namespace Pre_School_Managment_System
{
    partial class Student_Registration_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Registration_Record));
            this.User_txt = new System.Windows.Forms.Label();
            this.Done_btn = new System.Windows.Forms.Button();
            this.Student_Registration_Record_dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentGaurdianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionSpecialNeedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentRegistrationRecordtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.student_Registration_Record_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Student_Registration_Record_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Registration_Record_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(23, 597);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 56;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // Done_btn
            // 
            this.Done_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Done_btn.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done_btn.Location = new System.Drawing.Point(702, 597);
            this.Done_btn.Name = "Done_btn";
            this.Done_btn.Size = new System.Drawing.Size(123, 49);
            this.Done_btn.TabIndex = 55;
            this.Done_btn.Text = "&Done";
            this.Done_btn.UseVisualStyleBackColor = false;
            this.Done_btn.Click += new System.EventHandler(this.Done_btn_Click);
            // 
            // Student_Registration_Record_dataGridView
            // 
            this.Student_Registration_Record_dataGridView.AllowUserToAddRows = false;
            this.Student_Registration_Record_dataGridView.AutoGenerateColumns = false;
            this.Student_Registration_Record_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Student_Registration_Record_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Student_Registration_Record_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Student_Registration_Record_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_Registration_Record_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.houseAddressDataGridViewTextBoxColumn,
            this.contactDetailsDataGridViewTextBoxColumn,
            this.parentGaurdianDataGridViewTextBoxColumn,
            this.healthRecordDataGridViewTextBoxColumn,
            this.descriptionSpecialNeedsDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.accountantDataGridViewTextBoxColumn});
            this.Student_Registration_Record_dataGridView.DataSource = this.studentRegistrationRecordtblBindingSource;
            this.Student_Registration_Record_dataGridView.Location = new System.Drawing.Point(1, 1);
            this.Student_Registration_Record_dataGridView.Name = "Student_Registration_Record_dataGridView";
            this.Student_Registration_Record_dataGridView.Size = new System.Drawing.Size(1361, 554);
            this.Student_Registration_Record_dataGridView.TabIndex = 54;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 53;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 139;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 117;
            // 
            // houseAddressDataGridViewTextBoxColumn
            // 
            this.houseAddressDataGridViewTextBoxColumn.DataPropertyName = "House_Address";
            this.houseAddressDataGridViewTextBoxColumn.HeaderText = "House_Address";
            this.houseAddressDataGridViewTextBoxColumn.Name = "houseAddressDataGridViewTextBoxColumn";
            this.houseAddressDataGridViewTextBoxColumn.Width = 179;
            // 
            // contactDetailsDataGridViewTextBoxColumn
            // 
            this.contactDetailsDataGridViewTextBoxColumn.DataPropertyName = "Contact_Details";
            this.contactDetailsDataGridViewTextBoxColumn.HeaderText = "Contact_Details";
            this.contactDetailsDataGridViewTextBoxColumn.Name = "contactDetailsDataGridViewTextBoxColumn";
            this.contactDetailsDataGridViewTextBoxColumn.Width = 180;
            // 
            // parentGaurdianDataGridViewTextBoxColumn
            // 
            this.parentGaurdianDataGridViewTextBoxColumn.DataPropertyName = "Parent_Gaurdian";
            this.parentGaurdianDataGridViewTextBoxColumn.HeaderText = "Parent_Gaurdian";
            this.parentGaurdianDataGridViewTextBoxColumn.Name = "parentGaurdianDataGridViewTextBoxColumn";
            this.parentGaurdianDataGridViewTextBoxColumn.Width = 190;
            // 
            // healthRecordDataGridViewTextBoxColumn
            // 
            this.healthRecordDataGridViewTextBoxColumn.DataPropertyName = "Health_Record";
            this.healthRecordDataGridViewTextBoxColumn.HeaderText = "Health_Record";
            this.healthRecordDataGridViewTextBoxColumn.Name = "healthRecordDataGridViewTextBoxColumn";
            this.healthRecordDataGridViewTextBoxColumn.Width = 171;
            // 
            // descriptionSpecialNeedsDataGridViewTextBoxColumn
            // 
            this.descriptionSpecialNeedsDataGridViewTextBoxColumn.DataPropertyName = "Description_Special_Needs";
            this.descriptionSpecialNeedsDataGridViewTextBoxColumn.HeaderText = "Description_Special_Needs";
            this.descriptionSpecialNeedsDataGridViewTextBoxColumn.Name = "descriptionSpecialNeedsDataGridViewTextBoxColumn";
            this.descriptionSpecialNeedsDataGridViewTextBoxColumn.Width = 286;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 69;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 98;
            // 
            // accountantDataGridViewTextBoxColumn
            // 
            this.accountantDataGridViewTextBoxColumn.DataPropertyName = "Accountant";
            this.accountantDataGridViewTextBoxColumn.HeaderText = "Accountant";
            this.accountantDataGridViewTextBoxColumn.Name = "accountantDataGridViewTextBoxColumn";
            this.accountantDataGridViewTextBoxColumn.Width = 140;
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
            // student_Registration_Record_tblTableAdapter
            // 
            this.student_Registration_Record_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Student_Registration_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1364, 658);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Done_btn);
            this.Controls.Add(this.Student_Registration_Record_dataGridView);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Student_Registration_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Registration Record";
            this.Load += new System.EventHandler(this.Student_Registration_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_Registration_Record_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User_txt;
        private System.Windows.Forms.Button Done_btn;
        private System.Windows.Forms.DataGridView Student_Registration_Record_dataGridView;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource studentRegistrationRecordtblBindingSource;
        private System_DatabaseDataSetTableAdapters.Student_Registration_Record_tblTableAdapter student_Registration_Record_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentGaurdianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthRecordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionSpecialNeedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantDataGridViewTextBoxColumn;
    }
}