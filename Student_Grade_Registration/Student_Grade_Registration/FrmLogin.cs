using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grade_Registration
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stdnt_Details frm = new Stdnt_Details();
            frm.number = maskedTextBox1.Text;
            frm.Show();
          
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
           
            if (maskedTextBox1.Text=="1111")
            {
                Teacher_Details tchr = new Teacher_Details();
                tchr.Show();
            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
