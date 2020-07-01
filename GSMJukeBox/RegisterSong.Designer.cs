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
            this.urllabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Button_Register = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.UrlBox.Location = new System.Drawing.Point(560, 116);
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
            this.SongTitleBox.Location = new System.Drawing.Point(560, 212);
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
            // urllabel
            // 
            this.urllabel.AutoSize = true;
            this.urllabel.Location = new System.Drawing.Point(560, 85);
            this.urllabel.Name = "urllabel";
            this.urllabel.Size = new System.Drawing.Size(42, 19);
            this.urllabel.TabIndex = 3;
            this.urllabel.Text = "- URL";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(560, 177);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "- 노래제목";
            // 
            // Button_Register
            // 
            this.Button_Register.Location = new System.Drawing.Point(603, 319);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(101, 43);
            this.Button_Register.TabIndex = 5;
            this.Button_Register.Text = "신청하기";
            this.Button_Register.UseSelectable = true;
            // 
            // RegisterSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Register);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.urllabel);
            this.Controls.Add(this.SongTitleBox);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "RegisterSong";
            this.Text = "RegisterSong";
            this.Load += new System.EventHandler(this.RegisterSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private MetroFramework.Controls.MetroTextBox UrlBox;
        private MetroFramework.Controls.MetroTextBox SongTitleBox;
        private MetroFramework.Controls.MetroLabel urllabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton Button_Register;
    }
}