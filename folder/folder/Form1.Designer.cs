namespace folder
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Folder_Box_Disk_ = new System.Windows.Forms.ComboBox();
            this.Folder_file_ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Folder_BT_del_ = new System.Windows.Forms.Button();
            this.Folder_BT_create_ = new System.Windows.Forms.Button();
            this.Folder_BT_File_del_ = new System.Windows.Forms.Button();
            this.Folder_BT_check_ = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.File1_numeric_ = new System.Windows.Forms.NumericUpDown();
            this.File1_BT_del_ = new System.Windows.Forms.Button();
            this.File1_BT_create_ = new System.Windows.Forms.Button();
            this.File1_BT_check_ = new System.Windows.Forms.Button();
            this.File1_Box_Name_ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.File1_Box_Del_ = new System.Windows.Forms.TextBox();
            this.txt_Box_ = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.file2_BT_wrt_ = new System.Windows.Forms.Button();
            this.file2_BT_read_ = new System.Windows.Forms.Button();
            this.File2_Box_Name_ = new System.Windows.Forms.TextBox();
            this.File2_dir_ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.zip_bt_comp_ = new System.Windows.Forms.Button();
            this.zip_bt_extr_ = new System.Windows.Forms.Button();
            this.Zip_Box_extr_ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Zip_Box_comp_ = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.File1_numeric_)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Folder_Box_Disk_);
            this.groupBox1.Controls.Add(this.Folder_file_);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Folder_BT_del_);
            this.groupBox1.Controls.Add(this.Folder_BT_create_);
            this.groupBox1.Controls.Add(this.Folder_BT_File_del_);
            this.groupBox1.Controls.Add(this.Folder_BT_check_);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THƯ MỤC";
            // 
            // Folder_Box_Disk_
            // 
            this.Folder_Box_Disk_.FormattingEnabled = true;
            this.Folder_Box_Disk_.Items.AddRange(new object[] {
            "C:\\\\"});
            this.Folder_Box_Disk_.Location = new System.Drawing.Point(100, 34);
            this.Folder_Box_Disk_.Name = "Folder_Box_Disk_";
            this.Folder_Box_Disk_.Size = new System.Drawing.Size(129, 21);
            this.Folder_Box_Disk_.TabIndex = 13;
            this.Folder_Box_Disk_.Text = "C:\\\\Users\\Admin\\Desktop\\";
            // 
            // Folder_file_
            // 
            this.Folder_file_.Location = new System.Drawing.Point(100, 73);
            this.Folder_file_.Name = "Folder_file_";
            this.Folder_file_.Size = new System.Drawing.Size(129, 20);
            this.Folder_file_.TabIndex = 1;
            this.Folder_file_.Text = "Dr_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ổ cừng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên thư mục";
            // 
            // Folder_BT_del_
            // 
            this.Folder_BT_del_.Location = new System.Drawing.Point(272, 128);
            this.Folder_BT_del_.Name = "Folder_BT_del_";
            this.Folder_BT_del_.Size = new System.Drawing.Size(75, 23);
            this.Folder_BT_del_.TabIndex = 12;
            this.Folder_BT_del_.Text = "Xóa thư mục";
            this.Folder_BT_del_.UseVisualStyleBackColor = true;
            this.Folder_BT_del_.Click += new System.EventHandler(this.Folder_BT_del__Click);
            // 
            // Folder_BT_create_
            // 
            this.Folder_BT_create_.Location = new System.Drawing.Point(100, 128);
            this.Folder_BT_create_.Name = "Folder_BT_create_";
            this.Folder_BT_create_.Size = new System.Drawing.Size(83, 23);
            this.Folder_BT_create_.TabIndex = 10;
            this.Folder_BT_create_.Text = "Tạo thư mục";
            this.Folder_BT_create_.UseVisualStyleBackColor = true;
            this.Folder_BT_create_.Click += new System.EventHandler(this.Folder_BT_create__Click);
            // 
            // Folder_BT_File_del_
            // 
            this.Folder_BT_File_del_.Location = new System.Drawing.Point(183, 128);
            this.Folder_BT_File_del_.Name = "Folder_BT_File_del_";
            this.Folder_BT_File_del_.Size = new System.Drawing.Size(83, 23);
            this.Folder_BT_File_del_.TabIndex = 11;
            this.Folder_BT_File_del_.Text = "Xóa tất cả file";
            this.Folder_BT_File_del_.UseVisualStyleBackColor = true;
            this.Folder_BT_File_del_.Click += new System.EventHandler(this.Folder_BT_File_del__Click);
            // 
            // Folder_BT_check_
            // 
            this.Folder_BT_check_.Location = new System.Drawing.Point(0, 128);
            this.Folder_BT_check_.Name = "Folder_BT_check_";
            this.Folder_BT_check_.Size = new System.Drawing.Size(94, 23);
            this.Folder_BT_check_.TabIndex = 9;
            this.Folder_BT_check_.Text = "Kiểm tra thư mục";
            this.Folder_BT_check_.UseVisualStyleBackColor = true;
            this.Folder_BT_check_.Click += new System.EventHandler(this.Folder_BT_check__Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.File1_numeric_);
            this.groupBox2.Controls.Add(this.File1_BT_del_);
            this.groupBox2.Controls.Add(this.File1_BT_create_);
            this.groupBox2.Controls.Add(this.File1_BT_check_);
            this.groupBox2.Controls.Add(this.File1_Box_Name_);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.File1_Box_Del_);
            this.groupBox2.Location = new System.Drawing.Point(15, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 208);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILE";
            // 
            // File1_numeric_
            // 
            this.File1_numeric_.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.File1_numeric_.Location = new System.Drawing.Point(83, 35);
            this.File1_numeric_.Name = "File1_numeric_";
            this.File1_numeric_.Size = new System.Drawing.Size(120, 20);
            this.File1_numeric_.TabIndex = 19;
            this.File1_numeric_.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // File1_BT_del_
            // 
            this.File1_BT_del_.Location = new System.Drawing.Point(232, 134);
            this.File1_BT_del_.Name = "File1_BT_del_";
            this.File1_BT_del_.Size = new System.Drawing.Size(75, 23);
            this.File1_BT_del_.TabIndex = 15;
            this.File1_BT_del_.Text = "Xóa file";
            this.File1_BT_del_.UseVisualStyleBackColor = true;
            this.File1_BT_del_.Click += new System.EventHandler(this.File1_BT_del__Click);
            // 
            // File1_BT_create_
            // 
            this.File1_BT_create_.Location = new System.Drawing.Point(232, 27);
            this.File1_BT_create_.Name = "File1_BT_create_";
            this.File1_BT_create_.Size = new System.Drawing.Size(75, 23);
            this.File1_BT_create_.TabIndex = 14;
            this.File1_BT_create_.Text = "Tạo file";
            this.File1_BT_create_.UseVisualStyleBackColor = true;
            this.File1_BT_create_.Click += new System.EventHandler(this.File1_BT_create__Click);
            // 
            // File1_BT_check_
            // 
            this.File1_BT_check_.Location = new System.Drawing.Point(232, 80);
            this.File1_BT_check_.Name = "File1_BT_check_";
            this.File1_BT_check_.Size = new System.Drawing.Size(75, 23);
            this.File1_BT_check_.TabIndex = 13;
            this.File1_BT_check_.Text = "Kiểm tra file";
            this.File1_BT_check_.UseVisualStyleBackColor = true;
            this.File1_BT_check_.Click += new System.EventHandler(this.File1_BT_check__Click);
            // 
            // File1_Box_Name_
            // 
            this.File1_Box_Name_.Location = new System.Drawing.Point(83, 82);
            this.File1_Box_Name_.Name = "File1_Box_Name_";
            this.File1_Box_Name_.Size = new System.Drawing.Size(75, 20);
            this.File1_Box_Name_.TabIndex = 0;
            this.File1_Box_Name_.Text = "File_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "+ STT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chọn file xóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cú pháp tên file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng file";
            // 
            // File1_Box_Del_
            // 
            this.File1_Box_Del_.Location = new System.Drawing.Point(83, 134);
            this.File1_Box_Del_.Name = "File1_Box_Del_";
            this.File1_Box_Del_.Size = new System.Drawing.Size(100, 20);
            this.File1_Box_Del_.TabIndex = 2;
            this.File1_Box_Del_.Text = "File_";
            // 
            // txt_Box_
            // 
            this.txt_Box_.Location = new System.Drawing.Point(368, 28);
            this.txt_Box_.Name = "txt_Box_";
            this.txt_Box_.Size = new System.Drawing.Size(233, 387);
            this.txt_Box_.TabIndex = 16;
            this.txt_Box_.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.file2_BT_wrt_);
            this.groupBox3.Controls.Add(this.file2_BT_read_);
            this.groupBox3.Controls.Add(this.File2_Box_Name_);
            this.groupBox3.Controls.Add(this.File2_dir_);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(625, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 189);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FILE";
            // 
            // file2_BT_wrt_
            // 
            this.file2_BT_wrt_.Location = new System.Drawing.Point(124, 144);
            this.file2_BT_wrt_.Name = "file2_BT_wrt_";
            this.file2_BT_wrt_.Size = new System.Drawing.Size(75, 23);
            this.file2_BT_wrt_.TabIndex = 8;
            this.file2_BT_wrt_.Text = "Ghi file";
            this.file2_BT_wrt_.UseVisualStyleBackColor = true;
            this.file2_BT_wrt_.Click += new System.EventHandler(this.file2_BT_wrt__Click);
            // 
            // file2_BT_read_
            // 
            this.file2_BT_read_.Location = new System.Drawing.Point(22, 144);
            this.file2_BT_read_.Name = "file2_BT_read_";
            this.file2_BT_read_.Size = new System.Drawing.Size(75, 23);
            this.file2_BT_read_.TabIndex = 4;
            this.file2_BT_read_.Text = "Đọc file";
            this.file2_BT_read_.UseVisualStyleBackColor = true;
            this.file2_BT_read_.Click += new System.EventHandler(this.file2_BT_read__Click);
            // 
            // File2_Box_Name_
            // 
            this.File2_Box_Name_.Location = new System.Drawing.Point(99, 88);
            this.File2_Box_Name_.Name = "File2_Box_Name_";
            this.File2_Box_Name_.Size = new System.Drawing.Size(100, 20);
            this.File2_Box_Name_.TabIndex = 3;
            this.File2_Box_Name_.Text = "TTT.txt";
            // 
            // File2_dir_
            // 
            this.File2_dir_.Location = new System.Drawing.Point(99, 27);
            this.File2_dir_.Name = "File2_dir_";
            this.File2_dir_.Size = new System.Drawing.Size(100, 20);
            this.File2_dir_.TabIndex = 2;
            this.File2_dir_.Text = "C:\\\\Users\\Admin\\Desktop\\";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đường dẫn file";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên file";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.zip_bt_comp_);
            this.groupBox4.Controls.Add(this.zip_bt_extr_);
            this.groupBox4.Controls.Add(this.Zip_Box_extr_);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Zip_Box_comp_);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(625, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 208);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ZIP";
            // 
            // zip_bt_comp_
            // 
            this.zip_bt_comp_.Location = new System.Drawing.Point(22, 151);
            this.zip_bt_comp_.Name = "zip_bt_comp_";
            this.zip_bt_comp_.Size = new System.Drawing.Size(75, 23);
            this.zip_bt_comp_.TabIndex = 7;
            this.zip_bt_comp_.Text = "Nén file";
            this.zip_bt_comp_.UseVisualStyleBackColor = true;
            this.zip_bt_comp_.Click += new System.EventHandler(this.zip_bt_comp__Click);
            // 
            // zip_bt_extr_
            // 
            this.zip_bt_extr_.Location = new System.Drawing.Point(124, 151);
            this.zip_bt_extr_.Name = "zip_bt_extr_";
            this.zip_bt_extr_.Size = new System.Drawing.Size(75, 23);
            this.zip_bt_extr_.TabIndex = 6;
            this.zip_bt_extr_.Text = "Giải nén file";
            this.zip_bt_extr_.UseVisualStyleBackColor = true;
            this.zip_bt_extr_.Click += new System.EventHandler(this.zip_bt_extr__Click);
            // 
            // Zip_Box_extr_
            // 
            this.Zip_Box_extr_.Location = new System.Drawing.Point(99, 105);
            this.Zip_Box_extr_.Name = "Zip_Box_extr_";
            this.Zip_Box_extr_.Size = new System.Drawing.Size(100, 20);
            this.Zip_Box_extr_.TabIndex = 5;
            this.Zip_Box_extr_.Text = "C:\\\\Users\\Admin\\Desktop\\WW";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Thư mục giải nén";
            // 
            // Zip_Box_comp_
            // 
            this.Zip_Box_comp_.Location = new System.Drawing.Point(99, 58);
            this.Zip_Box_comp_.Name = "Zip_Box_comp_";
            this.Zip_Box_comp_.Size = new System.Drawing.Size(100, 20);
            this.Zip_Box_comp_.TabIndex = 4;
            this.Zip_Box_comp_.Text = "C:\\\\Users\\Admin\\Desktop\\WW";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Thư mục nén";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "BẢNG GHI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 441);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_Box_);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "File_dir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.File1_numeric_)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Folder_Box_Disk_;
        private System.Windows.Forms.TextBox Folder_file_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Folder_BT_del_;
        private System.Windows.Forms.Button Folder_BT_create_;
        private System.Windows.Forms.Button Folder_BT_File_del_;
        private System.Windows.Forms.Button Folder_BT_check_;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button File1_BT_del_;
        private System.Windows.Forms.Button File1_BT_create_;
        private System.Windows.Forms.Button File1_BT_check_;
        private System.Windows.Forms.TextBox File1_Box_Name_;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox File1_Box_Del_;
        private System.Windows.Forms.RichTextBox txt_Box_;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button file2_BT_read_;
        private System.Windows.Forms.TextBox File2_Box_Name_;
        private System.Windows.Forms.TextBox File2_dir_;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button file2_BT_wrt_;
        private System.Windows.Forms.Button zip_bt_comp_;
        private System.Windows.Forms.Button zip_bt_extr_;
        private System.Windows.Forms.TextBox Zip_Box_extr_;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Zip_Box_comp_;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown File1_numeric_;
        private System.Windows.Forms.Label label11;
    }
}

