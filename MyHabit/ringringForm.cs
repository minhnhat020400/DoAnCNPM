using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHabit
{
    public partial class ringringForm : Form
    {
        static FrmCMS form;
        string _message;
        public ringringForm(FrmCMS f)
        {
            InitializeComponent();

            form = f;
        }

        public void Message(string message)
        {
            _message = message;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Resume();
        }

        private void btnSnooze_Click(object sender, EventArgs e)
        {
            form.Snooze();
            this.Close();
        }

        private void ringringForm_Shown(object sender, EventArgs e)
        {
            richTextBox1.Text = _message;
        }

        private void ringringForm_Load(object sender, EventArgs e)
        {

        }
    }
}
