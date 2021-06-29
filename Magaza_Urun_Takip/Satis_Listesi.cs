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

namespace Magaza_Urun_Takip
{
    public partial class Satis_Listesi : Form
    {
        public Satis_Listesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2HOS6DT\SQLEXPRESS;Initial Catalog=MagazaUrunTakip;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("Execute Proje6",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
