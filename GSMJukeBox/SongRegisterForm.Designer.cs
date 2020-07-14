namespace GSMJukeBox
{
    partial class SongRegisterForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TextBox_Url = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_Title = new MetroFramework.Controls.MetroTextBox();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 86);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(488, 330);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // TextBox_Url
            // 
            // 
            // 
            // 
            this.TextBox_Url.CustomButton.Image = null;
            this.TextBox_Url.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.TextBox_Url.CustomButton.Name = "";
            this.TextBox_Url.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.TextBox_Url.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Url.CustomButton.TabIndex = 1;
            this.TextBox_Url.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Url.CustomButton.UseSelectable = true;
            this.TextBox_Url.CustomButton.Visible = false;
            this.TextBox_Url.Lines = new string[] {
        "URL을 입력하세요."};
            this.TextBox_Url.Location = new System.Drawing.Point(23, 28);
            this.TextBox_Url.MaxLength = 32767;
            this.TextBox_Url.Name = "TextBox_Url";
            this.TextBox_Url.PasswordChar = '\0';
            this.TextBox_Url.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Url.SelectedText = "";
            this.TextBox_Url.SelectionLength = 0;
            this.TextBox_Url.SelectionStart = 0;
            this.TextBox_Url.ShortcutsEnabled = true;
            this.TextBox_Url.Size = new System.Drawing.Size(189, 40);
            this.TextBox_Url.TabIndex = 1;
            this.TextBox_Url.Text = "URL을 입력하세요.";
            this.TextBox_Url.UseSelectable = true;
            this.TextBox_Url.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Url.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBox_Title
            // 
            // 
            // 
            // 
            this.TextBox_Title.CustomButton.Image = null;
            this.TextBox_Title.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.TextBox_Title.CustomButton.Name = "";
            this.TextBox_Title.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.TextBox_Title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Title.CustomButton.TabIndex = 1;
            this.TextBox_Title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Title.CustomButton.UseSelectable = true;
            this.TextBox_Title.CustomButton.Visible = false;
            this.TextBox_Title.Lines = new string[] {
        "노래 제목을 입력하세요"};
            this.TextBox_Title.Location = new System.Drawing.Point(24, 28);
            this.TextBox_Title.MaxLength = 32767;
            this.TextBox_Title.Name = "TextBox_Title";
            this.TextBox_Title.PasswordChar = '\0';
            this.TextBox_Title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Title.SelectedText = "";
            this.TextBox_Title.SelectionLength = 0;
            this.TextBox_Title.SelectionStart = 0;
            this.TextBox_Title.ShortcutsEnabled = true;
            this.TextBox_Title.Size = new System.Drawing.Size(189, 40);
            this.TextBox_Title.TabIndex = 2;
            this.TextBox_Title.Text = "노래 제목을 입력하세요";
            this.TextBox_Title.UseSelectable = true;
            this.TextBox_Title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(538, 317);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 43);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "신청하기";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("카카오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogout.Location = new System.Drawing.Point(691, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 45);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox_Url);
            this.groupBox1.Font = new System.Drawing.Font("카카오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(538, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 90);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox_Title);
            this.groupBox2.Font = new System.Drawing.Font("카카오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(537, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 90);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "노래제목";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 42);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("카카오 Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "노래 예약";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(665, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 43);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "삭제하기";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SongRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dataGridView);
            this.Name = "SongRegisterForm";
            this.Text = "RegisterSong";
            this.Load += new System.EventHandler(this.RegisterSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private MetroFramework.Controls.MetroTextBox TextBox_Url;
        private MetroFramework.Controls.MetroTextBox TextBox_Title;
        private MetroFramework.Controls.MetroButton btnRegister;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnDelete;
    }
}