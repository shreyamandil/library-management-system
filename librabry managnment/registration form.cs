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
    public partial class registration_form : Form
    {
        public registration_form()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-V5KUJ3H;Initial Catalog= libraby managment;User ID=sa;Password=123456");
        SqlCommand cmd;
       

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into student_info(roll_no,name,contact_no,father_name,mother_name,address,branch,year)values(@roll_no,@name,@contact_no,@father_name,@mother_name,@address,@branch,@year)", con);
            cmd.Parameters.AddWithValue("@roll_no", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@contact_no", Convert.ToInt32(textBox3.Text));
            cmd.Parameters.AddWithValue("@father_name", textBox4.Text);
            cmd.Parameters.AddWithValue("@mother_name", textBox5.Text);
            cmd.Parameters.AddWithValue("@address", textBox6.Text);
            cmd.Parameters.AddWithValue("@branch", textBox7.Text);
            cmd.Parameters.AddWithValue("@year", Convert.ToInt32(textBox8.Text));
            int k = cmd.ExecuteNonQuery();
            if (k > 0)
            {
                MessageBox.Show("done");


            }
            else
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            book_view frm = new book_view();
            frm.Show();
            this.Hide();
        }
    }
}
