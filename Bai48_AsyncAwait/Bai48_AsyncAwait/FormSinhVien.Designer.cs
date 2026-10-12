
namespace Bai48_AsyncAwait
{
    partial class FormSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPhanTram;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnNapDuLieu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvSinhVien =
                new System.Windows.Forms.DataGridView();

            this.progressBar1 =
                new System.Windows.Forms.ProgressBar();

            this.lblPhanTram =
                new System.Windows.Forms.Label();

            this.lblThongBao =
                new System.Windows.Forms.Label();

            this.lblTieuDe =
                new System.Windows.Forms.Label();

            this.btnNapDuLieu =
                new System.Windows.Forms.Button();

            this.btnLamMoi =
                new System.Windows.Forms.Button();

            this.panel1 =
                new System.Windows.Forms.Panel();

            this.panel2 =
                new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvSinhVien)).BeginInit();

            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();

            // PANEL TIEU DE

            this.panel1.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panel1.Height = 65;

            this.panel1.BackColor =
                System.Drawing.Color.FromArgb(35, 65, 100);

            this.lblTieuDe.Text =
                "DANH SÁCH SINH VIÊN";

            this.lblTieuDe.ForeColor =
                System.Drawing.Color.White;

            this.lblTieuDe.Font =
                new System.Drawing.Font(
                    "Segoe UI", 16F,
                    System.Drawing.FontStyle.Bold);

            this.lblTieuDe.AutoSize = true;

            this.lblTieuDe.Location =
                new System.Drawing.Point(20, 15);

            this.panel1.Controls.Add(this.lblTieuDe);

            // PANEL DIEU KHIEN

            this.panel2.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.panel2.Height = 150;

            this.panel2.BackColor =
                System.Drawing.Color.WhiteSmoke;

            // PROGRESS BAR

            this.progressBar1.Location =
                new System.Drawing.Point(20, 20);

            this.progressBar1.Size =
                new System.Drawing.Size(650, 25);

            this.progressBar1.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;

            // PHAN TRAM

            this.lblPhanTram.Text = "0%";

            this.lblPhanTram.Location =
                new System.Drawing.Point(690, 20);

            this.lblPhanTram.Size =
                new System.Drawing.Size(70, 25);

            this.lblPhanTram.Font =
                new System.Drawing.Font(
                    "Segoe UI", 11F,
                    System.Drawing.FontStyle.Bold);

            this.lblPhanTram.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            // THONG BAO

            this.lblThongBao.Text = "Sẵn sàng";

            this.lblThongBao.Location =
                new System.Drawing.Point(20, 55);

            this.lblThongBao.AutoSize = true;

            this.lblThongBao.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            // NUT NAP DU LIEU

            this.btnNapDuLieu.Text = "Nạp dữ liệu";

            this.btnNapDuLieu.Location =
                new System.Drawing.Point(20, 90);

            this.btnNapDuLieu.Size =
                new System.Drawing.Size(140, 38);

            this.btnNapDuLieu.BackColor =
                System.Drawing.Color.SteelBlue;

            this.btnNapDuLieu.ForeColor =
                System.Drawing.Color.White;

            this.btnNapDuLieu.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnNapDuLieu.Click +=
                new System.EventHandler(
                    this.btnNapDuLieu_Click);

            // NUT LAM MOI

            this.btnLamMoi.Text = "Làm mới";

            this.btnLamMoi.Location =
                new System.Drawing.Point(175, 90);

            this.btnLamMoi.Size =
                new System.Drawing.Size(120, 38);

            this.btnLamMoi.Click +=
                new System.EventHandler(
                    this.btnLamMoi_Click);

            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.lblPhanTram);
            this.panel2.Controls.Add(this.lblThongBao);
            this.panel2.Controls.Add(this.btnNapDuLieu);
            this.panel2.Controls.Add(this.btnLamMoi);

            // DATAGRIDVIEW

            this.dgvSinhVien.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgvSinhVien.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvSinhVien.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvSinhVien.ReadOnly = true;

            this.dgvSinhVien.AllowUserToAddRows = false;

            this.dgvSinhVien.AllowUserToDeleteRows = false;

            this.dgvSinhVien.RowHeadersVisible = false;

            this.dgvSinhVien.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvSinhVien.AutoGenerateColumns = true;

            // FORM

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(800, 550);

            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);

            this.Name = "FormSinhVien";

            this.Text = "Quản lý sinh viên";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvSinhVien)).EndInit();

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();

            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}
