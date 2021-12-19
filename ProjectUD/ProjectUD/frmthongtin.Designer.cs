namespace ProjectUD
{
    partial class frmthongtin
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.btndoimatkhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(229, 37);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(41, 13);
            this.lbuser.TabIndex = 1;
            this.lbuser.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Location = new System.Drawing.Point(229, 63);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(41, 13);
            this.lbpassword.TabIndex = 3;
            this.lbpassword.Text = "label4";
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.Location = new System.Drawing.Point(140, 101);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(168, 23);
            this.btndoimatkhau.TabIndex = 4;
            this.btndoimatkhau.Text = "Change PassWord";
            this.btndoimatkhau.UseVisualStyleBackColor = true;
            this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
            // 
            // frmthongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 142);
            this.Controls.Add(this.btndoimatkhau);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmthongtin";
            this.Text = "frmthongtin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmthongtin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Button btndoimatkhau;
    }
}