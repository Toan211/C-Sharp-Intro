namespace English_test_app
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Dir_ = new System.Windows.Forms.TextBox();
            this.txt_Name_ = new System.Windows.Forms.TextBox();
            this.bt_File_Read_ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_True_ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_False_ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Answer_ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(295, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(493, 413);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Dir_);
            this.groupBox1.Controls.Add(this.txt_Name_);
            this.groupBox1.Controls.Add(this.bt_File_Read_);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NHẬP ĐỀ";
            // 
            // txt_Dir_
            // 
            this.txt_Dir_.Location = new System.Drawing.Point(84, 19);
            this.txt_Dir_.Name = "txt_Dir_";
            this.txt_Dir_.Size = new System.Drawing.Size(149, 20);
            this.txt_Dir_.TabIndex = 11;
            this.txt_Dir_.Text = "C:\\\\Users\\Admin\\Desktop\\test";
            // 
            // txt_Name_
            // 
            this.txt_Name_.Location = new System.Drawing.Point(84, 57);
            this.txt_Name_.Name = "txt_Name_";
            this.txt_Name_.Size = new System.Drawing.Size(149, 20);
            this.txt_Name_.TabIndex = 10;
            this.txt_Name_.Text = "TracNghiem_01.txt";
            // 
            // bt_File_Read_
            // 
            this.bt_File_Read_.Location = new System.Drawing.Point(98, 88);
            this.bt_File_Read_.Name = "bt_File_Read_";
            this.bt_File_Read_.Size = new System.Drawing.Size(116, 23);
            this.bt_File_Read_.TabIndex = 6;
            this.bt_File_Read_.Text = "Đọc file";
            this.bt_File_Read_.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường dẫn file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên file";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_True_);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_False_);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bt_Answer_);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KẾT QUẢ";
            // 
            // txt_True_
            // 
            this.txt_True_.Location = new System.Drawing.Point(84, 22);
            this.txt_True_.Name = "txt_True_";
            this.txt_True_.Size = new System.Drawing.Size(149, 20);
            this.txt_True_.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số câu sai";
            // 
            // txt_False_
            // 
            this.txt_False_.Location = new System.Drawing.Point(84, 59);
            this.txt_False_.Name = "txt_False_";
            this.txt_False_.Size = new System.Drawing.Size(149, 20);
            this.txt_False_.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số câu đúng";
            // 
            // bt_Answer_
            // 
            this.bt_Answer_.Location = new System.Drawing.Point(98, 88);
            this.bt_Answer_.Name = "bt_Answer_";
            this.bt_Answer_.Size = new System.Drawing.Size(116, 23);
            this.bt_Answer_.TabIndex = 7;
            this.bt_Answer_.Text = "Xem đáp án";
            this.bt_Answer_.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BẢNG GHI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(277, 172);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Dir_;
        private System.Windows.Forms.TextBox txt_Name_;
        private System.Windows.Forms.Button bt_File_Read_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_True_;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_False_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Answer_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

