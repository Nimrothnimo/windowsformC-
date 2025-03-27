using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myqizz_app
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        

            {
                string username = txtusername.Text;
                string password = txtpassword.Text;

                if (username == "1" && password == "1")
                {
                    this.Hide();
                 Q1 q1Form = new Q1(); // Create an instance of Q2 form
                 q1Form.ShowDialog(); // Show the Q2 form
                  this.Close(); // Close the LoginForm
                
            }
                else
                {
                    MessageBox.Show("Invalid login. Please try again.");
                }
            }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
    }