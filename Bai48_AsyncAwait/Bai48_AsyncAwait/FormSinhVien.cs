
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai48_AsyncAwait
{
    public partial class FormSinhVien : Form
    {
        public Action<int> CapNhatTienTrinh;

        public FormSinhVien()
        {
            InitializeComponent();
        }

        private async Task<List<SinhVien>> NapDuLieuAsync(
            IProgress<int> progress)
        {
            return await Task.Run(() =>
            {
                List<SinhVien> ds = new List<SinhVien>();

                for (int i = 1; i <= 100; i++)
                {
                    Thread.Sleep(50);

                    SinhVien sv = new SinhVien();

                    sv.MaSV = "SV" + i.ToString("000");
                    sv.HoTen = "Nguyễn Văn " + i;
                    sv.Lop = "D17CNPM" + (i % 3 + 1);
                    sv.Diem = Math.Round(
                        5.0 + (i % 50) / 10.0, 1);

                    ds.Add(sv);

                    progress.Report(i);
                }

                return ds;
            });
        }

        private async void btnNapDuLieu_Click(
            object sender, EventArgs e)
        {
            btnNapDuLieu.Enabled = false;

            progressBar1.Value = 0;
            lblPhanTram.Text = "0%";
            lblThongBao.Text = "Đang nạp dữ liệu...";

            dgvSinhVien.DataSource = null;

            try
            {
                CapNhatTienTrinh?.Invoke(0);

                Progress<int> progress = new Progress<int>(p =>
                {
                    progressBar1.Value = p;
                    lblPhanTram.Text = p + "%";

                    CapNhatTienTrinh?.Invoke(p);
                });

                List<SinhVien> ds =
                    await NapDuLieuAsync(progress);

                dgvSinhVien.DataSource = ds;

                progressBar1.Value = 100;
                lblPhanTram.Text = "100%";

                CapNhatTienTrinh?.Invoke(100);

                lblThongBao.Text =
                    "Đã nạp thành công " + ds.Count + " sinh viên";

                MessageBox.Show(
                    "Nạp dữ liệu thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblThongBao.Text = "Nạp dữ liệu thất bại";

                MessageBox.Show(
                    "Có lỗi xảy ra: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnNapDuLieu.Enabled = true;
            }
        }

        private void btnLamMoi_Click(
            object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = null;

            progressBar1.Value = 0;
            lblPhanTram.Text = "0%";
            lblThongBao.Text = "Sẵn sàng";

            CapNhatTienTrinh?.Invoke(0);
        }
    }
}
