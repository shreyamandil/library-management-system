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
    public partial class staff_form : Form
    {
        public staff_form()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-V5KUJ3H;Initial Catalog= libraby managment;User ID=sa;Password=123456");
        SqlCommand cmd;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into staff_info(name,post,email_id,contact_no)values(@name,@post,@email_id,@contact_no)", con);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@post", textBox3.Text);
            cmd.Parameters.AddWithValue("@email_id", textBox4.Text);
            cmd.Parameters.AddWithValue("@contact_no", Convert.ToInt32(textBox5.Text));
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
            Form2 FRM = new Form2();
            FRM.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
