using MyHabit.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHabit
{
    public partial class FrmCMS : Form
    {
        double _sang, _trua, _chieu, _tong, _nuoc, _ngu;

        string seclectedTime;
        string seclectedSnooze;
        string seclectedRingtone;
        string seclectedMessage;

        bool alarmSet = false;

        string snoozeTime;
        bool snoozeSet = false;

        string wavpath = @"D:\Ringtone\";
        SoundPlayer soundPlayer;

        ringringForm ringForm;

        static HttpClient client = new HttpClient();

        public static string Token1 = FrmLogin.Token;

        // API sleep////////////////////////////
        public class Hour
        {
            public string from { get; set; }
            public string to { get; set; }


        }

        // vì server trả về một string nên ở dây là 
        public static async Task<String> posttime(string fr, string t)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token1);

            // Link api
            String apiUrl = "/api/sleeping-habit/add-sleeping-hour";

            // Model để gửi dữ liệu lên server
            Hour login = new Hour()
            {
                from = fr,
                to = t,

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
        
        // API eat///////////////////////////////////////////
        public class Eat
        {
            public string breakfastCalo { get; set; }
            public string dinnerCalo { get; set; }
            public string lunchCalo { get; set; }

        }

        // vì server trả về một string nên ở dây là 
        public static async Task<String> postcalo(string bfc, string lc, string dc)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token1);

            // Link api
            String apiUrl = "/api/eating-habits/input-calo";

            // Model để gửi dữ liệu lên server
            Eat login = new Eat()
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
        //drink////////////////////////////////////////
        public class Drink
        {
            public string total { get; set; }
           


        }

        // vì server trả về một string nên ở dây là 
        public static async Task<String> postdrink(string tt)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token1);

            // Link api
            String apiUrl = "/api/drinking-habits/input-mili-water";

            // Model để gửi dữ liệu lên server
            Drink login = new Drink()
            {
                total = tt,
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
        /// <summary>
        /// //////////////////////////////////////////////////
        /// </summary>
        public FrmCMS()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer();
            ringForm = new ringringForm(this);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            SaveSetting();
            var Token1 = await postcalo(txtSang.Text, txtTrua.Text, txtChieu.Text);
        }

        private void FrmCMS_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTime.Text = DateTime.Now.ToString("h:mm tt");
            GetSetting();
            UpdateData();
                  
        }
        private void UpdateData()
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbHour.Items.Add(i.ToString());
            }
            for (int i = 0; i <= 59; i++)
            {
                if (i < 10)
                {
                    cmbMinute.Items.Add("0" + i.ToString());
                }
                else
                {
                    cmbMinute.Items.Add(i.ToString());
                }
            }
            cmbAMPM.Items.Add("AM");
            cmbAMPM.Items.Add("PM");

            cmbSnooze.Items.Add("1");
            cmbSnooze.Items.Add("5");
            cmbSnooze.Items.Add("10");
            cmbSnooze.Items.Add("15");

            string[] wavFiles = Directory.GetFiles(wavpath, "*.wav");

            foreach (string wavFile in wavFiles)
            {
                string wavName = wavFile.Replace(wavpath, string.Empty);
                wavName = wavName.Replace(".wav", string.Empty);
                listRingtone.Items.Add(wavName);
            }

        }

        private void btnHome_Click_1(object sender, EventArgs e)
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

            lbml.Text = Properties.Settings.Default.ML.ToString();

            lbfr.Text = Properties.Settings.Default.FR;
            lbt.Text = Properties.Settings.Default.T;
        }
        public void SaveSetting()
        {
            Properties.Settings.Default.Calo1 = Convert.ToInt32(txtSang.Text);
            Properties.Settings.Default.Calo2 = Convert.ToInt32(txtTrua.Text);
            Properties.Settings.Default.Calo3 = Convert.ToInt32(txtChieu.Text);

           

            Properties.Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveSetting1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
       
        public void SaveSetting1()
        {
            Properties.Settings.Default.ML = Convert.ToInt32(txtNuoc.Text);

            Properties.Settings.Default.Save();
        }
        public void SaveSetting2()
        {
            Properties.Settings.Default.FR = txtfr.Text;
            Properties.Settings.Default.T = txtt.Text;


            Properties.Settings.Default.Save();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            seclectedTime = cmbHour.Text + ":" + cmbMinute.Text + " " + cmbAMPM.Text;
            seclectedSnooze = cmbSnooze.Text;
            seclectedRingtone = listRingtone.Text;
            seclectedMessage = richtxtMesaage.Text;

            soundPlayer.SoundLocation = wavpath + seclectedRingtone + ".wav";

            ringForm.Message(seclectedMessage);

            groupBox1.Enabled = false;
            alarmSet = true;
        }
        public void Snooze()
        {
            try
            {
                soundPlayer.Stop();
            }
            catch
            { }

            DateTime dateTime = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(0, Convert.ToInt32(seclectedSnooze), 0);
            snoozeTime = dateTime.Add(timeSpan).ToString("h:mm tt");

            snoozeSet = true;
        }
        public void Resume()
        {
            try
            {
                soundPlayer.Stop();
            }
            catch
            { }
            groupBox1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTime.Text = DateTime.Now.ToString("h:mm tt");

            if (alarmSet)
            {
                if (txtTime.Text == seclectedTime)
                {
                    alarmSet = false;

                    soundPlayer.Play();
                    ringForm.ShowDialog();
                }
            }
            else if (snoozeSet)
            {
                if (txtTime.Text == snoozeTime)
                {
                    snoozeSet = false;
                    soundPlayer.Play();
                    ringForm.ShowDialog();
                }
            }
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            //seclectedTime = cmbHour.Text + ":" + cmbMinute.Text + " " + cmbAMPM.Text;

            //DateTime t1 = Convert.ToDateTime(txtTime.Text);
            //DateTime t2 = Convert.ToDateTime(seclectedTime);

            //TimeSpan time = t2.Subtract(t1);
            //txtketqua.Text = time.TotalSeconds.ToString();
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            SaveSetting2();
            var Token1 = await posttime(txtfr.Text, txtt.Text);
        }

        private void pb_str5_Click(object sender, EventArgs e)
        {

        }

        private void pb_str4_Click(object sender, EventArgs e)
        {

        }

        private void pb_str3_Click(object sender, EventArgs e)
        {

        }

        private void pb_str2_Click(object sender, EventArgs e)
        {

        }

        private void pb_str1_Click(object sender, EventArgs e)
        {

        }

        private void pb_str5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pb_str4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pb_str3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnRate1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSang.Text))
            {
                MessageBox.Show("Vui lòng nhập calo buổi sáng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSang.Focus();
            }
            if (string.IsNullOrEmpty(txtTrua.Text))
            {
                MessageBox.Show("Vui lòng nhập calo buổi trưa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrua.Focus();
            }
            if (string.IsNullOrEmpty(txtChieu.Text))
            {
                MessageBox.Show("Vui lòng nhập calo buổi chiều!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChieu.Focus();
            }

            if (!double.TryParse(txtSang.Text, out _sang))
            {
                MessageBox.Show("Vui lòng nhập calo buổi sáng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSang.Focus();
            }
            if (!double.TryParse(txtTrua.Text, out _trua))
            {
                MessageBox.Show("Vui lòng nhập calo buổi trưa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrua.Focus();
            }
            if (!double.TryParse(txtChieu.Text, out _chieu))
            {
                MessageBox.Show("Vui lòng nhập calo buổi chiều!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChieu.Focus();
            }


            _sang = double.Parse(txtSang.Text);
            _trua = double.Parse(txtTrua.Text);
            _chieu = double.Parse(txtChieu.Text);
            _tong = _sang + _trua + _chieu;
            txtTongcalo.Text = _tong.ToString();

            if(_tong < 1500)
            {
                txtDG.Text = "Bạn cần nạp thêm calo trong ngày.";

                pb2.Image = Resources.white_star;
                pb3.Image = Resources.white_star;
                pb4.Image = Resources.white_star;
                pb5.Image = Resources.white_star;

                pb1.Image = Resources.yellow_star;
                lbl_ratings.Text = "1";
            }
            else if (_tong == 1500 )
            {
                txtDG.Text = "1.500 calo mỗi ngày để giảm một pound cân nặng mỗi tuần.";

                pb5.Image = Resources.white_star;

                pb1.Image = Resources.yellow_star;
                pb2.Image = Resources.yellow_star;
                pb3.Image = Resources.yellow_star;
                pb4.Image = Resources.yellow_star;
                lbl_ratings.Text = "4";
            }
            else if(_tong > 1500 && _tong < 1899)
            {
                txtDG.Text = "Bạn cần nạp thêm calo trong ngày.";

                pb4.Image = Resources.white_star;
                pb5.Image = Resources.white_star;

                pb1.Image = Resources.yellow_star;
                pb2.Image = Resources.yellow_star;
                pb3.Image = Resources.yellow_star;
                lbl_ratings.Text = "3";
            }
            else if(_tong >=1900 && _tong <=2000)
            {
                txtDG.Text = "Lượng calo lý tưởng trong ngày.";

                pb1.Image = Resources.yellow_star;
                pb2.Image = Resources.yellow_star;
                pb3.Image = Resources.yellow_star;
                pb4.Image = Resources.yellow_star;
                pb5.Image = Resources.yellow_star;
                lbl_ratings.Text = "5";
            }
            else
            {
                txtDG.Text = "Bạn nạp thừa lượng calo trong ngày";

                pb3.Image = Resources.white_star;
                pb4.Image = Resources.white_star;
                pb5.Image = Resources.white_star;

                pb1.Image = Resources.yellow_star;
                pb2.Image = Resources.yellow_star;
                lbl_ratings.Text = "2";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnDGG_Click(object sender, EventArgs e)
        {
            _nuoc = double.Parse(txtNuoc.Text);

            if(_nuoc < 1600)
            {
                txtDG2.Text = "Bạn cần uống thêm nước trong ngày!";

                pb44.Image = Resources.white_star;
                pb55.Image = Resources.white_star;

                pb11.Image = Resources.yellow_star;
                pb22.Image = Resources.yellow_star;
                pb33.Image = Resources.yellow_star;
                lbl_ratings2.Text = "3";
            }
            else if (_nuoc >=1600 && _nuoc <=2000)
            {
                txtDG2.Text = "Bạn đã uống đủ lượng nước trong ngày!";

                pb11.Image = Resources.yellow_star;
                pb22.Image = Resources.yellow_star;
                pb33.Image = Resources.yellow_star;
                pb44.Image = Resources.yellow_star;
                pb55.Image = Resources.yellow_star;
                lbl_ratings2.Text = "5";
            }
            else
            {
                txtDG2.Text = "Bạn đã uống hơn lượng nước trong ngày!";

                pb33.Image = Resources.white_star;
                pb44.Image = Resources.white_star;
                pb55.Image = Resources.white_star;

                pb11.Image = Resources.yellow_star;
                pb22.Image = Resources.yellow_star;
                lbl_ratings2.Text = "2";
            }  
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ratings_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBMI frm = new FrmBMI();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnrate3_Click(object sender, EventArgs e)
        {
            _ngu = double.Parse(txtketqua.Text);

            if(_ngu < 7)
            {
                txtrate3.Text = "Bạn nên ngủ đủ giấc trong ngày!";

                pb444.Image = Resources.white_star;
                pb555.Image = Resources.white_star;

                pb111.Image = Resources.yellow_star;
                pb222.Image = Resources.yellow_star;
                pb333.Image = Resources.yellow_star;
                lbl_ratings3.Text = "3";
            }    
            else if(_ngu >= 7 && _ngu <= 9)
            {
                txtrate3.Text = "Bạn đã ngủ đủ giấc trong ngày!";

                pb111.Image = Resources.yellow_star;
                pb222.Image = Resources.yellow_star;
                pb333.Image = Resources.yellow_star;
                pb444.Image = Resources.yellow_star;
                pb555.Image = Resources.yellow_star;
                lbl_ratings3.Text = "5";
            }
            else 
            {
                txtrate3.Text = "Bạn đã ngủ nhiều trong ngày!";

                pb333.Image = Resources.white_star;
                pb444.Image = Resources.white_star;
                pb555.Image = Resources.white_star;

                pb111.Image = Resources.yellow_star;
                pb222.Image = Resources.yellow_star;
                lbl_ratings3.Text = "2";
            }
        }

        private void btnRate2_Click(object sender, EventArgs e)
        {
            _sang = double.Parse(txtSang.Text);
            _trua = double.Parse(txtTrua.Text);
            _chieu = double.Parse(txtChieu.Text);
            _tong = _sang + _trua + _chieu;
            txtTongcalo.Text = _tong.ToString();

            if (_tong < 2000)
            {
                txtDG.Text = "Bạn cần nạp thêm calo trong ngày.";

                pb2.Image = Resources.white_star;
                pb3.Image = Resources.white_star;
                pb4.Image = Resources.white_star;
                pb5.Image = Resources.white_star;

                pb1.Image = Resources.yellow_star;
                lbl_ratings.Text = "1";
            }
            else if (_tong == 2000)
            {
                txtDG.Text = "1.500 calo mỗi ngày để giảm một pound cân nặng mỗi tuần.";

                pb5.Image = Resources.white_star;

                pb1.Image = Resources.yellow_star;
                pb2.Image = Resources.yellow_star;
                pb3.Image = Resources.yellow_star;
                pb4.Image = Resources.yellow_star;
                lbl_ratings.Text = "4";
            }
            else if (_tong > 2000 && _tong < 2399)
            {
                txtDG.Text = "Bạn cần nạp thêm calo trong ngày.";

                pb4.Image = Resources.white_star;
                pb5.Image = Resources.white_star;

                pb1.Image = Resources.yellow_star;
                pb2.Image = Resources.yellow_star;
                pb3.Image = Resources.yellow_star;
                lbl_ratings.Text = "3";
            }
            else if (_tong >= 2400 && _tong <= 2500)
            {
                txtDG.Text = "Lượng calo lý tưởng trong ngày.";

                pb1.Image = Resources.yellow_star;
                pb2.Image = Resources.yellow_star;
                pb3.Image = Resources.yellow_star;
                pb4.Image = Resources.yellow_star;
                pb5.Image = Resources.yellow_star;
                lbl_ratings.Text = "5";
            }
            else
            {
                txtDG.Text = "Bạn nạp thừa lượng calo trong ngày";

                pb3.Image = Resources.white_star;
                pb4.Image = Resources.white_star;
                pb5.Image = Resources.white_star;

                pb1.Image = Resources.yellow_star;
                pb2.Image = Resources.yellow_star;
                lbl_ratings.Text = "2";
            }
        }

        private void pb_str2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pb_str1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
