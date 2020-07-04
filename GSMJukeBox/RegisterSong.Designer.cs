namespace GSMJukeBox
{
    partial class RegisterSong
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
            this.UrlBox = new MetroFramework.Controls.MetroTextBox();
            this.SongTitleBox = new MetroFramework.Controls.MetroTextBox();
            this.btnSongRegister = new MetroFramework.Controls.MetroButton();
            this.btnGoMainForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(488, 353);
            this.dataGridView.TabIndex = 0;
            // 
            // UrlBox
            // 
            // 
            // 
            // 
            this.UrlBox.CustomButton.Image = null;
            this.UrlBox.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.UrlBox.CustomButton.Name = "";
            this.UrlBox.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.UrlBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UrlBox.CustomButton.TabIndex = 1;
            this.UrlBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UrlBox.CustomButton.UseSelectable = true;
            this.UrlBox.CustomButton.Visible = false;
            this.UrlBox.Lines = new string[] {
        "URL을 입력하세요."};
            this.UrlBox.Location = new System.Drawing.Point(24, 34);
            this.UrlBox.MaxLength = 32767;
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.PasswordChar = '\0';
            this.UrlBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UrlBox.SelectedText = "";
            this.UrlBox.SelectionLength = 0;
            this.UrlBox.SelectionStart = 0;
            this.UrlBox.ShortcutsEnabled = true;
            this.UrlBox.Size = new System.Drawing.Size(189, 40);
            this.UrlBox.TabIndex = 1;
            this.UrlBox.Text = "URL을 입력하세요.";
            this.UrlBox.UseSelectable = true;
            this.UrlBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UrlBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SongTitleBox
            // 
            // 
            // 
            // 
            this.SongTitleBox.CustomButton.Image = null;
            this.SongTitleBox.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.SongTitleBox.CustomButton.Name = "";
            this.SongTitleBox.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.SongTitleBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SongTitleBox.CustomButton.TabIndex = 1;
            this.SongTitleBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SongTitleBox.CustomButton.UseSelectable = true;
            this.SongTitleBox.CustomButton.Visible = false;
            this.SongTitleBox.Lines = new string[] {
        "노래 제목을 입력하세요"};
            this.SongTitleBox.Location = new System.Drawing.Point(24, 28);
            this.SongTitleBox.MaxLength = 32767;
            this.SongTitleBox.Name = "SongTitleBox";
            this.SongTitleBox.PasswordChar = '\0';
            this.SongTitleBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SongTitleBox.SelectedText = "";
            this.SongTitleBox.SelectionLength = 0;
            this.SongTitleBox.SelectionStart = 0;
            this.SongTitleBox.ShortcutsEnabled = true;
            this.SongTitleBox.Size = new System.Drawing.Size(189, 40);
            this.SongTitleBox.TabIndex = 2;
            this.SongTitleBox.Text = "노래 제목을 입력하세요";
            this.SongTitleBox.UseSelectable = true;
            this.SongTitleBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SongTitleBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSongRegister
            // 
            this.btnSongRegister.Location = new System.Drawing.Point(603, 319);
            this.btnSongRegister.Name = "btnSongRegister";
            this.btnSongRegister.Size = new System.Drawing.Size(101, 43);
            this.btnSongRegister.TabIndex = 5;
            this.btnSongRegister.Text = "신청하기";
            this.btnSongRegister.UseSelectable = true;
            // 
            // btnGoMainForm
            // 
            this.btnGoMainForm.Font = new System.Drawing.Font("카카오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGoMainForm.Location = new System.Drawing.Point(691, 22);
            this.btnGoMainForm.Name = "btnGoMainForm";
            this.btnGoMainForm.Size = new System.Drawing.Size(75, 45);
            this.btnGoMainForm.TabIndex = 6;
            this.btnGoMainForm.Text = "메인으로";
            this.btnGoMainForm.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UrlBox);
            this.groupBox1.Font = new System.Drawing.Font("카카오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(537, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 104);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SongTitleBox);
            this.groupBox2.Font = new System.Drawing.Font("카카오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(537, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 90);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "노래제목";
            // 
            // RegisterSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGoMainForm);
            this.Controls.Add(this.btnSongRegister);
            this.Controls.Add(this.dataGridView);
            this.Name = "RegisterSong";
            this.Text = "RegisterSong";
            this.Load += new System.EventHandler(this.RegisterSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private MetroFramework.Controls.MetroTextBox UrlBox;
        private MetroFramework.Controls.MetroTextBox SongTitleBox;
        private MetroFramework.Controls.MetroButton btnSongRegister;
        private System.Windows.Forms.Button btnGoMainForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}