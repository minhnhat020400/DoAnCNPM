using LiveCharts;
using LiveCharts.Wpf;
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

namespace MyHabit
{
    public partial class FrmEat : Form
    {
        static HttpClient client = new HttpClient();
        public string Token;
        public class Login
        {
            public string breakfastCalo { get; set; }
            public string dinnerCalo { get; set; }
            public string lunchCalo { get; set; }

        }

        // vì server trả về một string nên ở dây là 
        public static async Task<String> test(string bfc, string lc, string dc)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            /*client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "token");*/

            // Link api
            String apiUrl = "/api/eating-habits/input-calo";

            // Model để gửi dữ liệu lên server
            Login login = new Login()
            {
                breakfastCalo = bfc,
                dinnerCalo = dc,
                lunchCalo = lc,
            };

            // POST dùng postAsJsonAsync có body
            // Get dùng GetAsync ko có body
            // PUT dùng PutAsJsonAsync có body
            // Delete dùng DeleteAsync ko có body
            HttpResponseMessage response = await client.PostAsJsonAsync(
                apiUrl, login); // login là body của api

            // Kiểm tra api có thành công hay ko
            if (response.IsSuccessStatusCode)
            {
                // nếu server trả về 1 chuổi thì mình dùng như cách bên dưới
                // server trả về một đối tượng thì dùng await response.Content.ReadAsAsync<Doi tuong>()
                var token = await response.Content.ReadAsStringAsync();
                return token;
            }
            else
            {
                var token = await response.Content.ReadAsStringAsync();
                return null;
            }
        }
        public FrmEat()
        {
            InitializeComponent();
        }
        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        private void Eat_Load(object sender, EventArgs e)
        {
            GetSetting();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            SaveSetting();
            var Token = await test(txtSang.Text, txtTrua.Text, txtChieu.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
        public void GetSetting()
        {
            lbSang.Text = Properties.Settings.Default.Calo1.ToString();
            lbTrua.Text = Properties.Settings.Default.Calo2.ToString();
            lbChieu.Text = Properties.Settings.Default.Calo3.ToString();
        }
        public void SaveSetting()
        {
            Properties.Settings.Default.Calo1 = Convert.ToInt32(txtSang.Text);
            Properties.Settings.Default.Calo2 = Convert.ToInt32(txtTrua.Text);
            Properties.Settings.Default.Calo3 = Convert.ToInt32(txtChieu.Text);

            Properties.Settings.Default.Save();
        }
    }
}
