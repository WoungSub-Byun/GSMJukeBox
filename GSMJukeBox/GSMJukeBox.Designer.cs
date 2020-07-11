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
            this.btnLoginForm = new System.Windows.Forms.Button();
            this.btnSignUpForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.Font = new System.Drawing.Font("카카오 Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoginForm.Location = new System.Drawing.Point(231, 317);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(118, 73);
            this.btnLoginForm.TabIndex = 0;
            this.btnLoginForm.Text = "로그인";
            this.btnLoginForm.UseVisualStyleBackColor = true;
            this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
            // 
            // btnSignUpForm
            // 
            this.btnSignUpForm.Font = new System.Drawing.Font("카카오 Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSignUpForm.Location = new System.Drawing.Point(404, 317);
            this.btnSignUpForm.Name = "btnSignUpForm";
            this.btnSignUpForm.Size = new System.Drawing.Size(115, 73);
            this.btnSignUpForm.TabIndex = 1;
            this.btnSignUpForm.Text = "회원가입";
            this.btnSignUpForm.UseVisualStyleBackColor = true;
            this.btnSignUpForm.Click += new System.EventHandler(this.btnSignUpForm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 215);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("카카오 Regular", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(184, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "로고나 그런거";
            // 
            // GSMJukeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSignUpForm);
            this.Controls.Add(this.btnLoginForm);
            this.Name = "GSMJukeBox";
            this.Text = "GSMJukeBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginForm;
        private System.Windows.Forms.Button btnSignUpForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}