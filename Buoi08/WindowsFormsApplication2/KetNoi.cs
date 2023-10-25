using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public class KetNoi
    {
        public SqlConnection connect;
        public KetNoi()
        {
            connect = new SqlConnection("Data Source = <A209PC28>;Initial Catalog=QLSINHVIEN;User ID=...;Password=...");
        }

        public KetNoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
}
