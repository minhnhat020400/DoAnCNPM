
namespace MyHabit
{
    partial class FormThongKetuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKetuan));
<<<<<<< HEAD
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.btnWep = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEating = new System.Windows.Forms.TabPage();
            this.tabDrinking = new System.Windows.Forms.TabPage();
            this.tabSleeping = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnDiscover);
            this.panel1.Controls.Add(this.btnWep);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 535);
            this.panel1.TabIndex = 3;
            // 
            // btnDiscover
            // 
            this.btnDiscover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDiscover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscover.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscover.Image")));
            this.btnDiscover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscover.Location = new System.Drawing.Point(0, 266);
            this.btnDiscover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(251, 76);
            this.btnDiscover.TabIndex = 4;
            this.btnDiscover.Text = "Khám Phá";
            this.btnDiscover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscover.UseVisualStyleBackColor = false;
            // 
            // btnWep
            // 
            this.btnWep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWep.Image = ((System.Drawing.Image)(resources.GetObject("btnWep.Image")));
            this.btnWep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWep.Location = new System.Drawing.Point(0, 393);
            this.btnWep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWep.Name = "btnWep";
            this.btnWep.Size = new System.Drawing.Size(251, 60);
            this.btnWep.TabIndex = 3;
            this.btnWep.Text = "Trang Chủ";
            this.btnWep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWep.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tôi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 149);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(251, 73);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEating);
            this.tabControl1.Controls.Add(this.tabDrinking);
            this.tabControl1.Controls.Add(this.tabSleeping);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(311, 155);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 380);
            this.tabControl1.TabIndex = 7;
            // 
            // tabEating
            // 
            this.tabEating.Location = new System.Drawing.Point(4, 25);
            this.tabEating.Name = "tabEating";
            this.tabEating.Padding = new System.Windows.Forms.Padding(3);
            this.tabEating.Size = new System.Drawing.Size(566, 351);
            this.tabEating.TabIndex = 0;
            this.tabEating.Text = "ăn ";
            this.tabEating.UseVisualStyleBackColor = true;
            // 
            // tabDrinking
            // 
            this.tabDrinking.Location = new System.Drawing.Point(4, 25);
            this.tabDrinking.Name = "tabDrinking";
            this.tabDrinking.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrinking.Size = new System.Drawing.Size(566, 400);
            this.tabDrinking.TabIndex = 1;
            this.tabDrinking.Text = "uống";
            this.tabDrinking.UseVisualStyleBackColor = true;
            // 
            // tabSleeping
            // 
            this.tabSleeping.Location = new System.Drawing.Point(4, 25);
            this.tabSleeping.Name = "tabSleeping";
            this.tabSleeping.Padding = new System.Windows.Forms.Padding(3);
            this.tabSleeping.Size = new System.Drawing.Size(566, 400);
            this.tabSleeping.TabIndex = 2;
            this.tabSleeping.Text = "ngủ";
            this.tabSleeping.UseVisualStyleBackColor = true;
            // 
            // FormThongKetuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 535);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormThongKetuan";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
=======
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(667, 11);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(132, 45);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormThongKetuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Name = "FormThongKetuan";
            this.Text = "Form2";
>>>>>>> 6378511340614ed5f45e4220f5f354d60ddd44de
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Button btnWep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEating;
        private System.Windows.Forms.TabPage tabDrinking;
        private System.Windows.Forms.TabPage tabSleeping;
=======
        private System.Windows.Forms.Button btnHome;
>>>>>>> 6378511340614ed5f45e4220f5f354d60ddd44de
    }
}