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

namespace Student_Grade_Registration
{
    public partial class Stdnt_Details : Form
    {
        public Stdnt_Details()
        {
            InitializeComponent();
        }

        public string number;
        SqlConnection connect = new SqlConnection (@"Data Source=LAPTOP-83KELKNK;Initial Catalog=stdnt_reg;Integrated Security=True");
        //Data Source=LAPTOP-83KELKNK;Initial Catalog=stdnt_reg;Integrated Security=True
        private void Stdnt_Details_Load(object sender, EventArgs e)
        {
            lbl_number.Text = number;
            connect.Open();
            SqlCommand command = new SqlCommand("Select * From Lesson_tbl where std_no=@p1", connect);
            command.Parameters.AddWithValue("@p1", number);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                lbl_name.Text = read[2].ToString() + " " + read[3].ToString();
                lbl_ex1.Text = read[4].ToString();
                lbl_ex2.Text = read[5].ToString();
                lbl_ex3.Text = read[6].ToString();
                lbl_avg.Text = read[7].ToString();
                lbl_case.Text = read[8].ToString();
                if (read[8].ToString() == "True")
                {
                    lbl_case.Text = "Passed";
                }
                else
                {
                    lbl_case.Text = "Failed";
                }
            }
            connect.Close();
        }
    }
}
