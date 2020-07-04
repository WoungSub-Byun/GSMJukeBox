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
            this.btnGoSongRegisterForm = new MetroFramework.Controls.MetroButton();
            this.btnGoSettingForm = new MetroFramework.Controls.MetroButton();
            this.btnGoRegisterForm = new MetroFramework.Controls.MetroButton();
            this.btnGoLoginForm = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnGoSongRegisterForm
            // 
            this.btnGoSongRegisterForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGoSongRegisterForm.Location = new System.Drawing.Point(445, 186);
            this.btnGoSongRegisterForm.Name = "btnGoSongRegisterForm";
            this.btnGoSongRegisterForm.Size = new System.Drawing.Size(93, 90);
            this.btnGoSongRegisterForm.TabIndex = 0;
            this.btnGoSongRegisterForm.Text = "노래 신청";
            this.btnGoSongRegisterForm.UseSelectable = true;
            this.btnGoSongRegisterForm.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnGoSettingForm
            // 
            this.btnGoSettingForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGoSettingForm.Location = new System.Drawing.Point(219, 186);
            this.btnGoSettingForm.Name = "btnGoSettingForm";
            this.btnGoSettingForm.Size = new System.Drawing.Size(93, 90);
            this.btnGoSettingForm.TabIndex = 1;
            this.btnGoSettingForm.Text = "예약 시간 설정";
            this.btnGoSettingForm.UseSelectable = true;
            // 
            // btnGoRegisterForm
            // 
            this.btnGoRegisterForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGoRegisterForm.Location = new System.Drawing.Point(637, 378);
            this.btnGoRegisterForm.Name = "btnGoRegisterForm";
            this.btnGoRegisterForm.Size = new System.Drawing.Size(78, 29);
            this.btnGoRegisterForm.TabIndex = 2;
            this.btnGoRegisterForm.Text = "회원가입";
            this.btnGoRegisterForm.UseSelectable = true;
            // 
            // btnGoLoginForm
            // 
            this.btnGoLoginForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGoLoginForm.Location = new System.Drawing.Point(536, 378);
            this.btnGoLoginForm.Name = "btnGoLoginForm";
            this.btnGoLoginForm.Size = new System.Drawing.Size(71, 29);
            this.btnGoLoginForm.TabIndex = 3;
            this.btnGoLoginForm.Text = "로그인";
            this.btnGoLoginForm.UseSelectable = true;
            // 
            // GSMJukeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 430);
            this.Controls.Add(this.btnGoLoginForm);
            this.Controls.Add(this.btnGoRegisterForm);
            this.Controls.Add(this.btnGoSettingForm);
            this.Controls.Add(this.btnGoSongRegisterForm);
            this.Name = "GSMJukeBox";
            this.Text = "GSMJukeBox";
            this.Load += new System.EventHandler(this.GSMJukeBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGoSongRegisterForm;
        private MetroFramework.Controls.MetroButton btnGoSettingForm;
        private MetroFramework.Controls.MetroButton btnGoRegisterForm;
        private MetroFramework.Controls.MetroButton btnGoLoginForm;
    }
}