
using System;
using System.Windows.Forms;

namespace Bai48_AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MoFormSinhVien();
        }

        private void MoFormSinhVien()
        {
            foreach (Form f in MdiChildren)
            {
                if (f is FormSinhVien)
                {
                    f.Activate();
                    return;
                }
            }

            FormSinhVien frm = new FormSinhVien();

            frm.MdiParent = this;

            frm.CapNhatTienTrinh = CapNhatTrangThai;

            frm.Show();
        }

        public void CapNhatTrangThai(int phanTram)
        {
            lblTrangThai.Text =
                "Đang nạp dữ liệu: " + phanTram + "%";
        }

        private void menuSinhVien_Click(object sender, EventArgs e)
        {
            MoFormSinhVien();
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bài 4.8 - Async/Await & ProgressBar\n" +
                "Ứng dụng quản lý sinh viên",
                "Thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
