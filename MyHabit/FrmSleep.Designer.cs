
namespace MyHabit
{
    partial class FrmSleep
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listRingtone = new System.Windows.Forms.ListBox();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.richtxtMesaage = new System.Windows.Forms.RichTextBox();
            this.cmbSnooze = new System.Windows.Forms.ComboBox();
            this.cmbAMPM = new System.Windows.Forms.ComboBox();
            this.cmbMinute = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Snooze";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ringtone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Message:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.listRingtone);
            this.groupBox1.Controls.Add(this.btnSetAlarm);
            this.groupBox1.Controls.Add(this.richtxtMesaage);
            this.groupBox1.Controls.Add(this.cmbSnooze);
            this.groupBox1.Controls.Add(this.cmbAMPM);
            this.groupBox1.Controls.Add(this.cmbMinute);
            this.groupBox1.Controls.Add(this.cmbHour);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 264);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Alarm";
            // 
            // listRingtone
            // 
            this.listRingtone.FormattingEnabled = true;
            this.listRingtone.Location = new System.Drawing.Point(63, 79);
            this.listRingtone.Name = "listRingtone";
            this.listRingtone.Size = new System.Drawing.Size(182, 147);
            this.listRingtone.TabIndex = 9;
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Location = new System.Drawing.Point(214, 232);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnSetAlarm.TabIndex = 12;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // richtxtMesaage
            // 
            this.richtxtMesaage.Location = new System.Drawing.Point(256, 41);
            this.richtxtMesaage.Name = "richtxtMesaage";
            this.richtxtMesaage.Size = new System.Drawing.Size(233, 185);
            this.richtxtMesaage.TabIndex = 11;
            this.richtxtMesaage.Text = "";
            // 
            // cmbSnooze
            // 
            this.cmbSnooze.FormattingEnabled = true;
            this.cmbSnooze.Location = new System.Drawing.Point(63, 52);
            this.cmbSnooze.Name = "cmbSnooze";
            this.cmbSnooze.Size = new System.Drawing.Size(51, 21);
            this.cmbSnooze.TabIndex = 9;
            // 
            // cmbAMPM
            // 
            this.cmbAMPM.FormattingEnabled = true;
            this.cmbAMPM.Location = new System.Drawing.Point(151, 25);
            this.cmbAMPM.Name = "cmbAMPM";
            this.cmbAMPM.Size = new System.Drawing.Size(42, 21);
            this.cmbAMPM.TabIndex = 8;
            // 
            // cmbMinute
            // 
            this.cmbMinute.FormattingEnabled = true;
            this.cmbMinute.Location = new System.Drawing.Point(108, 25);
            this.cmbMinute.Name = "cmbMinute";
            this.cmbMinute.Size = new System.Drawing.Size(37, 21);
            this.cmbMinute.TabIndex = 7;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(63, 25);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(39, 21);
            this.cmbHour.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(48, 9);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 7;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(48, 41);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(226, 38);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 9;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(226, 7);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(143, 23);
            this.btntinh.TabIndex = 10;
            this.btntinh.Text = "Tính thời gian chênh lệch";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Second";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Minute";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FrmSleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 345);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSleep";
            this.Text = "FrmSleep";
            this.Load += new System.EventHandler(this.FrmSleep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richtxtMesaage;
        private System.Windows.Forms.ComboBox cmbSnooze;
        private System.Windows.Forms.ComboBox cmbAMPM;
        private System.Windows.Forms.ComboBox cmbMinute;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listRingtone;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}