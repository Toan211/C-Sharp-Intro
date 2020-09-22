namespace grabCal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TBox_Dista = new System.Windows.Forms.TextBox();
            this.TBox_Disc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_KM = new System.Windows.Forms.Label();
            this.LB_DISC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_price = new System.Windows.Forms.Label();
            this.TBox_Money = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Calculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TBox_Dista
            // 
            this.TBox_Dista.Location = new System.Drawing.Point(329, 202);
            this.TBox_Dista.Name = "TBox_Dista";
            this.TBox_Dista.Size = new System.Drawing.Size(98, 20);
            this.TBox_Dista.TabIndex = 0;
            // 
            // TBox_Disc
            // 
            this.TBox_Disc.Location = new System.Drawing.Point(329, 252);
            this.TBox_Disc.Name = "TBox_Disc";
            this.TBox_Disc.ReadOnly = true;
            this.TBox_Disc.Size = new System.Drawing.Size(97, 20);
            this.TBox_Disc.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(329, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 153);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LB_KM
            // 
            this.LB_KM.AutoSize = true;
            this.LB_KM.Location = new System.Drawing.Point(157, 205);
            this.LB_KM.Name = "LB_KM";
            this.LB_KM.Size = new System.Drawing.Size(87, 13);
            this.LB_KM.TabIndex = 3;
            this.LB_KM.Text = "Số km hành trình";
            // 
            // LB_DISC
            // 
            this.LB_DISC.AutoSize = true;
            this.LB_DISC.Location = new System.Drawing.Point(157, 257);
            this.LB_DISC.Name = "LB_DISC";
            this.LB_DISC.Size = new System.Drawing.Size(62, 13);
            this.LB_DISC.TabIndex = 4;
            this.LB_DISC.Text = "Khuyến mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "%";
            // 
            // LB_price
            // 
            this.LB_price.AutoSize = true;
            this.LB_price.Location = new System.Drawing.Point(157, 302);
            this.LB_price.Name = "LB_price";
            this.LB_price.Size = new System.Drawing.Size(58, 13);
            this.LB_price.TabIndex = 7;
            this.LB_price.Text = "Thành tiền";
            // 
            // TBox_Money
            // 
            this.TBox_Money.Location = new System.Drawing.Point(331, 299);
            this.TBox_Money.Name = "TBox_Money";
            this.TBox_Money.ReadOnly = true;
            this.TBox_Money.Size = new System.Drawing.Size(95, 20);
            this.TBox_Money.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(568, 257);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(76, 64);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "ThanhTien";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculator_button);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "VND";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.TBox_Money);
            this.Controls.Add(this.LB_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_DISC);
            this.Controls.Add(this.LB_KM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBox_Disc);
            this.Controls.Add(this.TBox_Dista);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Grab_calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox TBox_Dista;
        private System.Windows.Forms.TextBox TBox_Disc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_KM;
        private System.Windows.Forms.Label LB_DISC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_price;
        private System.Windows.Forms.TextBox TBox_Money;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label6;
    }
}

