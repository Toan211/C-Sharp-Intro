namespace paintBasic
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_color = new System.Windows.Forms.Button();
            this.radio_btn_line = new System.Windows.Forms.RadioButton();
            this.radio_btn_hcn = new System.Windows.Forms.RadioButton();
            this.radio_btn_elipse = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_img = new System.Windows.Forms.Button();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_del = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_color);
            this.groupBox2.Controls.Add(this.radio_btn_line);
            this.groupBox2.Controls.Add(this.radio_btn_hcn);
            this.groupBox2.Controls.Add(this.radio_btn_elipse);
            this.groupBox2.Location = new System.Drawing.Point(609, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 231);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình vẽ";
            // 
            // bt_color
            // 
            this.bt_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_color.ForeColor = System.Drawing.Color.White;
            this.bt_color.Location = new System.Drawing.Point(17, 153);
            this.bt_color.Name = "bt_color";
            this.bt_color.Size = new System.Drawing.Size(151, 38);
            this.bt_color.TabIndex = 5;
            this.bt_color.Text = "Màu vẽ";
            this.bt_color.UseVisualStyleBackColor = false;
            this.bt_color.Click += new System.EventHandler(this.bt_color_Click);
            // 
            // radio_btn_line
            // 
            this.radio_btn_line.AutoSize = true;
            this.radio_btn_line.Checked = true;
            this.radio_btn_line.Location = new System.Drawing.Point(21, 19);
            this.radio_btn_line.Name = "radio_btn_line";
            this.radio_btn_line.Size = new System.Drawing.Size(101, 17);
            this.radio_btn_line.TabIndex = 2;
            this.radio_btn_line.TabStop = true;
            this.radio_btn_line.Text = "vẽ đường thẳng";
            this.radio_btn_line.UseVisualStyleBackColor = true;
            // 
            // radio_btn_hcn
            // 
            this.radio_btn_hcn.AutoSize = true;
            this.radio_btn_hcn.Location = new System.Drawing.Point(21, 53);
            this.radio_btn_hcn.Name = "radio_btn_hcn";
            this.radio_btn_hcn.Size = new System.Drawing.Size(105, 17);
            this.radio_btn_hcn.TabIndex = 3;
            this.radio_btn_hcn.Text = "vẽ hình chữ nhật";
            this.radio_btn_hcn.UseVisualStyleBackColor = true;
            // 
            // radio_btn_elipse
            // 
            this.radio_btn_elipse.AutoSize = true;
            this.radio_btn_elipse.Location = new System.Drawing.Point(21, 88);
            this.radio_btn_elipse.Name = "radio_btn_elipse";
            this.radio_btn_elipse.Size = new System.Drawing.Size(90, 17);
            this.radio_btn_elipse.TabIndex = 4;
            this.radio_btn_elipse.Text = "vẽ hình elipse";
            this.radio_btn_elipse.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_img);
            this.groupBox3.Controls.Add(this.txt_y);
            this.groupBox3.Controls.Add(this.txt_x);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(609, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 118);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ảnh";
            // 
            // bt_img
            // 
            this.bt_img.Location = new System.Drawing.Point(22, 74);
            this.bt_img.Name = "bt_img";
            this.bt_img.Size = new System.Drawing.Size(151, 38);
            this.bt_img.TabIndex = 7;
            this.bt_img.Text = "Chèn hình";
            this.bt_img.UseVisualStyleBackColor = true;
            this.bt_img.Click += new System.EventHandler(this.bt_img_Click);
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(100, 50);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(68, 20);
            this.txt_y.TabIndex = 10;
            this.txt_y.Text = "100";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(100, 24);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(68, 20);
            this.txt_x.TabIndex = 9;
            this.txt_x.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vị trí x, y";
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(626, 250);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(151, 38);
            this.bt_del.TabIndex = 6;
            this.bt_del.Text = "Xóa";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "BasicPaint";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_color;
        private System.Windows.Forms.RadioButton radio_btn_line;
        private System.Windows.Forms.RadioButton radio_btn_hcn;
        private System.Windows.Forms.RadioButton radio_btn_elipse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_img;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_del;
    }
}

