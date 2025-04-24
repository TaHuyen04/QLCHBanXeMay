using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLCHBanXeMay.Class
{
    internal class KetNoi
    {
        public static SqlConnection Conn;
        public static string Connstring;
        public static void Ketnoi()
        {
            Connstring = "Data Source=DESKTOP-R3DMC9I;Initial Catalog=QL_BanXeMay;Integrated Security=True ";
            Conn = new SqlConnection();
            Conn.ConnectionString = Connstring;
            Conn.Open();
            MessageBox.Show("Ket noi thanh cong");
        }
    }
}
