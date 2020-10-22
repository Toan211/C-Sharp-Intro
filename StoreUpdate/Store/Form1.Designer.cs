namespace Store
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dt_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Top = new System.Windows.Forms.Button();
            this.bt_Yao = new System.Windows.Forms.Button();
            this.bt_Soda = new System.Windows.Forms.Button();
            this.bt_TraSua = new System.Windows.Forms.Button();
            this.bt_Tra = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_tra_sua = new System.Windows.Forms.Panel();
            this.bt2_10 = new System.Windows.Forms.Button();
            this.bt2_8 = new System.Windows.Forms.Button();
            this.bt2_6 = new System.Windows.Forms.Button();
            this.bt2_4 = new System.Windows.Forms.Button();
            this.bt2_2 = new System.Windows.Forms.Button();
            this.bt2_9 = new System.Windows.Forms.Button();
            this.bt2_7 = new System.Windows.Forms.Button();
            this.bt2_5 = new System.Windows.Forms.Button();
            this.bt2_3 = new System.Windows.Forms.Button();
            this.bt2_1 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt10 = new System.Windows.Forms.Button();
            this.panel_tra = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_tra_sua.SuspendLayout();
            this.panel_tra.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(146, 369);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(250, 25);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "10";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(146, 327);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 25);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(146, 410);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(250, 25);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng cộng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá hàng: %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền hàng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dt_name,
            this.dt_count,
            this.dt_Money,
            this.dt_Total});
            this.dataGridView1.Location = new System.Drawing.Point(6, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // dt_name
            // 
            this.dt_name.HeaderText = "Tên Món Nước";
            this.dt_name.Name = "dt_name";
            // 
            // dt_count
            // 
            this.dt_count.HeaderText = "Số lượng";
            this.dt_count.Name = "dt_count";
            // 
            // dt_Money
            // 
            this.dt_Money.HeaderText = "Đơn Giá";
            this.dt_Money.Name = "dt_Money";
            // 
            // dt_Total
            // 
            this.dt_Total.HeaderText = "Thành tiền";
            this.dt_Total.Name = "dt_Total";
            // 
            // bt_Top
            // 
            this.bt_Top.BackColor = System.Drawing.Color.LightGreen;
            this.bt_Top.Enabled = false;
            this.bt_Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Top.Location = new System.Drawing.Point(3, 386);
            this.bt_Top.Name = "bt_Top";
            this.bt_Top.Size = new System.Drawing.Size(166, 68);
            this.bt_Top.TabIndex = 4;
            this.bt_Top.Text = "Topping";
            this.bt_Top.UseVisualStyleBackColor = false;
            // 
            // bt_Yao
            // 
            this.bt_Yao.BackColor = System.Drawing.Color.LightGreen;
            this.bt_Yao.Enabled = false;
            this.bt_Yao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Yao.Location = new System.Drawing.Point(3, 237);
            this.bt_Yao.Name = "bt_Yao";
            this.bt_Yao.Size = new System.Drawing.Size(166, 68);
            this.bt_Yao.TabIndex = 3;
            this.bt_Yao.Text = "Yaourt";
            this.bt_Yao.UseVisualStyleBackColor = false;
            // 
            // bt_Soda
            // 
            this.bt_Soda.BackColor = System.Drawing.Color.LightGreen;
            this.bt_Soda.Enabled = false;
            this.bt_Soda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Soda.Location = new System.Drawing.Point(3, 163);
            this.bt_Soda.Name = "bt_Soda";
            this.bt_Soda.Size = new System.Drawing.Size(166, 68);
            this.bt_Soda.TabIndex = 2;
            this.bt_Soda.Text = "Soda";
            this.bt_Soda.UseVisualStyleBackColor = false;
            // 
            // bt_TraSua
            // 
            this.bt_TraSua.BackColor = System.Drawing.Color.LightGreen;
            this.bt_TraSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TraSua.Location = new System.Drawing.Point(3, 89);
            this.bt_TraSua.Name = "bt_TraSua";
            this.bt_TraSua.Size = new System.Drawing.Size(166, 68);
            this.bt_TraSua.TabIndex = 1;
            this.bt_TraSua.Text = "Trà sữa";
            this.bt_TraSua.UseVisualStyleBackColor = false;
            this.bt_TraSua.Click += new System.EventHandler(this.button_TraSua);
            // 
            // bt_Tra
            // 
            this.bt_Tra.BackColor = System.Drawing.Color.LightGreen;
            this.bt_Tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Tra.Location = new System.Drawing.Point(3, 15);
            this.bt_Tra.Name = "bt_Tra";
            this.bt_Tra.Size = new System.Drawing.Size(166, 68);
            this.bt_Tra.TabIndex = 0;
            this.bt_Tra.Text = "Trà / Hồng trà";
            this.bt_Tra.UseVisualStyleBackColor = false;
            this.bt_Tra.Click += new System.EventHandler(this.button_Tra);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_Top);
            this.panel2.Controls.Add(this.bt_Tra);
            this.panel2.Controls.Add(this.bt_TraSua);
            this.panel2.Controls.Add(this.bt_Yao);
            this.panel2.Controls.Add(this.bt_Soda);
            this.panel2.Location = new System.Drawing.Point(417, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 459);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.richTextBox3);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 459);
            this.panel3.TabIndex = 9;
            // 
            // panel_tra_sua
            // 
            this.panel_tra_sua.Controls.Add(this.bt2_10);
            this.panel_tra_sua.Controls.Add(this.bt2_8);
            this.panel_tra_sua.Controls.Add(this.bt2_6);
            this.panel_tra_sua.Controls.Add(this.bt2_4);
            this.panel_tra_sua.Controls.Add(this.bt2_2);
            this.panel_tra_sua.Controls.Add(this.bt2_9);
            this.panel_tra_sua.Controls.Add(this.bt2_7);
            this.panel_tra_sua.Controls.Add(this.bt2_5);
            this.panel_tra_sua.Controls.Add(this.bt2_3);
            this.panel_tra_sua.Controls.Add(this.bt2_1);
            this.panel_tra_sua.Location = new System.Drawing.Point(595, 13);
            this.panel_tra_sua.Name = "panel_tra_sua";
            this.panel_tra_sua.Size = new System.Drawing.Size(382, 459);
            this.panel_tra_sua.TabIndex = 19;
            this.panel_tra_sua.Visible = false;
            // 
            // bt2_10
            // 
            this.bt2_10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_10.Location = new System.Drawing.Point(193, 310);
            this.bt2_10.Name = "bt2_10";
            this.bt2_10.Size = new System.Drawing.Size(184, 68);
            this.bt2_10.TabIndex = 16;
            this.bt2_10.Text = "Trà sữa cherry";
            this.bt2_10.UseVisualStyleBackColor = false;
            this.bt2_10.Click += new System.EventHandler(this.bt2_10_Click);
            // 
            // bt2_8
            // 
            this.bt2_8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_8.Location = new System.Drawing.Point(193, 236);
            this.bt2_8.Name = "bt2_8";
            this.bt2_8.Size = new System.Drawing.Size(184, 68);
            this.bt2_8.TabIndex = 14;
            this.bt2_8.Text = "Trà sữa kiwi";
            this.bt2_8.UseVisualStyleBackColor = false;
            this.bt2_8.Click += new System.EventHandler(this.bt2_8_Click);
            // 
            // bt2_6
            // 
            this.bt2_6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_6.Location = new System.Drawing.Point(193, 162);
            this.bt2_6.Name = "bt2_6";
            this.bt2_6.Size = new System.Drawing.Size(184, 68);
            this.bt2_6.TabIndex = 13;
            this.bt2_6.Text = "Trà sữa đào";
            this.bt2_6.UseVisualStyleBackColor = false;
            this.bt2_6.Click += new System.EventHandler(this.bt2_6_Click);
            // 
            // bt2_4
            // 
            this.bt2_4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_4.Location = new System.Drawing.Point(193, 88);
            this.bt2_4.Name = "bt2_4";
            this.bt2_4.Size = new System.Drawing.Size(184, 68);
            this.bt2_4.TabIndex = 12;
            this.bt2_4.Text = "trà sữa dâu";
            this.bt2_4.UseVisualStyleBackColor = false;
            this.bt2_4.Click += new System.EventHandler(this.bt2_4_Click);
            // 
            // bt2_2
            // 
            this.bt2_2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_2.Location = new System.Drawing.Point(193, 14);
            this.bt2_2.Name = "bt2_2";
            this.bt2_2.Size = new System.Drawing.Size(184, 68);
            this.bt2_2.TabIndex = 11;
            this.bt2_2.Text = "Trà sưa Socola";
            this.bt2_2.UseVisualStyleBackColor = false;
            this.bt2_2.Click += new System.EventHandler(this.bt2_2_Click);
            // 
            // bt2_9
            // 
            this.bt2_9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_9.Location = new System.Drawing.Point(3, 310);
            this.bt2_9.Name = "bt2_9";
            this.bt2_9.Size = new System.Drawing.Size(184, 68);
            this.bt2_9.TabIndex = 10;
            this.bt2_9.Text = "Trà sữa thái đỏ";
            this.bt2_9.UseVisualStyleBackColor = false;
            this.bt2_9.Click += new System.EventHandler(this.bt2_9_Click);
            // 
            // bt2_7
            // 
            this.bt2_7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_7.Location = new System.Drawing.Point(3, 236);
            this.bt2_7.Name = "bt2_7";
            this.bt2_7.Size = new System.Drawing.Size(184, 68);
            this.bt2_7.TabIndex = 8;
            this.bt2_7.Text = "Trà sữa thái xanh";
            this.bt2_7.UseVisualStyleBackColor = false;
            this.bt2_7.Click += new System.EventHandler(this.bt2_7_Click);
            // 
            // bt2_5
            // 
            this.bt2_5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_5.Location = new System.Drawing.Point(3, 162);
            this.bt2_5.Name = "bt2_5";
            this.bt2_5.Size = new System.Drawing.Size(184, 68);
            this.bt2_5.TabIndex = 7;
            this.bt2_5.Text = "Trà sữa bạc hà";
            this.bt2_5.UseVisualStyleBackColor = false;
            this.bt2_5.Click += new System.EventHandler(this.bt2_5_Click);
            // 
            // bt2_3
            // 
            this.bt2_3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_3.Location = new System.Drawing.Point(3, 88);
            this.bt2_3.Name = "bt2_3";
            this.bt2_3.Size = new System.Drawing.Size(184, 68);
            this.bt2_3.TabIndex = 6;
            this.bt2_3.Text = "Trà sữa";
            this.bt2_3.UseVisualStyleBackColor = false;
            this.bt2_3.Click += new System.EventHandler(this.bt2_3_Click);
            // 
            // bt2_1
            // 
            this.bt2_1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2_1.Location = new System.Drawing.Point(3, 14);
            this.bt2_1.Name = "bt2_1";
            this.bt2_1.Size = new System.Drawing.Size(184, 68);
            this.bt2_1.TabIndex = 5;
            this.bt2_1.Text = "Trà sữa việt quất";
            this.bt2_1.UseVisualStyleBackColor = false;
            this.bt2_1.Click += new System.EventHandler(this.bt2_1_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(3, 14);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(184, 68);
            this.bt1.TabIndex = 5;
            this.bt1.Text = "Trà xanh";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(3, 88);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(184, 68);
            this.bt3.TabIndex = 6;
            this.bt3.Text = "Trà trái cây";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(3, 162);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(184, 68);
            this.bt5.TabIndex = 7;
            this.bt5.Text = "Trà hoa hồng";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(3, 236);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(184, 68);
            this.bt7.TabIndex = 8;
            this.bt7.Text = "Trà lá ";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(3, 310);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(184, 68);
            this.bt9.TabIndex = 10;
            this.bt9.Text = "Trà ô lông";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(193, 14);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(184, 68);
            this.bt2.TabIndex = 11;
            this.bt2.Text = "Trà thảo dược";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(193, 88);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(184, 68);
            this.bt4.TabIndex = 12;
            this.bt4.Text = "Trà bạc hà";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(193, 162);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(184, 68);
            this.bt6.TabIndex = 13;
            this.bt6.Text = "Trà oải hương ";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(193, 236);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(184, 68);
            this.bt8.TabIndex = 14;
            this.bt8.Text = "Trà Matcha";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt10
            // 
            this.bt10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt10.Location = new System.Drawing.Point(193, 310);
            this.bt10.Name = "bt10";
            this.bt10.Size = new System.Drawing.Size(184, 68);
            this.bt10.TabIndex = 16;
            this.bt10.Text = "Trà táo đỏ";
            this.bt10.UseVisualStyleBackColor = false;
            this.bt10.Click += new System.EventHandler(this.bt10_Click);
            // 
            // panel_tra
            // 
            this.panel_tra.Controls.Add(this.bt10);
            this.panel_tra.Controls.Add(this.bt8);
            this.panel_tra.Controls.Add(this.bt6);
            this.panel_tra.Controls.Add(this.bt4);
            this.panel_tra.Controls.Add(this.bt2);
            this.panel_tra.Controls.Add(this.bt9);
            this.panel_tra.Controls.Add(this.bt7);
            this.panel_tra.Controls.Add(this.bt5);
            this.panel_tra.Controls.Add(this.bt3);
            this.panel_tra.Controls.Add(this.bt1);
            this.panel_tra.Location = new System.Drawing.Point(595, 13);
            this.panel_tra.Name = "panel_tra";
            this.panel_tra.Size = new System.Drawing.Size(382, 459);
            this.panel_tra.TabIndex = 17;
            this.panel_tra.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 494);
            this.Controls.Add(this.panel_tra_sua);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_tra);
            this.Name = "Form1";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_tra_sua.ResumeLayout(false);
            this.panel_tra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Top;
        private System.Windows.Forms.Button bt_Yao;
        private System.Windows.Forms.Button bt_Soda;
        private System.Windows.Forms.Button bt_TraSua;
        private System.Windows.Forms.Button bt_Tra;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt10;
        private System.Windows.Forms.Panel panel_tra_sua;
        private System.Windows.Forms.Button bt2_10;
        private System.Windows.Forms.Button bt2_8;
        private System.Windows.Forms.Button bt2_6;
        private System.Windows.Forms.Button bt2_4;
        private System.Windows.Forms.Button bt2_2;
        private System.Windows.Forms.Button bt2_9;
        private System.Windows.Forms.Button bt2_7;
        private System.Windows.Forms.Button bt2_5;
        private System.Windows.Forms.Button bt2_3;
        private System.Windows.Forms.Button bt2_1;
        private System.Windows.Forms.Panel panel_tra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Total;
    }
}

