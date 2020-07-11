namespace GSMJukeBox
{
    partial class LoginForm
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
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.TextBox_Id = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_Pwd = new MetroFramework.Controls.MetroTextBox();
            this.btnGoMainForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Student = new System.Windows.Forms.RadioButton();
            this.radioButton_Admin = new System.Windows.Forms.RadioButton();
            this.TextBox_SndPwd = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idlabel.Location = new System.Drawing.Point(102, 161);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(35, 19);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "학번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(88, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(331, 159);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 87);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // TextBox_Id
            // 
            // 
            // 
            // 
            this.TextBox_Id.CustomButton.Image = null;
            this.TextBox_Id.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.TextBox_Id.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Id.CustomButton.Name = "";
            this.TextBox_Id.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.TextBox_Id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Id.CustomButton.TabIndex = 1;
            this.TextBox_Id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Id.CustomButton.UseSelectable = true;
            this.TextBox_Id.CustomButton.Visible = false;
            this.TextBox_Id.Lines = new string[] {
        "학번 입력"};
            this.TextBox_Id.Location = new System.Drawing.Point(167, 159);
            this.TextBox_Id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Id.MaxLength = 32767;
            this.TextBox_Id.Name = "TextBox_Id";
            this.TextBox_Id.PasswordChar = '\0';
            this.TextBox_Id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Id.SelectedText = "";
            this.TextBox_Id.SelectionLength = 0;
            this.TextBox_Id.SelectionStart = 0;
            this.TextBox_Id.ShortcutsEnabled = true;
            this.TextBox_Id.Size = new System.Drawing.Size(136, 31);
            this.TextBox_Id.TabIndex = 3;
            this.TextBox_Id.Text = "학번 입력";
            this.TextBox_Id.UseSelectable = true;
            this.TextBox_Id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBox_Pwd
            // 
            // 
            // 
            // 
            this.TextBox_Pwd.CustomButton.Image = null;
            this.TextBox_Pwd.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.TextBox_Pwd.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Pwd.CustomButton.Name = "";
            this.TextBox_Pwd.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.TextBox_Pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Pwd.CustomButton.TabIndex = 1;
            this.TextBox_Pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Pwd.CustomButton.UseSelectable = true;
            this.TextBox_Pwd.CustomButton.Visible = false;
            this.TextBox_Pwd.Lines = new string[] {
        "비밀번호 입력"};
            this.TextBox_Pwd.Location = new System.Drawing.Point(167, 204);
            this.TextBox_Pwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Pwd.MaxLength = 32767;
            this.TextBox_Pwd.Name = "TextBox_Pwd";
            this.TextBox_Pwd.PasswordChar = '\0';
            this.TextBox_Pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Pwd.SelectedText = "";
            this.TextBox_Pwd.SelectionLength = 0;
            this.TextBox_Pwd.SelectionStart = 0;
            this.TextBox_Pwd.ShortcutsEnabled = true;
            this.TextBox_Pwd.Size = new System.Drawing.Size(136, 31);
            this.TextBox_Pwd.TabIndex = 4;
            this.TextBox_Pwd.Text = "비밀번호 입력";
            this.TextBox_Pwd.UseSelectable = true;
            this.TextBox_Pwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Pwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGoMainForm
            // 
            this.btnGoMainForm.Font = new System.Drawing.Font("카카오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGoMainForm.Location = new System.Drawing.Point(390, 32);
            this.btnGoMainForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGoMainForm.Name = "btnGoMainForm";
            this.btnGoMainForm.Size = new System.Drawing.Size(75, 44);
            this.btnGoMainForm.TabIndex = 7;
            this.btnGoMainForm.Text = "메인으로";
            this.btnGoMainForm.UseVisualStyleBackColor = true;
            this.btnGoMainForm.Click += new System.EventHandler(this.btnGoMainForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("카카오 Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "로그인";
            // 
            // radioButton_Student
            // 
            this.radioButton_Student.AutoSize = true;
            this.radioButton_Student.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_Student.Location = new System.Drawing.Point(150, 119);
            this.radioButton_Student.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Student.Name = "radioButton_Student";
            this.radioButton_Student.Size = new System.Drawing.Size(53, 23);
            this.radioButton_Student.TabIndex = 10;
            this.radioButton_Student.TabStop = true;
            this.radioButton_Student.Text = "학생";
            this.radioButton_Student.UseVisualStyleBackColor = true;
            // 
            // radioButton_Admin
            // 
            this.radioButton_Admin.AutoSize = true;
            this.radioButton_Admin.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_Admin.Location = new System.Drawing.Point(209, 119);
            this.radioButton_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Admin.Name = "radioButton_Admin";
            this.radioButton_Admin.Size = new System.Drawing.Size(53, 23);
            this.radioButton_Admin.TabIndex = 11;
            this.radioButton_Admin.TabStop = true;
            this.radioButton_Admin.Text = "사감";
            this.radioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // TextBox_SndPwd
            // 
            // 
            // 
            // 
            this.TextBox_SndPwd.CustomButton.Image = null;
            this.TextBox_SndPwd.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.TextBox_SndPwd.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_SndPwd.CustomButton.Name = "";
            this.TextBox_SndPwd.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.TextBox_SndPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_SndPwd.CustomButton.TabIndex = 1;
            this.TextBox_SndPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_SndPwd.CustomButton.UseSelectable = true;
            this.TextBox_SndPwd.CustomButton.Visible = false;
            this.TextBox_SndPwd.Lines = new string[] {
        "2차비밀번호 입력"};
            this.TextBox_SndPwd.Location = new System.Drawing.Point(167, 247);
            this.TextBox_SndPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_SndPwd.MaxLength = 32767;
            this.TextBox_SndPwd.Name = "TextBox_SndPwd";
            this.TextBox_SndPwd.PasswordChar = '\0';
            this.TextBox_SndPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_SndPwd.SelectedText = "";
            this.TextBox_SndPwd.SelectionLength = 0;
            this.TextBox_SndPwd.SelectionStart = 0;
            this.TextBox_SndPwd.ShortcutsEnabled = true;
            this.TextBox_SndPwd.Size = new System.Drawing.Size(136, 31);
            this.TextBox_SndPwd.TabIndex = 13;
            this.TextBox_SndPwd.Text = "2차비밀번호 입력";
            this.TextBox_SndPwd.UseSelectable = true;
            this.TextBox_SndPwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_SndPwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(76, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "2차 비밀번호";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(23, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 3);
            this.panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 42);
            this.panel1.TabIndex = 15;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TextBox_SndPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_Admin);
            this.Controls.Add(this.radioButton_Student);
            this.Controls.Add(this.btnGoMainForm);
            this.Controls.Add(this.TextBox_Pwd);
            this.Controls.Add(this.TextBox_Id);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idlabel);
            this.Font = new System.Drawing.Font("카카오 Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(20, 80, 20, 27);
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox TextBox_Id;
        private MetroFramework.Controls.MetroTextBox TextBox_Pwd;
        private System.Windows.Forms.Button btnGoMainForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Student;
        private System.Windows.Forms.RadioButton radioButton_Admin;
        private MetroFramework.Controls.MetroTextBox TextBox_SndPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}