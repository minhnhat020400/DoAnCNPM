
namespace MyHabit
{
    partial class FrmMy
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
            this.pnlta = new System.Windows.Forms.Panel();
            this.btnWep = new System.Windows.Forms.Button();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnEat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlta.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlta
            // 
            this.pnlta.Controls.Add(this.btnWep);
            this.pnlta.Controls.Add(this.btnDiscover);
            this.pnlta.Controls.Add(this.btnHome);
            this.pnlta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlta.Location = new System.Drawing.Point(0, 464);
            this.pnlta.Name = "pnlta";
            this.pnlta.Size = new System.Drawing.Size(968, 93);
            this.pnlta.TabIndex = 6;
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
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.button2);
            this.pnlHead.Controls.Add(this.button1);
            this.pnlHead.Controls.Add(this.btnEat);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(968, 62);
            this.pnlHead.TabIndex = 7;
            // 
            // btnEat
            // 
            this.btnEat.Location = new System.Drawing.Point(3, 0);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(170, 62);
            this.btnEat.TabIndex = 0;
            this.btnEat.Text = "Liều lượng calo";
            this.btnEat.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "nước";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "giấc ngủ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 557);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlta);
            this.IsMdiContainer = true;
            this.Name = "FrmMy";
            this.Text = "FrmMy";
            this.pnlta.ResumeLayout(false);
            this.pnlHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlta;
        private System.Windows.Forms.Button btnWep;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEat;
    }
}