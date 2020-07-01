namespace GSMJukeBox
{
    partial class GSMJukeBox
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
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.btnSet = new MetroFramework.Controls.MetroButton();
            this.btnGoLoginForm = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRegister.Location = new System.Drawing.Point(485, 186);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 90);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "노래 신청";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSet
            // 
            this.btnSet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSet.Location = new System.Drawing.Point(239, 186);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(93, 90);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "예약 시간 설정";
            this.btnSet.UseSelectable = true;
            // 
            // btnGoLoginForm
            // 
            this.btnGoLoginForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGoLoginForm.Location = new System.Drawing.Point(637, 378);
            this.btnGoLoginForm.Name = "btnGoLoginForm";
            this.btnGoLoginForm.Size = new System.Drawing.Size(78, 29);
            this.btnGoLoginForm.TabIndex = 2;
            this.btnGoLoginForm.Text = "회원가입";
            this.btnGoLoginForm.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metroButton1.Location = new System.Drawing.Point(536, 378);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(71, 29);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "로그인";
            this.metroButton1.UseSelectable = true;
            // 
            // GSMJukeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 430);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnGoLoginForm);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnRegister);
            this.Name = "GSMJukeBox";
            this.Text = "GSMJukeBox";
            this.Load += new System.EventHandler(this.GSMJukeBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroButton btnSet;
        private MetroFramework.Controls.MetroButton btnGoLoginForm;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}