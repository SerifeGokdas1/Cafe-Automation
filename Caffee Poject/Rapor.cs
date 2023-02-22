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
using System.Reflection;

namespace Caffee_Poject
{
    public partial class Rapor : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-V44T9NQ\\SQLEXPRESS; Database=Kafe;Integrated Security=true;");
        public void Method(String scode)
        {
            SqlDataAdapter dp = new SqlDataAdapter(scode, con);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public Rapor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Method("select * from Personeller p inner join Urunler u on p.PersonelNo=u.PersonelNo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Method("select * from Siparişler where SiparisAdet=2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Method("select * from Urunler u inner join Kullanicilar k on u.PersonelNo = k.PersonelNo where k.PersonelNo = 1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Anasayfapersonel go = new Anasayfapersonel();
            go.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anasayfapersonel go = new Anasayfapersonel();
            go.Show();
            this.Hide();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {

        }
    }
}
