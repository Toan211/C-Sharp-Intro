namespace UControl
{
    partial class Add
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
            this.txt_Add_ = new System.Windows.Forms.TextBox();
            this.bt_Add_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Add_
            // 
            this.txt_Add_.Location = new System.Drawing.Point(76, 39);
            this.txt_Add_.Name = "txt_Add_";
            this.txt_Add_.Size = new System.Drawing.Size(155, 20);
            this.txt_Add_.TabIndex = 0;
            // 
            // bt_Add_
            // 
            this.bt_Add_.Location = new System.Drawing.Point(114, 98);
            this.bt_Add_.Name = "bt_Add_";
            this.bt_Add_.Size = new System.Drawing.Size(75, 23);
            this.bt_Add_.TabIndex = 1;
            this.bt_Add_.Text = "Add";
            this.bt_Add_.UseVisualStyleBackColor = true;
            this.bt_Add_.Click += new System.EventHandler(this.bt_Add__Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 177);
            this.Controls.Add(this.bt_Add_);
            this.Controls.Add(this.txt_Add_);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Add_;
        private System.Windows.Forms.Button bt_Add_;
    }
}