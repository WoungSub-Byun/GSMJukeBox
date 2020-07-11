namespace GSMJukeBox
{
    partial class SignUpForm
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
            this.LabelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.btnGoMainForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_checkPwd = new System.Windows.Forms.TextBox();
            this.TextBox_Pwd = new System.Windows.Forms.TextBox();
            this.comboBox_Grade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Num = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Class = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LabelName.Location = new System.Drawing.Point(73, 105);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 19);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(73, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "패스워드 재입력";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(73, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(73, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "패스워드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(74, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "학번";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(356, 374);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(108, 48);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "확인";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnGoMainForm
            // 
            this.btnGoMainForm.Font = new System.Drawing.Font("카카오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGoMainForm.Location = new System.Drawing.Point(509, 22);
            this.btnGoMainForm.Name = "btnGoMainForm";
            this.btnGoMainForm.Size = new System.Drawing.Size(75, 45);
            this.btnGoMainForm.TabIndex = 13;
            this.btnGoMainForm.Text = "메인으로";
            this.btnGoMainForm.UseVisualStyleBackColor = true;
            this.btnGoMainForm.Click += new System.EventHandler(this.btnGoMainForm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(11, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 49);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("카카오 Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(40, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "회원가입";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_Name.Location = new System.Drawing.Point(75, 129);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(157, 27);
            this.TextBox_Name.TabIndex = 15;
            // 
            // TextBox_checkPwd
            // 
            this.TextBox_checkPwd.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_checkPwd.Location = new System.Drawing.Point(75, 336);
            this.TextBox_checkPwd.Name = "TextBox_checkPwd";
            this.TextBox_checkPwd.Size = new System.Drawing.Size(157, 27);
            this.TextBox_checkPwd.TabIndex = 17;
            // 
            // TextBox_Pwd
            // 
            this.TextBox_Pwd.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_Pwd.Location = new System.Drawing.Point(75, 266);
            this.TextBox_Pwd.Name = "TextBox_Pwd";
            this.TextBox_Pwd.Size = new System.Drawing.Size(157, 27);
            this.TextBox_Pwd.TabIndex = 18;
            // 
            // comboBox_Grade
            // 
            this.comboBox_Grade.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_Grade.FormattingEnabled = true;
            this.comboBox_Grade.Location = new System.Drawing.Point(75, 195);
            this.comboBox_Grade.Name = "comboBox_Grade";
            this.comboBox_Grade.Size = new System.Drawing.Size(29, 27);
            this.comboBox_Grade.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(105, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "학년";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(238, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "번";
            // 
            // comboBox_Num
            // 
            this.comboBox_Num.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_Num.FormattingEnabled = true;
            this.comboBox_Num.Location = new System.Drawing.Point(197, 195);
            this.comboBox_Num.Name = "comboBox_Num";
            this.comboBox_Num.Size = new System.Drawing.Size(35, 27);
            this.comboBox_Num.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(172, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "반";
            // 
            // comboBox_Class
            // 
            this.comboBox_Class.Font = new System.Drawing.Font("카카오 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_Class.FormattingEnabled = true;
            this.comboBox_Class.Location = new System.Drawing.Point(137, 195);
            this.comboBox_Class.Name = "comboBox_Class";
            this.comboBox_Class.Size = new System.Drawing.Size(29, 27);
            this.comboBox_Class.TabIndex = 23;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 460);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_Class);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Grade);
            this.Controls.Add(this.TextBox_Pwd);
            this.Controls.Add(this.TextBox_checkPwd);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGoMainForm);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelName);
            this.Name = "SignUpForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnRegister;
        private System.Windows.Forms.Button btnGoMainForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.TextBox TextBox_checkPwd;
        private System.Windows.Forms.TextBox TextBox_Pwd;
        private System.Windows.Forms.ComboBox comboBox_Grade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Class;
    }
}