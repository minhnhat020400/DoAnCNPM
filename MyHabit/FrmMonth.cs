using MyHabit.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyHabit
{
    public partial class FrmMonth : Form
    {
        public FrmMonth()
        {
            InitializeComponent();
            addCbb();
        }
        DateTime TimeCTN = new DateTime();
        public static int TongNgayTrongThang;

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.Show();
        }

        void loadAn(double[] a)
        {
            for (int i = 0; i < TongNgayTrongThang; i++)
            {
                this.chartAn.Series["an"].Points.AddXY(i, a[i]);

                if (a[i] >= 1500 && a[i] <= 2500)
                    chartAn.Series["an"].Points[i].Color = Color.Aqua;
                if (a[i] < 1500)
                    chartAn.Series["an"].Points[i].Color = Color.Green;
                if (a[i] > 2500)
                    chartAn.Series["an"].Points[i].Color = Color.Red;
            }
        }
        void loadUong(double[] a)
        {
            for (int i = 0; i < TongNgayTrongThang; i++)
            {
                this.chartUong.Series["uong"].Points.AddXY(i, a[i]);

                if (a[i] >= 1500 && a[i] <= 2500)
                    chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                if (a[i] < 1500)
                    chartUong.Series["uong"].Points[i].Color = Color.Green;
                if (a[i] > 2500)
                    chartUong.Series["uong"].Points[i].Color = Color.Red;
            }
        }
        void loadNgu(double[] a)
        {
            for (int i = 0; i < TongNgayTrongThang; i++)
            {
                this.chartNgu.Series["ngu"].Points.AddXY(i, a[i]);

                if (a[i] >= 1500 && a[i] <= 2500)
                    chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                if (a[i] < 1500)
                    chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                if (a[i] > 2500)
                    chartNgu.Series["ngu"].Points[i].Color = Color.Red;
            }
        }
        public static async Task<List<CaloTuan>> GetCaloThang(string thang)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FrmLogin.TokenMess);

            // Link api
            String apiUrl = "/api/eating-habits/statistical-total-calo-in-month?month=" + thang;

            // Model  để gửi dữ liệu lên server
            HttpResponseMessage response = await client.GetAsync(apiUrl); // login là body của api

            // Kiểm tra api có thành công hay ko
            if (response.IsSuccessStatusCode)
            {
                // nếu server trả về 1 chuổi thì mình dùng như cách bên dưới
                // server trả về một đối tượng thì dùng await response.Content.ReadAsAsync<Doi tuong>()
                List<CaloTuan> CaloMonth = await response.Content.ReadAsAsync<List<CaloTuan>>();
                TongNgayTrongThang = CaloMonth.Count;

                return CaloMonth;
            }
            else
            {
                return null;
            }

        }
        public static async Task<List<CaloTuan>> GetWaterThang(string thang)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FrmLogin.TokenMess);

            // Link api
            String apiUrl = "/api/drinking-habits/statistical-total-mili-in-month?month=" + thang;

            // Model  để gửi dữ liệu lên server
            HttpResponseMessage response = await client.GetAsync(apiUrl); // login là body của api

            // Kiểm tra api có thành công hay ko
            if (response.IsSuccessStatusCode)
            {
                // nếu server trả về 1 chuổi thì mình dùng như cách bên dưới
                // server trả về một đối tượng thì dùng await response.Content.ReadAsAsync<Doi tuong>()
                List<CaloTuan> DrinkingMonth = await response.Content.ReadAsAsync<List<CaloTuan>>();
                TongNgayTrongThang = DrinkingMonth.Count;

                return DrinkingMonth;
            }
            else
            {
                return null;
            }

        }
        public static async Task<List<CaloTuan>> GetTimeThang(string thang)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FrmLogin.TokenMess);

            // Link api
            String apiUrl = "/api/eating-habits/statistical-total-calo-in-month?month=" + thang;

            // Model  để gửi dữ liệu lên server
            HttpResponseMessage response = await client.GetAsync(apiUrl); // login là body của api

            // Kiểm tra api có thành công hay ko
            if (response.IsSuccessStatusCode)
            {
                // nếu server trả về 1 chuổi thì mình dùng như cách bên dưới
                // server trả về một đối tượng thì dùng await response.Content.ReadAsAsync<Doi tuong>()
                List<CaloTuan> sleepMonth = await response.Content.ReadAsAsync<List<CaloTuan>>();
                TongNgayTrongThang = sleepMonth.Count;

                return sleepMonth;
            }
            else
            {
                return null;
            }

        }


        public double[] TackCaloThang(List<CaloTuan> thang)
        {

            double[] t = new double[thang.Count];


            for (int i = 0; i < thang.Count; i++)
            {
                t[i] = double.Parse(thang[i].total);
            }
            return t;
        }
        public double[] TackwaterThang(List<CaloTuan> thang)
        {

            double[] t = new double[thang.Count];


            for (int i = 0; i < thang.Count; i++)
            {
                t[i] = double.Parse(thang[i].total);
            }
            return t;
        }
        public double[] TackSleepThang(List<CaloTuan> thang)
        {

            double[] t = new double[thang.Count];


            for (int i = 0; i < thang.Count; i++)
            {
                t[i] = double.Parse(thang[i].total);
            }
            return t;
        }

        private async void FrmMonth_Load(object sender, EventArgs e)
        {

            TimeCTN = DateTime.Now;
            string month = TimeCTN.ToString("MM/yyyy");
           // string result = string.Join(string.Empty, month.Skip(3));
            List<CaloTuan> calothang = await GetCaloThang(month);
            List<CaloTuan> Dinking = await GetWaterThang(month);
            List<CaloTuan> sleeping = await GetTimeThang(month);

            loadAn(TackCaloThang(calothang));
            loadUong(TackwaterThang(Dinking));
            loadNgu(TackSleepThang(sleeping));
        }

        private async void btNext_Click(object sender, EventArgs e)
        {
            DateTime date = TimeCTN.AddDays(+TongNgayTrongThang);
            TimeCTN = date;
            string ngay = date.ToString("MM/yyyy");

            List<CaloTuan> caloTuans = await GetCaloThang(ngay);
            List<CaloTuan> waters = await GetWaterThang(ngay);
            List<CaloTuan> Sleep = await GetTimeThang(ngay);

            this.chartAn.Series["an"].Points.Clear();
            this.chartUong.Series["uong"].Points.Clear();
            this.chartNgu.Series["ngu"].Points.Clear();

            loadAn(TackCaloThang(caloTuans));
            loadUong(TackwaterThang(waters));
            loadNgu(TackSleepThang(Sleep));
        }

        private async void  BtStreat_Click(object sender, EventArgs e)
        {
            DateTime date = TimeCTN.AddDays(-TongNgayTrongThang);
            TimeCTN = date;
            string ngay = date.ToString("MM/yyyy");

            List<CaloTuan> caloTuans = await GetCaloThang(ngay);
            List<CaloTuan> waters = await GetWaterThang(ngay);
            List<CaloTuan> Sleep = await GetTimeThang(ngay);

            this.chartAn.Series["an"].Points.Clear();
            this.chartUong.Series["uong"].Points.Clear();
            this.chartNgu.Series["ngu"].Points.Clear();

            loadAn(TackCaloThang(caloTuans));
            loadUong(TackwaterThang(waters));
            loadNgu(TackSleepThang(Sleep));

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            TimeCTN = DateTime.Now;
            string ngay = TimeCTN.ToString("MM/yyyy");

            List<CaloTuan> caloTuans = await GetCaloThang(ngay);
            List<CaloTuan> waters = await GetWaterThang(ngay);
            List<CaloTuan> Sleep = await GetTimeThang(ngay);

            this.chartAn.Series["an"].Points.Clear();
            this.chartUong.Series["uong"].Points.Clear();
            this.chartNgu.Series["ngu"].Points.Clear();

            loadAn(TackCaloThang(caloTuans));
            loadUong(TackwaterThang(waters));
            loadNgu(TackSleepThang(Sleep));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeCTN = dateTimePicker1.Value;
        }
        void addCbb()
        {
            cbbChangeType.Items.Add("line");
            cbbChangeType.Items.Add("Spline");
            cbbChangeType.Items.Add("Area");
            cbbChangeType.Items.Add("Collum");

        }

        private void cbbChangeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbChangeType.Text)
            {
                case "line":
                    chartAn.Series["an"].ChartType = SeriesChartType.Line;
                    chartNgu.Series["ngu"].ChartType = SeriesChartType.Line;
                    chartUong.Series["uong"].ChartType = SeriesChartType.Line;

                    break;
                case "Spline":
                    chartAn.Series["an"].ChartType = SeriesChartType.Spline;
                    chartNgu.Series["ngu"].ChartType = SeriesChartType.Spline;
                    chartUong.Series["uong"].ChartType = SeriesChartType.Spline;

                    break;
                case "Area":
                    chartAn.Series["an"].ChartType = SeriesChartType.Area;
                    chartNgu.Series["ngu"].ChartType = SeriesChartType.Area;
                    chartUong.Series["uong"].ChartType = SeriesChartType.Area;

                    break;
                case "Collum":
                    chartAn.Series["an"].ChartType = SeriesChartType.Column;
                    chartNgu.Series["ngu"].ChartType = SeriesChartType.Column;
                    chartUong.Series["uong"].ChartType = SeriesChartType.Column;

                    break;
            }
        }
    }
}
