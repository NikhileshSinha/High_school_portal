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
    public partial class Certificate : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\nikhilesh sinha\documents\visual studio 2012\Projects\My_High_School\My_High_School\Student_all_info.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Student_all_infoConnectionString);
        public Certificate()
        {
            InitializeComponent();
        }
        public Certificate(string rol) {
            InitializeComponent();
            display(rol);
        }
        public void display(string rol) {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Student_details where roll_no = @c";
            cmd.Parameters.AddWithValue("@c", rol);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) {
                l1.Text = dr["Student_name"].ToString();
                l2.Text = dr["father_name"].ToString();
                l3.Text = dr["Mother_name"].ToString();
                l4.Text = dr["language"].ToString();
                l5.Text = dr["optional"].ToString();
                l6.Text = dr["maths"].ToString();
                l7.Text = dr["science"].ToString();
                l8.Text = dr["social_science"].ToString();
                l9.Text = dr["school_name"].ToString();
                l10.Text = dr["roll_no"].ToString();
                l11.Text = dr["registration_no"].ToString();
                l12.Text = dr["Session"].ToString();
                l13.Text = dr["DOB"].ToString();

                p1.Text = dr["p_lan"].ToString();
                p2.Text = dr["p_opt"].ToString();
                p3.Text = dr["p_mat"].ToString();
                p4.Text = dr["p_sci"].ToString();
                p5.Text = dr["p_ss"].ToString();

                t1.Text = dr["t_lan"].ToString();
                t2.Text = dr["t_opt"].ToString();
                t3.Text = dr["t_mat"].ToString();
                t4.Text = dr["t_sci"].ToString();
                t5.Text = dr["t_ss"].ToString();

                int a = int.Parse(p1.Text) + int.Parse(t1.Text) ;
                tt1.Text = a.ToString();

                int b = int.Parse(p2.Text) + int.Parse(t2.Text);
                tt2.Text = b.ToString();

                int c = int.Parse(p3.Text) + int.Parse(t3.Text);
                tt3.Text = c.ToString();

                int d = int.Parse(p4.Text) + int.Parse(t4.Text);
                tt4.Text = d.ToString();

                int e = int.Parse(p5.Text) + int.Parse(t5.Text);
                tt5.Text = e.ToString();

                int tot = a + b + c + d + e;
                l14.Text = tot.ToString();

                if (tot >= 165) { l15.Text = "PASS"; }
                else { l15.Text = "FAIL"; }

                grade1(a);
                grade2(b);
                grade3(c);
                grade4(d);
                grade5(e);
            }
           
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Crud_portal cp = new Crud_portal();
            cp.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printer is not connected ");
        }

        public void grade1(int a) {
            if (100 >= a && a >= 90) { g1.Text = "A1"; }
            else if (90 > a && a >= 80) { g1.Text = "A2"; }
            else if (80 > a && a >= 70) { g1.Text = "B1"; }
            else if (70 > a && a >= 60) { g1.Text = "B2"; }
            else if (60 > a && a >= 50) { g1.Text = "C1"; }
            else if (50 > a && a >= 40) { g1.Text = "C2"; }
            else if (40 > a && a >= 33) { g1.Text = "D1"; }
            else if (30 > a) { g1.Text = "D2"; }

            if (g1.Text == "D2") { fp1.Text = "F"; }
            else { fp1.Text = "P"; }
        }

        public void grade2(int a)
        {
            if (100 >= a && a >= 90) { g2.Text = "A1"; }
            else if (90 > a && a >= 80) { g2.Text = "A2"; }
            else if (80 > a && a >= 70) { g2.Text = "B1"; }
            else if (70 > a && a >= 60) { g2.Text = "B2"; }
            else if (60 > a && a >= 50) { g2.Text = "C1"; }
            else if (50 > a && a >= 40) { g2.Text = "C2"; }
            else if (40 > a && a >= 33) { g2.Text = "D1"; }
            else if (30 > a) { g2.Text = "D2"; }

            if (g2.Text == "D2") { fp2.Text = "F"; }
            else { fp2.Text = "P"; }
        }

        public void grade3(int a)
        {
            if (100 >= a && a >= 90) { g3.Text = "A1"; }
            else if (90 > a && a >= 80) { g3.Text = "A2"; }
            else if (80 > a && a >= 70) { g3.Text = "B1"; }
            else if (70 > a && a >= 60) { g3.Text = "B2"; }
            else if (60 > a && a >= 50) { g3.Text = "C1"; }
            else if (50 > a && a >= 40) { g3.Text = "C2"; }
            else if (40 > a && a >= 33) { g3.Text = "D1"; }
            else if (30 > a) { g3.Text = "D2"; }

            if (g3.Text == "D2") { fp3.Text = "F"; }
            else { fp3.Text = "P"; }
        }

        public void grade4(int a)
        {
            if (100 >= a && a >= 90) { g4.Text = "A1"; }
            else if (90 > a && a >= 80) { g4.Text = "A2"; }
            else if (80 > a && a >= 70) { g4.Text = "B1"; }
            else if (70 > a && a >= 60) { g4.Text = "B2"; }
            else if (60 > a && a >= 50) { g4.Text = "C1"; }
            else if (50 > a && a >= 40) { g4.Text = "C2"; }
            else if (40 > a && a >= 33) { g4.Text = "D1"; }
            else if (30 > a) { g4.Text = "D2"; }

            if (g4.Text == "D2") { fp4.Text = "F"; }
            else { fp4.Text = "P"; }
        }

        public void grade5(int a)
        {
            if (100 >= a && a >= 90) { g5.Text = "A1"; }
            else if (90 > a && a >= 80) { g5.Text = "A2"; }
            else if (80 > a && a >= 70) { g5.Text = "B1"; }
            else if (70 > a && a >= 60) { g5.Text = "B2"; }
            else if (60 > a && a >= 50) { g5.Text = "C1"; }
            else if (50 > a && a >= 40) { g5.Text = "C2"; }
            else if (40 > a && a >= 33) { g5.Text = "D1"; }
            else if (30 > a) { g5.Text = "D2"; }

            if (g5.Text == "D2") { fp5.Text = "F"; }
            else { fp5.Text = "P"; }
        }
    }
}
