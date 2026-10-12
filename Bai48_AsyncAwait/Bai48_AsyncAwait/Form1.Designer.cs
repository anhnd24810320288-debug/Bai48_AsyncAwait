
namespace Bai48_AsyncAwait
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuChucNang;
        private System.Windows.Forms.ToolStripMenuItem menuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem menuThongTin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuHeThong.Text = "Hệ thống";
            this.menuHeThong.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.menuThoat
                });

            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click +=
                new System.EventHandler(this.menuThoat_Click);

            this.menuChucNang.Text = "Chức năng";
            this.menuChucNang.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.menuSinhVien
                });

            this.menuSinhVien.Text = "Quản lý sinh viên";
            this.menuSinhVien.Click +=
                new System.EventHandler(this.menuSinhVien_Click);

            this.menuTroGiup.Text = "Trợ giúp";
            this.menuTroGiup.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.menuThongTin
                });

            this.menuThongTin.Text = "Thông tin";
            this.menuThongTin.Click +=
                new System.EventHandler(this.menuThongTin_Click);

            this.menuStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.menuHeThong,
                    this.menuChucNang,
                    this.menuTroGiup
                });

            this.menuStrip1.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.lblTrangThai.Text = "Sẵn sàng";

            this.statusStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.lblTrangThai
                });

            this.statusStrip1.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1100, 650);

            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);

            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;

            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Bài 4.8 - Quản lý sinh viên Async/Await";

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;

            this.Load +=
                new System.EventHandler(this.Form1_Load);

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();

            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
