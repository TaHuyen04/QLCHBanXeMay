using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHBanXeMay.Class;

namespace QLCHBanXeMay.form
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Class.KetNoi.Ketnoi();
        }

        private void loạiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaixe frmLoaixe = new frmLoaixe();
            frmLoaixe.ShowDialog();
        }

        private void độngCơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDongco frmDongco = new frmDongco();
            frmDongco.ShowDialog();
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMausac frmMausac = new frmMausac();
            frmMausac.ShowDialog();
        }

        private void tìnhTrạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTinhtrang frmTinhtrang = new frmTinhtrang();
            frmTinhtrang.ShowDialog();
        }

        private void phanhXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhanhxe frmPhanhxe = new frmPhanhxe();
            frmPhanhxe.ShowDialog();
        }

        private void hãngSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangSX frmHangSX = new frmHangSX();
            frmHangSX.ShowDialog();
        }

        private void nướcSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuocSX frmNuocSX = new frmNuocSX();
            frmNuocSX.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanpham frmSanpham = new frmSanpham();
            frmSanpham.ShowDialog();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadonnhap frmHoadonnhap = new frmHoadonnhap();
            frmHoadonnhap.ShowDialog();
        }

        private void chiTiếtHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChitietHDN frmChitietHDN = new frmChitietHDN();
            frmChitietHDN.ShowDialog();
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDondathang frmDondathang = new frmDondathang();
            frmDondathang.ShowDialog();
        }

        private void chiTiếtHóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChitietdondathang frmChitietdondathang = new frmChitietdondathang();
            frmChitietdondathang.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien frmNhanvien = new frmNhanvien();
            frmNhanvien.ShowDialog();
        }

        private void côngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCongviec frmCongviec = new frmCongviec();
            frmCongviec.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachhang frmKhachhang = new frmKhachhang();
            frmKhachhang.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNCC frmNCC = new frmNCC();
            frmNCC.ShowDialog();
        }

        private void báoCáoNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaocao frmBaocao = new frmBaocao();
            frmBaocao.ShowDialog();
        }

        private void thốngKêBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongke frmThongke = new frmThongke();
            frmThongke.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
