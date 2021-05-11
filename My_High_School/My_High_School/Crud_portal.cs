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
    public partial class Crud_portal : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\nikhilesh sinha\documents\visual studio 2012\Projects\My_High_School\My_High_School\Student_all_info.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Student_all_infoConnectionString);
        public int abc = 0;
        public Crud_portal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crud_portal cp = new Crud_portal();
            cp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display();
        }
        public void display() {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Student_details where roll_no = @c";
            cmd.Parameters.AddWithValue("@c", t2.Text);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
            dg1.DataSource = dt1;
            int i = cmd.ExecuteNonQuery();

            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Input !!");
                t2.Text = "";
            }
            else { abc = 1; }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (abc == 0) { MessageBox.Show("Enter Roll number First"); }
            else{
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update Student_details set " + cb1.Text + " = @ad where roll_no = @c ";
                cmd.Parameters.AddWithValue("@c", t2.Text);
                cmd.Parameters.AddWithValue("@ad", t1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Update Successfuly !!");
                t1.Text = "";
                cb1.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (abc == 0) { MessageBox.Show("Enter Roll number First"); }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update Student_details set optional = @ad where roll_no = @c ";
                cmd.Parameters.AddWithValue("@c", t2.Text);
                cmd.Parameters.AddWithValue("@ad", cb2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Update Successfuly !!");
                cb2.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (abc == 0) { MessageBox.Show("Enter Roll number First"); }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update Student_details set language = @ad where roll_no = @c ";
                cmd.Parameters.AddWithValue("@c", t2.Text);
                cmd.Parameters.AddWithValue("@ad", cb3.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Update Successfuly !!");
                cb3.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (abc == 0) { MessageBox.Show("Enter Roll number First"); }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update Student_details set DOB = @ad where roll_no = @c ";
                cmd.Parameters.AddWithValue("@c", t2.Text);
                cmd.Parameters.AddWithValue("@ad", dp.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Update Successfuly !!");
                dp.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (abc == 0) { MessageBox.Show("Enter Roll number First"); }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update Student_details set " + cb4.Text + " = @ad where roll_no = @c ";
                cmd.Parameters.AddWithValue("@c", t2.Text);
                cmd.Parameters.AddWithValue("@ad", t3.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Update Successfuly !!");
                t3.Text = "";
                cb4.Text = "";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (t4.Text == "") { MessageBox.Show("Enter Roll number First"); }
            else{
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete from Student_details where roll_no = @c";
            cmd.Parameters.AddWithValue("@c", t4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Entities has been sucessfully deleted !!!! ");
            con.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (t5.Text == "") { MessageBox.Show("Enter Roll number First"); }
            else
            {
                Certificate c = new Certificate(t5.Text);
                c.Show();
                this.Close();
            }
        }
    }
}
