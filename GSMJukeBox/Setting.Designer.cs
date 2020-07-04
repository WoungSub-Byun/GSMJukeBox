namespace GSMJukeBox
{
    partial class Setting
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
            this.DatePicker = new MetroFramework.Controls.MetroDateTime();
            this.Button_SetTime = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimePicker = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGoMainForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("카카오 Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DatePicker.Location = new System.Drawing.Point(64, 69);
            this.DatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 39);
            this.DatePicker.TabIndex = 0;
            // 
            // Button_SetTime
            // 
            this.Button_SetTime.Location = new System.Drawing.Point(380, 212);
            this.Button_SetTime.Name = "Button_SetTime";
            this.Button_SetTime.Size = new System.Drawing.Size(75, 45);
            this.Button_SetTime.TabIndex = 2;
            this.Button_SetTime.Text = "확인";
            this.Button_SetTime.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.TimePicker);
            this.groupBox1.Controls.Add(this.Button_SetTime);
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Font = new System.Drawing.Font("카카오 Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(136, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 293);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예약시간 설정";
            // 
            // TimePicker
            // 
            this.TimePicker.FormattingEnabled = true;
            this.TimePicker.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.TimePicker.Location = new System.Drawing.Point(64, 129);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(59, 39);
            this.TimePicker.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox1.Location = new System.Drawing.Point(169, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 39);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "시";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "분";
            // 
            // btnGoMainForm
            // 
            this.btnGoMainForm.Font = new System.Drawing.Font("카카오 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGoMainForm.Location = new System.Drawing.Point(702, 25);
            this.btnGoMainForm.Name = "btnGoMainForm";
            this.btnGoMainForm.Size = new System.Drawing.Size(75, 45);
            this.btnGoMainForm.TabIndex = 7;
            this.btnGoMainForm.Text = "메인으로";
            this.btnGoMainForm.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoMainForm);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime DatePicker;
        private System.Windows.Forms.Button Button_SetTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGoMainForm;
    }
}