using QuizApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myqizz_app
{
    public partial class Q5 : Form
    {
        public Q5()
        {
            InitializeComponent();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*Quizform quizForm = new uizForm();
            Quizform.Show();*/
            Q4 q4Form = new Q4(); // Create an instance of Q2 form
            q4Form.ShowDialog(); // Show the Q2 form
            this.Close(); // Close the LoginForm
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            bool isCorrect = radioButtonCorrect5.Checked; // Assume radioButtonCorrect is the correct answer
            QuizManager.CheckAnswer(isCorrect);
            this.Hide(); // Hide the Q1 form
            confirm confirmForm = new confirm(); // Create an instance of Q2 form
            confirmForm.ShowDialog(); // Show the Q2 form
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCorrect5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblQ1_Click(object sender, EventArgs e)
        {

        }
    }
}
