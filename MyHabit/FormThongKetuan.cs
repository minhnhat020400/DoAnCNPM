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
        public static double Tongcalotuannay;
        public static double TongMinituannay;
        public static double TongThoiGiantuannay;

        public static double TongcalotuanTruoc;
        public static double TongMinituanTruoc;
        public static double TongThoiGiantuantruoc;

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
                        if (a[i] >= 1500 && a[i] <= 2500)
                            chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1500)
                            chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 2500)
                            chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;
                    case 1:
                        this.chartAn.Series["an"].Points.AddXY("thứ 3", a[i]);

                        if (a[i] >= 1500 && a[i] <= 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;
                    case 2:
                        this.chartAn.Series["an"].Points.AddXY("thứ 4", a[i]);

                        if (a[i] >= 1500 && a[i] <= 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;

                    case 3:
                        this.chartAn.Series["an"].Points.AddXY("thứ 5", a[i]);

                        if (a[i] >= 105150000 && a[i] <= 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;
                    case 4:
                        this.chartAn.Series["an"].Points.AddXY("thứ 6", a[i]);

                        if (a[i] >= 1500 && a[i] <= 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;
                        break;
                    case 5:
                        this.chartAn.Series["an"].Points.AddXY("thứ 7", a[i]);


                        if (a[i] >= 1500 && a[i] <= 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Red;

                        break;
                    case 6:
                        this.chartAn.Series["an"].Points.AddXY("chủ nhật", a[i]);

                        if (a[i] >= 1500 && a[i] <= 2500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1500)
                            this.chartAn.Series["an"].Points[i].Color = Color.Green;
                        if (a[i] > 2500)
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

                        if (a[i] >= 1000 && a[i] <= 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1000)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 1:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 3", a[i]);

                        if (a[i] >= 1000 && a[i] <= 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1000)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 2:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 4", a[i]);

                        if (a[i] >= 1000 && a[i] <= 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1000)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 3:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 5", a[i]);

                        if (a[i] >= 1000 && a[i] <= 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1000)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 4:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 6", a[i]);

                        if (a[i] >= 1000 && a[i] <= 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1000)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 5:
                        this.chartUong.Series["uong"].Points.AddXY("thứ 7", a[i]);

                        if (a[i] >= 1000 && a[i] <= 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1000)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Red;
                        break;
                    case 6:
                        this.chartUong.Series["uong"].Points.AddXY("chủ nhật", a[i]);

                        if (a[i] >= 1000 && a[i] <= 2000)
                            chartUong.Series["uong"].Points[i].Color = Color.Aqua;
                        if (a[i] < 1000)
                            chartUong.Series["uong"].Points[i].Color = Color.Green;
                        if (a[i] > 2000)
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

                        if (a[i] >= 360 && a[i] <= 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 360)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 1:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 3", a[i]);

                        if (a[i] >= 360 && a[i] <= 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 360)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 2:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 4", a[i]);

                        if (a[i] >= 360 && a[i] <= 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 360)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 3:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 5", a[i]);

                        if (a[i] >= 360 && a[i] <= 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 360)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 4:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 6", a[i]);

                        if (a[i] >= 360 && a[i] <= 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 360)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 5:
                        this.chartNgu.Series["ngu"].Points.AddXY("thứ 7", a[i]);

                        if (a[i] >= 360 && a[i] <= 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 360)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Red;

                        break;
                    case 6:
                        this.chartNgu.Series["ngu"].Points.AddXY("chủ nhật", a[i]);

                        if (a[i] >= 360 && a[i] <= 480)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Aqua;
                        if (a[i] < 360)
                            chartNgu.Series["ngu"].Points[i].Color = Color.Green;
                        if (a[i] > 8)
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
            danhgia();
        }

        public double[] TackCaloWeek(List<CaloTuan> caloTuans)
        {
            double[] t = new double[7];
            double tong = 0;
            for (int i = 0; i < caloTuans.Count; i++)
            {
                t[i] = double.Parse(caloTuans[i].total);
                tong = tong + t[1];
            }
            Tongcalotuannay = tong;
            return t;
        }
        public double[] TackwaterWeek(List<CaloTuan> caloTuans)
        {
            double[] t = new double[7];
            double tong = 0;
            for (int i = 0; i < caloTuans.Count; i++)
            {
                t[i] = double.Parse(caloTuans[i].total);
                tong = tong + t[1];
            }
            TongMinituannay = tong;
            return t;
        }
        public double[] TackTimerWeek(List<CaloTuan> caloTuans)
        {
            double[] t = new double[7];
            double tong = 0;

            for (int i = 0; i < caloTuans.Count; i++)
            {
                t[i] = double.Parse(caloTuans[i].total);
            }
            TongThoiGiantuannay = tong;
            return t;
        }

        public  void TackCaloLastWeek(List<CaloTuan> caloTuans)
        {
            double[] t = new double[7];
            double tong = 0;
            for (int i = 0; i < caloTuans.Count; i++)
            {
                t[i] = double.Parse(caloTuans[i].total);
                tong = tong + t[1];
            }
            TongcalotuanTruoc = tong;
        }
        public void TackWaterLastWeek(List<CaloTuan> caloTuans)
        {
            double[] t = new double[7];
            double tong = 0;
            for (int i = 0; i < caloTuans.Count; i++)
            {
                t[i] = double.Parse(caloTuans[i].total);
                tong = tong + t[1];
            }
            TongMinituanTruoc = tong;
        }
        public void TackTimeLastWeek(List<CaloTuan> caloTuans)
        {
            double[] t = new double[7];
            double tong = 0;
            for (int i = 0; i < caloTuans.Count; i++)
            {
                t[i] = double.Parse(caloTuans[i].total);
                tong = tong + t[1];
            }
            TongThoiGiantuantruoc = tong;
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
            danhgia();

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
            danhgia();

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
            String apiUrl = "/api/eating-habits/statistical-total-calo-in-week?week=" + ngay;

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
            String apiUrl = "/api/drinking-habits/statistical-total-mili-in-week?week=" + ngay;

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

        private async void button2_Click(object sender, EventArgs e)
        {
            TimeCTN = DateTime.Now;
            string ngay = TimeCTN.ToString("dd/MM/yyyy");

            List<CaloTuan> caloTuans = await GetCaloTuan(ngay);
            List<CaloTuan> waters = await GetWaterTuan(ngay);
            List<CaloTuan> Sleep = await GetSleepTuan(ngay);

            this.chartAn.Series["an"].Points.Clear();
            this.chartUong.Series["uong"].Points.Clear();
            this.chartNgu.Series["ngu"].Points.Clear();

            loadAn(TackCaloWeek(caloTuans));
            loadUong(TackwaterWeek(waters));
            loadNgu(TackTimerWeek(Sleep));
        }

        public async void danhgia()
        {
            DateTime date = TimeCTN.AddDays(-7);
            List<CaloTuan> caloTuans = await GetCaloTuan(date.ToString("dd/MM/yyyy"));
            List<CaloTuan> waters = await GetWaterTuan(date.ToString("dd/MM/yyyy"));
            List<CaloTuan> Sleep = await GetSleepTuan(date.ToString("dd/MM/yyyy"));

            TackCaloLastWeek(caloTuans);
            TackwaterWeek(waters);
            TackTimerWeek(Sleep);
            double resuit1 = Tongcalotuannay - TongcalotuanTruoc;
            double resuit2 = TongMinituannay - TongMinituanTruoc;
            double resuit3 = TongThoiGiantuannay - TongThoiGiantuantruoc;

            string t1 = "";
            string t2="";
            string t3="";
            if (resuit1 < 0)
            {
                t1 = ". Đã giảm " + resuit1 * (-1) + " so vớ tuần trước";
            }
            else if (resuit1 == 0)
            {
                t1 = ". Không có thay đổi " + " so vớ tuần trước";
            }
            else if (resuit1 > 0)
            {
                t1 = ". Đã tăng " + resuit1 * (1) + " so vớ tuần trước";
            }

            if (resuit2 < 0)
            {
                t2 = ". Đã giảm " + resuit2 * (-1) + " so vớ tuần trước";
            }
            else if (resuit2 == 0)
            {
                t2 = ". Không có thay đổi " + " so vớ tuần trước";
            }
            else if (resuit2 > 0)
            {
                t2 = ". Đã tăng " + resuit2 * (1) + " so vớ tuần trước";
            }

            if (resuit3 < 0)
            {
                t3 = ". Đã giảm " + resuit3 * (-1) + " so vớ tuần trước";
            }
            else if (resuit3 == 0)
            {
                t3 = ". Không có thay đổi " + " so vớ tuần trước";
            }
            else if (resuit3 > 0)
            {
                t3 = ". Đã tăng " + resuit3 * (1) + " so vớ tuần trước";
            }

            richTextBox1.Text = " Đánh giá tuần này:"
                                + "\n lượng calories tuần này =" + Tongcalotuannay +"Calories "+ t1
                               + "\n lượng nước tuần này =" + TongMinituannay + "Mililit Nước "+t2
                               + "\n lượng thời gian ngủ tuần này =" + TongThoiGiantuannay + "Phút "+ t3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBMI frmBMI = new FrmBMI();
            this.Hide();
            frmBMI.Show();
        }
    }
}
