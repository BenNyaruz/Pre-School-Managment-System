namespace Pre_School_Managment_System
{
    partial class Accounting_Profit_n_Loss_Acc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting_Profit_n_Loss_Acc));
            this.Profit_n_Loss_txt = new System.Windows.Forms.RichTextBox();
            this.User_txt = new System.Windows.Forms.Label();
            this.School_Term_txt = new System.Windows.Forms.ComboBox();
            this.feesManagmenttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.School_Term_lbl = new System.Windows.Forms.Label();
            this.Load_btn = new System.Windows.Forms.Button();
            this.Print_btn = new System.Windows.Forms.Button();
            this.Quit_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Balance_BB_txt = new System.Windows.Forms.NumericUpDown();
            this.Balance_Brought_Back = new System.Windows.Forms.Label();
            this.fees_Managment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Fees_Managment_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.feesManagmenttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balance_BB_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // Profit_n_Loss_txt
            // 
            this.Profit_n_Loss_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Profit_n_Loss_txt.Location = new System.Drawing.Point(0, -1);
            this.Profit_n_Loss_txt.Name = "Profit_n_Loss_txt";
            this.Profit_n_Loss_txt.Size = new System.Drawing.Size(934, 730);
            this.Profit_n_Loss_txt.TabIndex = 0;
            this.Profit_n_Loss_txt.Text = "";
            this.Profit_n_Loss_txt.WordWrap = false;
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(1412, 697);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 64;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // School_Term_txt
            // 
            this.School_Term_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.School_Term_txt.DataSource = this.feesManagmenttblBindingSource;
            this.School_Term_txt.DisplayMember = "School_Term";
            this.School_Term_txt.FormattingEnabled = true;
            this.School_Term_txt.Location = new System.Drawing.Point(1145, 44);
            this.School_Term_txt.Name = "School_Term_txt";
            this.School_Term_txt.Size = new System.Drawing.Size(340, 30);
            this.School_Term_txt.TabIndex = 0;
            this.School_Term_txt.TabStop = false;
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
            this.School_Term_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.School_Term_lbl.AutoSize = true;
            this.School_Term_lbl.Location = new System.Drawing.Point(977, 47);
            this.School_Term_lbl.Name = "School_Term_lbl";
            this.School_Term_lbl.Size = new System.Drawing.Size(136, 22);
            this.School_Term_lbl.TabIndex = 83;
            this.School_Term_lbl.Text = "School Term :";
            // 
            // Load_btn
            // 
            this.Load_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Load_btn.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_btn.ForeColor = System.Drawing.Color.Black;
            this.Load_btn.Location = new System.Drawing.Point(1162, 296);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(275, 77);
            this.Load_btn.TabIndex = 2;
            this.Load_btn.TabStop = false;
            this.Load_btn.Text = "&Compute";
            this.Load_btn.UseVisualStyleBackColor = false;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // Print_btn
            // 
            this.Print_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Print_btn.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_btn.ForeColor = System.Drawing.Color.Black;
            this.Print_btn.Location = new System.Drawing.Point(1148, 435);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(302, 77);
            this.Print_btn.TabIndex = 3;
            this.Print_btn.TabStop = false;
            this.Print_btn.Text = "&Download";
            this.Print_btn.UseVisualStyleBackColor = false;
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // Quit_btn
            // 
            this.Quit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quit_btn.BackColor = System.Drawing.Color.Tomato;
            this.Quit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quit_btn.ForeColor = System.Drawing.Color.Black;
            this.Quit_btn.Location = new System.Drawing.Point(1239, 574);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(120, 38);
            this.Quit_btn.TabIndex = 4;
            this.Quit_btn.TabStop = false;
            this.Quit_btn.Text = "&Quit";
            this.Quit_btn.UseVisualStyleBackColor = false;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Balance_BB_txt
            // 
            this.Balance_BB_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Balance_BB_txt.DecimalPlaces = 2;
            this.Balance_BB_txt.Location = new System.Drawing.Point(1145, 120);
            this.Balance_BB_txt.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.Balance_BB_txt.Minimum = new decimal(new int[] {
            276447232,
            23283,
            0,
            -2147483648});
            this.Balance_BB_txt.Name = "Balance_BB_txt";
            this.Balance_BB_txt.Size = new System.Drawing.Size(340, 29);
            this.Balance_BB_txt.TabIndex = 1;
            this.Balance_BB_txt.TabStop = false;
            this.Balance_BB_txt.ThousandsSeparator = true;
            // 
            // Balance_Brought_Back
            // 
            this.Balance_Brought_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Balance_Brought_Back.Location = new System.Drawing.Point(950, 109);
            this.Balance_Brought_Back.Name = "Balance_Brought_Back";
            this.Balance_Brought_Back.Size = new System.Drawing.Size(163, 50);
            this.Balance_Brought_Back.TabIndex = 88;
            this.Balance_Brought_Back.Text = "Balance Brought Back :";
            this.Balance_Brought_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fees_Managment_tblTableAdapter
            // 
            this.fees_Managment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Accounting_Profit_n_Loss_Acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1531, 728);
            this.Controls.Add(this.Balance_Brought_Back);
            this.Controls.Add(this.Balance_BB_txt);
            this.Controls.Add(this.Quit_btn);
            this.Controls.Add(this.Print_btn);
            this.Controls.Add(this.Load_btn);
            this.Controls.Add(this.School_Term_txt);
            this.Controls.Add(this.School_Term_lbl);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Profit_n_Loss_txt);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Accounting_Profit_n_Loss_Acc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profit and Loss Account";
            this.Load += new System.EventHandler(this.Accounting_Profit_n_Loss_Acc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feesManagmenttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balance_BB_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Profit_n_Loss_txt;
        private System.Windows.Forms.Label User_txt;
        private System.Windows.Forms.ComboBox School_Term_txt;
        private System.Windows.Forms.Label School_Term_lbl;
        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.Button Print_btn;
        private System.Windows.Forms.Button Quit_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown Balance_BB_txt;
        private System.Windows.Forms.Label Balance_Brought_Back;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource feesManagmenttblBindingSource;
        private System_DatabaseDataSetTableAdapters.Fees_Managment_tblTableAdapter fees_Managment_tblTableAdapter;
    }
}