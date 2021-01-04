
namespace MyHabit
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bạnBèToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnWep = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 54);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.AutoSize = false;
            this.tàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátTàiKhoảnToolStripMenuItem,
            this.đổiMàuToolStripMenuItem,
            this.bạnBèToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 50);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thoátTàiKhoảnToolStripMenuItem
            // 
            this.thoátTàiKhoảnToolStripMenuItem.Name = "thoátTàiKhoảnToolStripMenuItem";
            this.thoátTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.thoátTàiKhoảnToolStripMenuItem.Text = "Thoát Tài Khoản";
            this.thoátTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thoátTàiKhoảnToolStripMenuItem_Click);
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.đổiMàuToolStripMenuItem.Text = "Đổi Màu";
            // 
            // bạnBèToolStripMenuItem
            // 
            this.bạnBèToolStripMenuItem.Name = "bạnBèToolStripMenuItem";
            this.bạnBèToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bạnBèToolStripMenuItem.Text = "Bạn bè";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnDiscover);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnWep);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 396);
            this.panel1.TabIndex = 2;
            // 
            // btnDiscover
            // 
            this.btnDiscover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDiscover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscover.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscover.Image")));
            this.btnDiscover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscover.Location = new System.Drawing.Point(0, 209);
            this.btnDiscover.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(188, 62);
            this.btnDiscover.TabIndex = 4;
            this.btnDiscover.Text = "Khám Phá";
            this.btnDiscover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscover.UseVisualStyleBackColor = false;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 301);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "BMI";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnWep
            // 
            this.btnWep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWep.Image = ((System.Drawing.Image)(resources.GetObject("btnWep.Image")));
            this.btnWep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWep.Location = new System.Drawing.Point(0, 29);
            this.btnWep.Margin = new System.Windows.Forms.Padding(2);
            this.btnWep.Name = "btnWep";
            this.btnWep.Size = new System.Drawing.Size(188, 60);
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
            this.button1.Location = new System.Drawing.Point(0, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tôi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMy
            // 
            this.btnMy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMy.ForeColor = System.Drawing.Color.Purple;
            this.btnMy.Location = new System.Drawing.Point(320, 139);
            this.btnMy.Margin = new System.Windows.Forms.Padding(2);
            this.btnMy.Name = "btnMy";
            this.btnMy.Size = new System.Drawing.Size(363, 95);
            this.btnMy.TabIndex = 4;
            this.btnMy.Text = "Check bản thân";
            this.btnMy.UseVisualStyleBackColor = false;
            this.btnMy.Click += new System.EventHandler(this.btnMy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 92);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thống Kê Tuần";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bạnBèToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWep;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Button btnMy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}