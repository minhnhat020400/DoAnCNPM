using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class FrmDrink : Form
    {
        public FrmDrink()
        {
            InitializeComponent();
        }
        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmDrink_Load(object sender, EventArgs e)
        {
            GetSetting();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSetting()
        }
        public void GetSetting()
        {
            lbml.Text = Properties.Settings.Default.Calo1.ToString();
        }
        public void SaveSetting()
        {
            Properties.Settings.Default.ML = Convert.ToInt32(txtNuoc.Text);
            

            Properties.Settings.Default.Save();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
