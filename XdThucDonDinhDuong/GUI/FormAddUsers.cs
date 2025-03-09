using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XdThucDonDinhDuong.GUI;

namespace XdThucDonDinhDuong
{
    public partial class FrmAddUsers: Form
    {
        private FormDsUsers parentForm; //Khai báo biến lưu form cha
        public FrmAddUsers(FormDsUsers parent)
        {
            InitializeComponent();
            this.parentForm = parent; //Lưu lại form cha
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttBack_Click(object sender, EventArgs e)
        {
            this.Close();//Đóng form hiện tại
            parentForm.Show(); //Hiển thị lại form danh sách ng dùng
            
        }
    }
}
