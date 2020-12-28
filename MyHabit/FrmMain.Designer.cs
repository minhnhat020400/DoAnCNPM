
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
            this.pnlHead = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bạnBèToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.btnWep = new System.Windows.Forms.Button();
            this.pnlHead.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.menuStrip1);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1029, 52);
            this.pnlHead.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.AutoSize = false;
            this.tàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátTàiKhoảnToolStripMenuItem,
            this.đổiMàuToolStripMenuItem,
            this.bạnBèToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(152, 50);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thoátTàiKhoảnToolStripMenuItem
            // 
            this.thoátTàiKhoảnToolStripMenuItem.Name = "thoátTàiKhoảnToolStripMenuItem";
            this.thoátTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátTàiKhoảnToolStripMenuItem.Text = "Thoát Tài Khoản";
            // 
            // đổiMàuToolStripMenuItem
            // 
            this.đổiMàuToolStripMenuItem.Name = "đổiMàuToolStripMenuItem";
            this.đổiMàuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đổiMàuToolStripMenuItem.Text = "Đổi Màu";
            // 
            // bạnBèToolStripMenuItem
            // 
            this.bạnBèToolStripMenuItem.Name = "bạnBèToolStripMenuItem";
            this.bạnBèToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bạnBèToolStripMenuItem.Text = "Bạn bè";
            // 
            // btnMy
            // 
            this.btnMy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMy.ForeColor = System.Drawing.Color.Purple;
            this.btnMy.Location = new System.Drawing.Point(264, 146);
            this.btnMy.Name = "btnMy";
            this.btnMy.Size = new System.Drawing.Size(522, 116);
            this.btnMy.TabIndex = 3;
            this.btnMy.Text = "Tôi";
            this.btnMy.UseVisualStyleBackColor = false;
            this.btnMy.Click += new System.EventHandler(this.btnMy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWep);
            this.panel1.Controls.Add(this.btnDiscover);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 93);
            this.panel1.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(182, 89);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnDiscover
            // 
            this.btnDiscover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDiscover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscover.Location = new System.Drawing.Point(191, 4);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(182, 89);
            this.btnDiscover.TabIndex = 1;
            this.btnDiscover.Text = "Khám Phá";
            this.btnDiscover.UseVisualStyleBackColor = false;
            // 
            // btnWep
            // 
            this.btnWep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWep.Location = new System.Drawing.Point(379, 4);
            this.btnWep.Name = "btnWep";
            this.btnWep.Size = new System.Drawing.Size(182, 89);
            this.btnWep.TabIndex = 2;
            this.btnWep.Text = "Trang Chủ";
            this.btnWep.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMy);
            this.Controls.Add(this.pnlHead);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bạnBèToolStripMenuItem;
        private System.Windows.Forms.Button btnMy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWep;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Button btnHome;
    }
}