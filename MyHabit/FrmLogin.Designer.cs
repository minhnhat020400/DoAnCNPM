
namespace MyHabit
{
    partial class FrmLogin
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btGetIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btCreateAcc = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.pnl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnl1.Controls.Add(this.panel1);
            this.pnl1.Controls.Add(this.pnl2);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(997, 556);
            this.pnl1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btGetIn);
            this.panel1.Controls.Add(this.btnOut);
            this.panel1.Controls.Add(this.btCreateAcc);
            this.panel1.Location = new System.Drawing.Point(729, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 69);
            this.panel1.TabIndex = 4;
            // 
            // btGetIn
            // 
            this.btGetIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btGetIn.ForeColor = System.Drawing.Color.Black;
            this.btGetIn.Location = new System.Drawing.Point(0, 0);
            this.btGetIn.Name = "btGetIn";
            this.btGetIn.Size = new System.Drawing.Size(130, 45);
            this.btGetIn.TabIndex = 0;
            this.btGetIn.Text = "Đang nhập";
            this.btGetIn.UseVisualStyleBackColor = false;
            this.btGetIn.Click += new System.EventHandler(this.btGetIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOut.ForeColor = System.Drawing.Color.Black;
            this.btnOut.Location = new System.Drawing.Point(145, 0);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(130, 45);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "thoát";
            this.btnOut.UseVisualStyleBackColor = false;
            // 
            // btCreateAcc
            // 
            this.btCreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCreateAcc.Location = new System.Drawing.Point(281, 0);
            this.btCreateAcc.Name = "btCreateAcc";
            this.btCreateAcc.Size = new System.Drawing.Size(130, 45);
            this.btCreateAcc.TabIndex = 1;
            this.btCreateAcc.Text = "Tạo tài khoản";
            this.btCreateAcc.UseVisualStyleBackColor = false;
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.lbPassword);
            this.pnl2.Controls.Add(this.lbAccount);
            this.pnl2.Controls.Add(this.tbPassword);
            this.pnl2.Controls.Add(this.tbAccount);
            this.pnl2.Location = new System.Drawing.Point(729, 351);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(526, 116);
            this.pnl2.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbPassword.Location = new System.Drawing.Point(3, 79);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(156, 24);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "MẬT KHẨU";
            // 
            // lbAccount
            // 
            this.lbAccount.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbAccount.Location = new System.Drawing.Point(3, 19);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(153, 24);
            this.lbAccount.TabIndex = 2;
            this.lbAccount.Text = "TÀI KHOẢN";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(162, 63);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(348, 40);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "1";
            // 
            // tbAccount
            // 
            this.tbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccount.Location = new System.Drawing.Point(162, 3);
            this.tbAccount.Multiline = true;
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(348, 40);
            this.tbAccount.TabIndex = 0;
            this.tbAccount.Text = "trang";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 556);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmLogin";
            this.Text = "đăng nhập";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btGetIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btCreateAcc;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbAccount;
    }
}

