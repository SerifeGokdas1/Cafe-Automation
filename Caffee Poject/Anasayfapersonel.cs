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

namespace Caffee_Poject
{
    public partial class Anasayfapersonel : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-V44T9NQ\\SQLEXPRESS; Database=Kafe;Integrated Security=true;");
        public Anasayfapersonel()
        {
            InitializeComponent();
        }

        private void Anasayfapersonel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ürünlerpersonel go = new Ürünlerpersonel();
            go.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Müşteriler go = new Müşteriler();
            go.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rapor go = new Rapor();
            go.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
