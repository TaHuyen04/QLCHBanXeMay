using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanXeMay.form
{
    public partial class frmCongviec : Form
    {
        public frmCongviec()
        {
            InitializeComponent();
        }

        private void frmCongviec_Load(object sender, EventArgs e)
        {
            txtTenCongViec.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;

        }

        private void txtTenCongViec_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuongthang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMacongviec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void grvCongviec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }
    }
}
