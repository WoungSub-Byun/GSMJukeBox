namespace GSMJukeBox
{
    partial class AdminMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlaySongForm = new System.Windows.Forms.Button();
            this.btnGoSetTimeForm = new System.Windows.Forms.Button();
            this.btnGoReservedSongForm = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 64);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "[ Admin ]";
            // 
            // btnPlaySongForm
            // 
            this.btnPlaySongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlaySongForm.Location = new System.Drawing.Point(192, 294);
            this.btnPlaySongForm.Name = "btnPlaySongForm";
            this.btnPlaySongForm.Size = new System.Drawing.Size(94, 94);
            this.btnPlaySongForm.TabIndex = 2;
            this.btnPlaySongForm.Text = "노래 재생";
            this.btnPlaySongForm.UseVisualStyleBackColor = true;
            this.btnPlaySongForm.Click += new System.EventHandler(this.btnPlaySongForm_Click);
            // 
            // btnGoSetTimeForm
            // 
            this.btnGoSetTimeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGoSetTimeForm.Location = new System.Drawing.Point(511, 294);
            this.btnGoSetTimeForm.Name = "btnGoSetTimeForm";
            this.btnGoSetTimeForm.Size = new System.Drawing.Size(94, 94);
            this.btnGoSetTimeForm.TabIndex = 3;
            this.btnGoSetTimeForm.Text = "시간 예약";
            this.btnGoSetTimeForm.UseVisualStyleBackColor = true;
            this.btnGoSetTimeForm.Click += new System.EventHandler(this.btnGoSetTimeForm_Click);
            // 
            // btnGoReservedSongForm
            // 
            this.btnGoReservedSongForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGoReservedSongForm.Location = new System.Drawing.Point(353, 294);
            this.btnGoReservedSongForm.Name = "btnGoReservedSongForm";
            this.btnGoReservedSongForm.Size = new System.Drawing.Size(94, 94);
            this.btnGoReservedSongForm.TabIndex = 4;
            this.btnGoReservedSongForm.Text = "예약 목록";
            this.btnGoReservedSongForm.UseVisualStyleBackColor = true;
            this.btnGoReservedSongForm.Click += new System.EventHandler(this.btnGoReservedSongForm_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(259, 14);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(452, 250);
            this.webBrowser1.TabIndex = 5;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnGoReservedSongForm);
            this.Controls.Add(this.btnGoSetTimeForm);
            this.Controls.Add(this.btnPlaySongForm);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlaySongForm;
        private System.Windows.Forms.Button btnGoSetTimeForm;
        private System.Windows.Forms.Button btnGoReservedSongForm;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}