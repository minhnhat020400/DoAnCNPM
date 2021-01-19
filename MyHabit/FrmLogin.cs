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
    public partial class FrmLogin : Form
    {
        static HttpClient client = new HttpClient();
        public string Token;
        public class Login
        {
            public string userName { get; set; }
            public string password { get; set; }

        }

        // vì server trả về một string nên ở dây là 
        public static async Task<String> test(string name, string pass)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            /*client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "token");*/

            // Link api
            String apiUrl = "/api/auth/login";

            // Model để gửi dữ liệu lên server
            Login login = new Login()
            {
                userName = name,
                password = pass,
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

            public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btGetIn_Click(object sender, EventArgs e)
        {
            var Token = await test(txtName.Text, txtPass.Text);
            if (Token != null)
            {
                FrmMain frm = new FrmMain();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!!!!");
            }
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCreateAcc_Click(object sender, EventArgs e)
        {
            FrmCreateAccount  createAccount= new FrmCreateAccount();
            this.Hide();
            createAccount.Show();
        }

        private void btChagePass_Click(object sender, EventArgs e)
        {
            FrmforgetPassword frmChagePassWord = new FrmforgetPassword();
            frmChagePassWord.ShowDialog();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // this.TopMost = true;
            // this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

    }
}
