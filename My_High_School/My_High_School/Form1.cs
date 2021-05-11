using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace My_High_School
{
    public partial class Form1 : Form
    {
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\nikhilesh sinha\documents\visual studio 2012\Projects\My_High_School\My_High_School\Student_all_info.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Student_all_infoConnectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(th1.Text) > 70 || int.Parse(th2.Text) > 70 || int.Parse(th3.Text) > 70 || int.Parse(th4.Text) > 70 || int.Parse(th5.Text) > 70 || int.Parse(pa1.Text) > 30 || int.Parse(pa2.Text) > 30 || int.Parse(pa3.Text) > 30 || int.Parse(pa4.Text) > 30 || int.Parse(pa5.Text) > 30 ) 
            {
                MessageBox.Show("Some of your marks are given Wrong value\nPlease chech them");
            }
            else{
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Student_details values('" + t5.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "','" + t1.Text + "','" + dp.Text + "','" + t6.Text + "','" + t7.Text + "','" + cb1.Text + "','" + cb2.Text + "','" + cb3.Text + "','" + cb4.Text + "','" + cb5.Text + "', " + pa1.Text + ", " + th1.Text + ", " + pa2.Text + ", " + th2.Text + ", " + pa3.Text + ", " + th3.Text + ", " + pa4.Text + ", " + th4.Text + ", " + pa5.Text + ", " + th5.Text + ",'"+cb6.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Entities has been sucessfully inserted !!!!!");
            t1.Text = ""; t2.Text = ""; t3.Text = ""; t4.Text = ""; t5.Text = ""; t6.Text = ""; t7.Text = "";
            pa1.Text = ""; pa2.Text = ""; pa3.Text = ""; pa4.Text = ""; pa5.Text = "";
            th1.Text = ""; th2.Text = ""; th3.Text = ""; th4.Text = ""; th5.Text = "";
            cb1.Text = ""; cb2.Text = ""; cb3.Text = ""; cb4.Text = ""; cb5.Text = ""; cb6.Text = "";
            con.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crud_portal cp = new Crud_portal();
            cp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
