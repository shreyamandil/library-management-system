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

namespace librabry_managnment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-V5KUJ3H;Initial Catalog= libraby managment;User ID=sa;Password=123456");
        SqlCommand cmd;
        SqlDataReader dr;


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            book_view frm = new book_view();
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration_form frm = new registration_form();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            staff_form frm = new staff_form();
            frm.Show();
            this.Hide();
        }
    }
}
