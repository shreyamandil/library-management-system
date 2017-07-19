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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-V5KUJ3H;Initial Catalog= libraby managment;User ID=sa;Password=123456");
        SqlCommand cmd;
        SqlDataReader dr;



        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into book_info(book_no,subject,name_of_the_book,edition,author,copies)values(@book_no,@subject,@name_of_the_book,@edition,@author,@copies)", con);
            cmd.Parameters.AddWithValue("@book_no", textBox2.Text);
            cmd.Parameters.AddWithValue("@subject", textBox7.Text);
            cmd.Parameters.AddWithValue("@name_of_the_book", textBox1.Text);
            cmd.Parameters.AddWithValue("@edition", textBox3.Text);
            cmd.Parameters.AddWithValue("@author", textBox5.Text);
            cmd.Parameters.AddWithValue("@copies",Convert.ToInt32(textBox4.Text));
            int k = cmd.ExecuteNonQuery();
            if (k>0)
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

