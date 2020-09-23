namespace Hotel_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LB_MP = new System.Windows.Forms.Label();
            this.LB_LP = new System.Windows.Forms.Label();
            this.LB_GP = new System.Windows.Forms.Label();
            this.LB_TTP = new System.Windows.Forms.Label();
            this.LB_Day = new System.Windows.Forms.Label();
            this.TB_MP = new System.Windows.Forms.TextBox();
            this.TB_GP = new System.Windows.Forms.TextBox();
            this.TB_Day = new System.Windows.Forms.TextBox();
            this.BT_TP = new System.Windows.Forms.Button();
            this.BT_DP = new System.Windows.Forms.Button();
            this.BT_HP = new System.Windows.Forms.Button();
            this.BT_TT = new System.Windows.Forms.Button();
            this.CB_LP = new System.Windows.Forms.ComboBox();
            this.CB_TTP = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma_Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai_Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT_Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(271, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 132);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // LB_MP
            // 
            this.LB_MP.AutoSize = true;
            this.LB_MP.Location = new System.Drawing.Point(150, 163);
            this.LB_MP.Name = "LB_MP";
            this.LB_MP.Size = new System.Drawing.Size(56, 13);
            this.LB_MP.TabIndex = 2;
            this.LB_MP.Text = "Mã Phòng";
            // 
            // LB_LP
            // 
            this.LB_LP.AutoSize = true;
            this.LB_LP.Location = new System.Drawing.Point(150, 196);
            this.LB_LP.Name = "LB_LP";
            this.LB_LP.Size = new System.Drawing.Size(61, 13);
            this.LB_LP.TabIndex = 3;
            this.LB_LP.Text = "Loại Phòng";
            // 
            // LB_GP
            // 
            this.LB_GP.AutoSize = true;
            this.LB_GP.Location = new System.Drawing.Point(150, 234);
            this.LB_GP.Name = "LB_GP";
            this.LB_GP.Size = new System.Drawing.Size(57, 13);
            this.LB_GP.TabIndex = 4;
            this.LB_GP.Text = "Giá Phòng";
            // 
            // LB_TTP
            // 
            this.LB_TTP.AutoSize = true;
            this.LB_TTP.Location = new System.Drawing.Point(150, 267);
            this.LB_TTP.Name = "LB_TTP";
            this.LB_TTP.Size = new System.Drawing.Size(93, 13);
            this.LB_TTP.TabIndex = 5;
            this.LB_TTP.Text = "Tình Trạng Phòng";
            // 
            // LB_Day
            // 
            this.LB_Day.AutoSize = true;
            this.LB_Day.Location = new System.Drawing.Point(150, 302);
            this.LB_Day.Name = "LB_Day";
            this.LB_Day.Size = new System.Drawing.Size(57, 13);
            this.LB_Day.TabIndex = 6;
            this.LB_Day.Text = "Số Ngày ở";
            // 
            // TB_MP
            // 
            this.TB_MP.Location = new System.Drawing.Point(271, 160);
            this.TB_MP.Name = "TB_MP";
            this.TB_MP.Size = new System.Drawing.Size(236, 20);
            this.TB_MP.TabIndex = 7;
            // 
            // TB_GP
            // 
            this.TB_GP.Location = new System.Drawing.Point(271, 232);
            this.TB_GP.Name = "TB_GP";
            this.TB_GP.Size = new System.Drawing.Size(236, 20);
            this.TB_GP.TabIndex = 9;
            // 
            // TB_Day
            // 
            this.TB_Day.Location = new System.Drawing.Point(271, 300);
            this.TB_Day.Name = "TB_Day";
            this.TB_Day.Size = new System.Drawing.Size(236, 20);
            this.TB_Day.TabIndex = 11;
            // 
            // BT_TP
            // 
            this.BT_TP.Location = new System.Drawing.Point(562, 160);
            this.BT_TP.Name = "BT_TP";
            this.BT_TP.Size = new System.Drawing.Size(106, 29);
            this.BT_TP.TabIndex = 12;
            this.BT_TP.Text = "Thêm Phòng";
            this.BT_TP.UseVisualStyleBackColor = true;
            this.BT_TP.Click += new System.EventHandler(this.BT_TP_Click);
            // 
            // BT_DP
            // 
            this.BT_DP.Location = new System.Drawing.Point(562, 206);
            this.BT_DP.Name = "BT_DP";
            this.BT_DP.Size = new System.Drawing.Size(106, 28);
            this.BT_DP.TabIndex = 13;
            this.BT_DP.Text = "Đặt Phòng";
            this.BT_DP.UseVisualStyleBackColor = true;
            this.BT_DP.Click += new System.EventHandler(this.BT_DP_Click);
            // 
            // BT_HP
            // 
            this.BT_HP.Location = new System.Drawing.Point(562, 252);
            this.BT_HP.Name = "BT_HP";
            this.BT_HP.Size = new System.Drawing.Size(106, 28);
            this.BT_HP.TabIndex = 14;
            this.BT_HP.Text = "Hủy Phòng";
            this.BT_HP.UseVisualStyleBackColor = true;
            this.BT_HP.Click += new System.EventHandler(this.BT_HP_Click);
            // 
            // BT_TT
            // 
            this.BT_TT.Location = new System.Drawing.Point(562, 293);
            this.BT_TT.Name = "BT_TT";
            this.BT_TT.Size = new System.Drawing.Size(106, 27);
            this.BT_TT.TabIndex = 15;
            this.BT_TT.Text = "Thanh toán";
            this.BT_TT.UseVisualStyleBackColor = true;
            this.BT_TT.Click += new System.EventHandler(this.BT_TT_Click);
            // 
            // CB_LP
            // 
            this.CB_LP.FormattingEnabled = true;
            this.CB_LP.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CB_LP.Location = new System.Drawing.Point(271, 193);
            this.CB_LP.Name = "CB_LP";
            this.CB_LP.Size = new System.Drawing.Size(236, 21);
            this.CB_LP.TabIndex = 16;
            this.CB_LP.Text = "A";
            // 
            // CB_TTP
            // 
            this.CB_TTP.FormattingEnabled = true;
            this.CB_TTP.Items.AddRange(new object[] {
            "Trống",
            "Không Trống"});
            this.CB_TTP.Location = new System.Drawing.Point(271, 265);
            this.CB_TTP.Name = "CB_TTP";
            this.CB_TTP.Size = new System.Drawing.Size(236, 21);
            this.CB_TTP.TabIndex = 17;
            this.CB_TTP.Text = "Trống";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Phong,
            this.Loai_Phong,
            this.Gia_Phong,
            this.TT_Phong,
            this.So_Ngay});
            this.dataGridView1.Location = new System.Drawing.Point(52, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 117);
            this.dataGridView1.TabIndex = 18;
            // 
            // Ma_Phong
            // 
            this.Ma_Phong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_Phong.HeaderText = "Ma_Phong";
            this.Ma_Phong.Name = "Ma_Phong";
            // 
            // Loai_Phong
            // 
            this.Loai_Phong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Loai_Phong.HeaderText = "Loai_Phong";
            this.Loai_Phong.Name = "Loai_Phong";
            // 
            // Gia_Phong
            // 
            this.Gia_Phong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia_Phong.HeaderText = "Gia_Phong";
            this.Gia_Phong.Name = "Gia_Phong";
            // 
            // TT_Phong
            // 
            this.TT_Phong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TT_Phong.HeaderText = "TT_Phong";
            this.TT_Phong.Name = "TT_Phong";
            // 
            // So_Ngay
            // 
            this.So_Ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.So_Ngay.HeaderText = "So_Ngay";
            this.So_Ngay.Name = "So_Ngay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CB_TTP);
            this.Controls.Add(this.CB_LP);
            this.Controls.Add(this.BT_TT);
            this.Controls.Add(this.BT_HP);
            this.Controls.Add(this.BT_DP);
            this.Controls.Add(this.BT_TP);
            this.Controls.Add(this.TB_Day);
            this.Controls.Add(this.TB_GP);
            this.Controls.Add(this.TB_MP);
            this.Controls.Add(this.LB_Day);
            this.Controls.Add(this.LB_TTP);
            this.Controls.Add(this.LB_GP);
            this.Controls.Add(this.LB_LP);
            this.Controls.Add(this.LB_MP);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LB_MP;
        private System.Windows.Forms.Label LB_LP;
        private System.Windows.Forms.Label LB_GP;
        private System.Windows.Forms.Label LB_TTP;
        private System.Windows.Forms.Label LB_Day;
        private System.Windows.Forms.TextBox TB_MP;
        private System.Windows.Forms.TextBox TB_GP;
        private System.Windows.Forms.TextBox TB_Day;
        private System.Windows.Forms.Button BT_TP;
        private System.Windows.Forms.Button BT_DP;
        private System.Windows.Forms.Button BT_HP;
        private System.Windows.Forms.Button BT_TT;
        private System.Windows.Forms.ComboBox CB_LP;
        private System.Windows.Forms.ComboBox CB_TTP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Ngay;
    }
}

