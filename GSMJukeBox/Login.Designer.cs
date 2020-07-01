namespace GSMJukeBox
{
    partial class Login
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
            this.idlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.TextBoxId = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(83, 102);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(41, 12);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(309, 89);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(70, 70);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "로그인";
            this.metroButton1.UseSelectable = true;
            // 
            // TextBoxId
            // 
            // 
            // 
            // 
            this.TextBoxId.CustomButton.Image = null;
            this.TextBoxId.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.TextBoxId.CustomButton.Name = "";
            this.TextBoxId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxId.CustomButton.TabIndex = 1;
            this.TextBoxId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxId.CustomButton.UseSelectable = true;
            this.TextBoxId.CustomButton.Visible = false;
            this.TextBoxId.Lines = new string[] {
        "id를 입력하세요"};
            this.TextBoxId.Location = new System.Drawing.Point(151, 99);
            this.TextBoxId.MaxLength = 32767;
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.PasswordChar = '\0';
            this.TextBoxId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxId.SelectedText = "";
            this.TextBoxId.SelectionLength = 0;
            this.TextBoxId.SelectionStart = 0;
            this.TextBoxId.ShortcutsEnabled = true;
            this.TextBoxId.Size = new System.Drawing.Size(136, 23);
            this.TextBoxId.TabIndex = 3;
            this.TextBoxId.Text = "id를 입력하세요";
            this.TextBoxId.UseSelectable = true;
            this.TextBoxId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxPassword
            // 
            // 
            // 
            // 
            this.TextBoxPassword.CustomButton.Image = null;
            this.TextBoxPassword.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.TextBoxPassword.CustomButton.Name = "";
            this.TextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxPassword.CustomButton.TabIndex = 1;
            this.TextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxPassword.CustomButton.UseSelectable = true;
            this.TextBoxPassword.CustomButton.Visible = false;
            this.TextBoxPassword.Lines = new string[] {
        "비밀번호를 입력하세요"};
            this.TextBoxPassword.Location = new System.Drawing.Point(151, 136);
            this.TextBoxPassword.MaxLength = 32767;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '\0';
            this.TextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.SelectionLength = 0;
            this.TextBoxPassword.SelectionStart = 0;
            this.TextBoxPassword.ShortcutsEnabled = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(136, 23);
            this.TextBoxPassword.TabIndex = 4;
            this.TextBoxPassword.Text = "비밀번호를 입력하세요";
            this.TextBoxPassword.UseSelectable = true;
            this.TextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 251);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxId);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idlabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox TextBoxId;
        private MetroFramework.Controls.MetroTextBox TextBoxPassword;
    }
}