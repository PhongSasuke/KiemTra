using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiemtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (username == "admin" && password == "admin")
            {
                // Chuyển sang trang đăng nhập thành công
                FormDangNhap form2 = new FormDangNhap();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
            }
        }
    }
}
