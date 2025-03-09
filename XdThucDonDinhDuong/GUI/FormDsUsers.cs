using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;//Đọc dữ liệu kết nối từ App.config

namespace XdThucDonDinhDuong.GUI
{
    public partial class FormDsUsers: Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        public FormDsUsers()
        {
            InitializeComponent();
        }


     

        private void FormDsUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddUsers addUser = new FrmAddUsers(this);//Tạo form mới và truyền form hiện tại vào
            this.Hide();//Ẩn form danh sách người dùng
            addUser.ShowDialog();//Mở trang dưới dạng hộp thoại, ko tương tác đc với form trước
            this.Show();//Khi đóng form thêm người dùng, form danh sách sẽ hiển thị lại
            
            
        }

        private void dgvDsUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
