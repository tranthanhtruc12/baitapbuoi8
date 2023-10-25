using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class QLKhoa : Form
    {

        KetNoi kn = new KetNoi();
        SqlConnection consql;
       
        public QLKhoa()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source = <A209PC28>;Initial Catalog = <PHUQUY>; Integrated Security = True");
              
       }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnection consql;
                if(consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }

                string insertString;
                insertString = "insert into Khoa values('" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, consql);
                cmd.ExecuteNonQuery();
                if(consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }

                MessageBox.Show("Thanh Cong");
            }

            catch(Exception ex)
            {
                MessageBox.Show("That Bai");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateString = "Update khoa set TenKhoa='" + txtTenKhoa.Text + "'where MaKhoa='"+ txtMaKhoa.Text + "'";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteString = "delete Khoa where MaKhoa='" + txtMaKhoa.Text + "'";
        }
    }
}
