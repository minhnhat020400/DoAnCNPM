using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MyHabit
{
    public partial class FrmSleep : Form
    {
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
        public string Token;
        public class Login
        {
            public string from { get; set; }
            public string to { get; set; }
            

        }

        // vì server trả về một string nên ở dây là 
        public static async Task<String> test(string fr, string t)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            /*client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "token");*/

            // Link api
            String apiUrl = "/api/sleeping-habit/add-sleeping-hour";

            // Model để gửi dữ liệu lên server
            Login login = new Login()
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
        public FrmSleep()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer();
            ringForm = new ringringForm(this); 
        }

        private void FrmSleep_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTime.Text = DateTime.Now.ToString("h:mm tt");
            GetSetting();
            UpdateData();
        }
        private void UpdateData()
        {
            for(int i = 1; i <=12; i ++)
            {
                cmbHour.Items.Add(i.ToString());
            }
            for(int i = 0; i <= 59; i++)
            {
                if(i < 10)
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
            seclectedTime = cmbHour.Text + ":" + cmbMinute.Text + " " + cmbAMPM.Text;

            DateTime t1 = Convert.ToDateTime(txtTime.Text);
            DateTime t2 = Convert.ToDateTime(seclectedTime);

            TimeSpan time = t2.Subtract(t1);
            txtketqua.Text = time.TotalSeconds.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            SaveSetting();
            var Token = await test(txtfr.Text, txtt.Text);
        }
        public void GetSetting()
        {
            lbfr.Text = Properties.Settings.Default.FR;
            lbt.Text = Properties.Settings.Default.T;
        }
        public void SaveSetting()
        {
            Properties.Settings.Default.FR = txtfr.Text;
            Properties.Settings.Default.T = txtt.Text;
            

            Properties.Settings.Default.Save();
        }
    }
}
