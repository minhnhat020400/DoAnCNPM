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
    public partial class FormThongKetuan : Form
    {
        static string FstDate;
        static string LstDate;

        public FormThongKetuan()
        {
            InitializeComponent();
            addCbb();
        }

        public static DateTime TimeCTN;


        private void btnHome_Click_1(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmMyInFo frmMyInFo = new FrmMyInFo();
            this.Hide();
            frmMyInFo.Show();
        }

        #region  [      Load Form    ]
        private void loadAn(double[] a)
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
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
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
        void loadDate(string frst, string last)
        {
            LbFrstDate.Text = "Từ   " + frst + "    Đến     " + last;
        }
        #endregion

        private async void FormThongKetuan_Load(object sender, EventArgs e)
        {
            TimeCTN = DateTime.Now;
            List<CaloTuan> caloTuans = await GetCaloTuan(TimeCTN.ToString("dd/MM/yyyy"));
            List<CaloTuan> waters = await GetWaterTuan(TimeCTN.ToString("dd/MM/yyyy"));
            List<CaloTuan> Sleep = await GetSleepTuan(TimeCTN.ToString("dd/MM/yyyy"));

            loadAn(TackCaloWeek(caloTuans));
            loadUong(TackwaterWeek(waters));
            loadNgu(TackTimerWeek(Sleep));

            FstDate = caloTuans[0].createAt;
            LstDate = caloTuans[6].createAt;
            loadDate(FstDate, LstDate);
        }

        public double[] TackCaloWeek(List<CaloTuan> caloTuans)
        {
            double[] t = new double[7];

            for (int i = 0; i < caloTuans.Count; i++)
            {
                t[i] = double.Parse(caloTuans[i].total);
            }
            return t;
        }
        public double[] TackwaterWeek(List<CaloTuan> caloTuans)
        {
            double[] t = new double[7];

            for (int i = 0; i < caloTuans.Count; i++)
            {
                t[i] = double.Parse(caloTuans[i].total);
            }
            return t;
        }
        public double[] TackTimerWeek(List<CaloTuan> caloTuans)
        {
            double[] t = new double[7];

            for (int i = 0; i < caloTuans.Count; i++)
            {
                t[i] = double.Parse(caloTuans[i].total);
            }
            return t;
        }

        private async void btStreat_Click(object sender, EventArgs e)
        {
            DateTime date = TimeCTN.AddDays(-7);
            TimeCTN = date;
            string ngay = date.ToString("dd/MM/yyyy");

            List<CaloTuan> caloTuans = await GetCaloTuan(ngay);
            List<CaloTuan> waters = await GetWaterTuan(ngay);
            List<CaloTuan> Sleep = await GetSleepTuan(ngay);

            this.chartAn.Series["an"].Points.Clear();
            this.chartUong.Series["uong"].Points.Clear();
            this.chartNgu.Series["ngu"].Points.Clear();

            loadAn(TackCaloWeek(caloTuans));
            loadUong(TackwaterWeek(waters));
            loadNgu(TackTimerWeek(Sleep));

            FstDate = caloTuans[0].createAt;
            LstDate = caloTuans[6].createAt;

            loadDate(FstDate, LstDate);

        }
        private async void btNext_Click(object sender, EventArgs e)
        {
            DateTime date = TimeCTN.AddDays(+7);
            TimeCTN = date;
            string ngay = date.ToString("dd/MM/yyyy");

            List<CaloTuan> caloTuans = await GetCaloTuan(ngay);
            List<CaloTuan> waters = await GetWaterTuan(ngay);
            List<CaloTuan> Sleep = await GetSleepTuan(ngay);

            this.chartAn.Series["an"].Points.Clear();
            this.chartUong.Series["uong"].Points.Clear();
            this.chartNgu.Series["ngu"].Points.Clear();

            loadAn(TackCaloWeek(caloTuans));
            loadUong(TackwaterWeek(waters));
            loadNgu(TackTimerWeek(Sleep));

            FstDate = caloTuans[0].createAt;
            LstDate = caloTuans[6].createAt;

            loadDate(FstDate, LstDate);

        }
        #region Call API 
        public static async Task<List<CaloTuan>> GetCaloTuan(string ngay)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FrmLogin.TokenMess);

            // Link api
            String apiUrl = "/api/drinking-habits/statistical-total-calo-in-week?week=" + ngay;

            // Model  để gửi dữ liệu lên server
            HttpResponseMessage response = await client.GetAsync(apiUrl); // login là body của api

            // Kiểm tra api có thành công hay ko
            if (response.IsSuccessStatusCode)
            {
                // nếu server trả về 1 chuổi thì mình dùng như cách bên dưới
                // server trả về một đối tượng thì dùng await response.Content.ReadAsAsync<Doi tuong>()
                List<CaloTuan> CaloWeek = await response.Content.ReadAsAsync<List<CaloTuan>>();

                return CaloWeek;
            }
            else
            {
                return null;
            }

        }
        public static async Task<List<CaloTuan>> GetWaterTuan(string ngay)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FrmLogin.TokenMess);

            // Link api
            String apiUrl = "/api/drinking-habits/statistical-total-calo-in-week?week=" + ngay;

            HttpResponseMessage response = await client.GetAsync(apiUrl); // login là body của api

            // Kiểm tra api có thành công hay ko
            if (response.IsSuccessStatusCode)
            {
                // nếu server trả về 1 chuổi thì mình dùng như cách bên dưới
                // server trả về một đối tượng thì dùng await response.Content.ReadAsAsync<Doi tuong>()
                List<CaloTuan> WaterWeek = await response.Content.ReadAsAsync<List<CaloTuan>>();

                return WaterWeek;
            }
            else
            {
                return null;
            }
        }
        public static async Task<List<CaloTuan>> GetSleepTuan(string ngay)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", FrmLogin.TokenMess);

            // Link api
            String apiUrl = "/api/sleeping-habit/statistical-sleeping-hour-in-week?week=" + ngay;

            // Model  để gửi dữ liệu lên server



            // POST dùng postAsJsonAsync có body
            // Get dùng GetAsync ko có body
            // PUT dùng PutAsJsonAsync có body
            // Delete dùng DeleteAsync ko có body
            HttpResponseMessage response = await client.GetAsync(apiUrl); // login là body của api

            // Kiểm tra api có thành công hay ko
            if (response.IsSuccessStatusCode)
            {
                // nếu server trả về 1 chuổi thì mình dùng như cách bên dưới
                // server trả về một đối tượng thì dùng await response.Content.ReadAsAsync<Doi tuong>()
                List<CaloTuan> SleepWeek = await response.Content.ReadAsAsync<List<CaloTuan>>();

                return SleepWeek;
            }
            else
            {
                return null;
            }
        }


        #endregion
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
