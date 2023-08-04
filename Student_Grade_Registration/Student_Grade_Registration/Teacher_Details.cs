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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Student_Grade_Registration
{
    public partial class Teacher_Details : Form
    {
        public Teacher_Details()
        {
            InitializeComponent();
        }
        SqlConnection connect =
        new SqlConnection(@"Data Source=LAPTOP-83KELKNK;Initial Catalog=stdnt_reg;Integrated Security=True");
        private void Teacher_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stdnt_regDataSet.Lesson_tbl' table. You can move, or remove it, as needed.
            this.lesson_tblTableAdapter.Fill(this.stdnt_regDataSet.Lesson_tbl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cndtn;
            double average, ex1, ex2, ex3;
            ex1 = Convert.ToDouble(textBox_ex1.Text);
            ex2 = Convert.ToDouble(textBox_ex2.Text);
            ex3 = Convert.ToDouble(textBox_ex3.Text);
           
            average = (ex1 + ex2 + ex3) / 3;
            //label_avg.Text = average.ToString();

            if (average >= 50)
            {
                cndtn = "True";
            }
            else
            {
                cndtn = "False";

            }
            connect.Open();
            SqlCommand commnd = new SqlCommand("Insert into LESSON_TBL (std_no,std_name,std_surname,std_exam1,std_exam2,std_exam3,std_avrg) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7)", connect);
            commnd.Parameters.AddWithValue("@P1", maskedNo.Text);
            commnd.Parameters.AddWithValue("@P2", textBox_name.Text);
            commnd.Parameters.AddWithValue("@P3", textBox_surname.Text);
            commnd.Parameters.AddWithValue("@P4", textBox_ex1.Text);
            commnd.Parameters.AddWithValue("@P5", textBox_ex2.Text);
            commnd.Parameters.AddWithValue("@P6", textBox_ex3.Text);
            commnd.Parameters.AddWithValue("@P7", label_avg.Text);
   
            commnd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Student added to the system!");
            this.lesson_tblTableAdapter.Fill(this.stdnt_regDataSet.Lesson_tbl);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;

            maskedNo.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            textBox_name.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            textBox_surname.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            textBox_ex1.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            textBox_ex2.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            textBox_ex3.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cndtn;
            double average, ex1, ex2, ex3;
            ex1 = Convert.ToDouble(textBox_ex1.Text);
            ex2 = Convert.ToDouble(textBox_ex2.Text);
            ex3 = Convert.ToDouble(textBox_ex3.Text);

            average = (ex1 + ex2 + ex3) / 3;
            label_avg.Text = average.ToString();
            
            if (average >= 50)
            {

                cndtn = "True";
                
            }
            else
            {
                cndtn = "False";
            }

            connect.Open();
            SqlCommand cmnd = new SqlCommand(@"update Lesson_tbl set std_exam1=@P1,std_exam2=@P2,std_exam3=@P3,std_avrg=@P4,std_condtn=@P5
            where std_no=@P6", connect);
            cmnd.Parameters.AddWithValue("@P1", textBox_ex1.Text);
            cmnd.Parameters.AddWithValue("@P2", textBox_ex2.Text);
            cmnd.Parameters.AddWithValue("@P3", textBox_ex3.Text);
            cmnd.Parameters.AddWithValue("@P4", Convert.ToDecimal(label_avg.Text));
            cmnd.Parameters.AddWithValue("@P5", cndtn);
            cmnd.Parameters.AddWithValue("@P6", maskedNo.Text);

            cmnd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Student Grade updated!");
            this.lesson_tblTableAdapter.Fill(this.stdnt_regDataSet.Lesson_tbl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }
            string sql = "DELETE FROM Lesson_tbl WHERE std_no=@p1";
            SqlCommand cmnd = new SqlCommand(sql, connect);
            cmnd.Parameters.AddWithValue("@p1", maskedNo.Text);
            connect.Open();
            cmnd.ExecuteNonQuery();
            connect.Close();
            textBox_name.Clear();
            textBox_surname.Clear();
            textBox_ex1.Clear();
            textBox_ex2.Clear();
            textBox_ex3.Clear();
            maskedNo.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount - 1;
            label11.Text = kayitsayisi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int pssd = 0;
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object cellValue = row.Cells[7].Value;

                if (cellValue != null && Convert.ToDouble(cellValue)>=50)
                {
                    pssd++;
                }
            
            }
            label_pssd.Text = pssd.ToString();
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int failed = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object cellValue = row.Cells[7].Value;

                if (cellValue != null && Convert.ToDouble(cellValue) < 50)
                {
                    failed++;
                }
                
            }
            
            label_fail.Text = failed.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int rowCount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                if (!row.IsNewRow)
                {
                    // Access to the value of the column
                    object cellValue = row.Cells[7].Value;

                    // if the cellvalue is not null and convertable to double add to the sum
                    if (cellValue != null && double.TryParse(cellValue.ToString(), out double value))
                    {
                        sum += value;
                        rowCount++;
                    }
                }
            }

            if (rowCount > 0)
            {
                // Find the average by dividing the sum by the rowCount
                double average = sum / rowCount;
                label_avg.Text = average.ToString();
            }
        }
    }
}
