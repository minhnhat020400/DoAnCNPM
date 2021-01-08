using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyHabit
{
    public partial class FormThongKetuan : Form
    {
        public FormThongKetuan()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
        private void loadAn(int[] a)
        {

            for (int i = 0; i <= a.Length; i++)
            {

                switch (i)
                {
                    case 0:
                        // an là tên cột , biểu đồ có 2 trục trục x và trục y. "thứ" là x, còn a[i] là
                        this.chartAn.Series["an"].Points.AddXY("thứ 2", a[i]);
                        // thay đổi mau của cột theo đk
                        if (a[i] >= 10500 && a[i] <= 17500)
                            chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 10500)
                            chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 17500)
                            chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;
                    case 1:
                        this.chartAn.Series["an"].Points.AddXY("thứ 3", a[i]);

                        if (a[i] >= 10500 && a[i] <= 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 10500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;
                    case 2:
                        this.chartAn.Series["an"].Points.AddXY("thứ 4", a[i]);

                        if (a[i] >= 10500 && a[i] <= 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 10500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;

                    case 3:
                        this.chartAn.Series["an"].Points.AddXY("thứ 5", a[i]);

                        if (a[i] >= 10500 && a[i] <= 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 10500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;
                    case 4:
                        this.chartAn.Series["an"].Points.AddXY("thứ 6", a[i]);

                        if (a[i] >= 10500 && a[i] <= 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 10500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;
                        break;
                    case 5:
                        this.chartAn.Series["an"].Points.AddXY("thứ 7", a[i]);


                        if (a[i] >= 10500 && a[i] <= 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 10500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;
                    case 6:
                        this.chartAn.Series["an"].Points.AddXY("chủ nhật", a[i]);

                        if (a[i] >= 10500 && a[i] <= 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 10500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 17500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;
                }
            }
        }
        void loadUong(double[] a)
        {
            for (int i = 0; i <= a.Length; i++)
            {

                switch (i)
                {
                    case 0:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 2", a[i]);

                        if (a[i] >= 8 && a[i] <= 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 8)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 1:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 3", a[i]);

                        if (a[i] >= 8 && a[i] <= 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 8)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 2:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 4", a[i]);

                        if (a[i] >= 8 && a[i] <= 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 8)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 3:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 5", a[i]);

                        if (a[i] >= 8 && a[i] <= 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 8)
                            chartAn.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 4:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 6", a[i]);

                        if (a[i] >= 8 && a[i] <= 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 8)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 5:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 7", a[i]);

                        if (a[i] >= 8 && a[i] <= 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 8)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 6:
                        this.chartUong.Series["uong"].Points.AddXY("chủ nhật", a[i]);

                        if (a[i] >= 8 && a[i] <= 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 8)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 14)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                }
            }
        }
        void loadNgu(double[] a) 
        {
            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 2", a[i]);

                        if (a[i] >= 42 && a[i] <= 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 42)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 1:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 3", a[i]);

                        if (a[i] >= 42 && a[i] <= 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 42)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 2:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 4", a[i]);

                        if (a[i] >= 42 && a[i] <= 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 42)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 3:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 5", a[i]);

                        if (a[i] >= 42 && a[i] <= 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 42)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 4:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 6", a[i]);

                        if (a[i] >= 42 && a[i] <= 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 42)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 5:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 7", a[i]);

                        if (a[i] >= 42 && a[i] <= 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 42)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 6:
                        this.chartNgu.Series["ngu"].Points.AddXY("chủ nhật", a[i]);

                        if (a[i] >= 42 && a[i] <= 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 42)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 64)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                }
            }
        }
        private void FormThongKetuan_Load(object sender, EventArgs e)
        {
            int[] arr = {12000,2500,16000,17000,10000,12100,20000 };
            double[] arr2 = { 14.6, 20.8, 15, 9.5, 22, 6, 15 };
            double[] arr3 = { 22, 61, 22, 78, 99, 55, 34 };
             loadAn(arr);
            loadUong(arr2);
            loadNgu(arr3);
        }
    }
}
