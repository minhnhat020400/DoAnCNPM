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

namespace MyHabit
{
    public partial class FrmMyInFo : Form
    {
        public FrmMyInFo()
        {
            InitializeComponent();
            chatSet();
        }
        static string token = FrmLogin.TokenMess;
        static string mess1;
        static string mess2;
        public static async Task<String> PutINfo(string date, string mail, string fn, int hei, string lastn, bool s, int wei)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://61.14.233.182");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            // bật cái dưới khi gọi api khác trừ login register forget password
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Link api
            String apiUrl = "/api/user/update-user-profile";

            // Model  để gửi dữ liệu lên server
            Info info = new Info();
            info.email = mail;
            info.dateOfBirth = date;
            info.firstName = fn;
            info.height = hei;
            info.lastName = lastn;
            info.sex = s;
            info.weight = wei;


            // POST dùng postAsJsonAsync có body
            // Get dùng GetAsync ko có body
            // PUT dùng PutAsJsonAsync có body
            // Delete dùng DeleteAsync ko có body
            HttpResponseMessage response = await client.PutAsJsonAsync(apiUrl, info); // login là body của api

            // Kiểm tra api có thành công hay ko
            if (response.IsSuccessStatusCode)
            {
                // nếu server trả về 1 chuổi thì mình dùng như cách bên dưới
                // server trả về một đối tượng thì dùng await response.Content.ReadAsAsync<Doi tuong>()
                var token = await response.Content.ReadAsStringAsync();
                mess1 = token;
                return token;
            }
            else
            {
                var token = await response.Content.ReadAsStringAsync();
                mess2 = token;
                return null;
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
        private bool check_number()
        {
            float a;
            float b;
            // tạo biến trya , đúng nếu có thể ép kiểu chiều cao qua số và đổ dữ liệu số vào biến a
            bool trya = float.TryParse(tbChieuCao.Text, out a);
            // tạo biến tryb , đúng nếu có thể ép kiểu cân nặng qua số và đổ dữ liệu số vào biến b
            bool tryb = float.TryParse(tbCanNang.Text, out b);
            if (!trya || !tryb)

            {
                if (tbChieuCao.Text == "" || tbChieuCao.Text == ""  )
                {
                    MessageBox.Show("Hay Nhận Đủ thông tin", "sai định dạnh", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    MessageBox.Show("Chỉ Cho Phép Nhập Số  Vào Chiều Cao Và Cân Nặng", "Sai định dạng", MessageBoxButtons.OK);
                    tbChieuCao.Text = "";
                    tbCanNang.Text = "";
                    return false;
                }
            }
            else
            {
                tbChieuCao.Text = a.ToString();
                tbCanNang.Text = b.ToString();
                return true;
            }
        }
        bool chatSet()
        {
            if (tickNam.Checked == true)
            {
                return true;
            }
            else if (tickNu.Checked == true)
            {
                return false;
            }
            else
                return true;
        
        }
        private async void btSave_Click(object sender, EventArgs e)
        {
            int h = int.Parse(tbChieuCao.Text);
            int w = int.Parse(tbCanNang.Text);
            var token = await PutINfo(dateTimePicker1.Value.ToString("dd/MM/yyyy"),tbDiaChi.Text,tbTen.Text,h,tbTen.Text,chatSet(),int.Parse(tbCanNang.Text)  );
            if (check_number() && token != null)
            {
                MessageBox.Show(mess1);
            }
            else MessageBox.Show(mess2);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (tickNu.Checked == true)
            {
                tickNam.Checked = false;
            }
        }

        private void tickNam_CheckedChanged(object sender, EventArgs e)
        {
            if (tickNam.Checked == true)
            {
                tickNu.Checked = false;
            }
        }
    }
}
