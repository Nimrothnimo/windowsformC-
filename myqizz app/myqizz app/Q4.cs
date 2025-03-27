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
    public partial class Q4 : Form
    {
        public Q4()
        {
            InitializeComponent();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*Quizform quizForm = new uizForm();
            Quizform.Show();*/
            Q3 q3Form = new Q3(); // Create an instance of Q2 form
            q3Form.ShowDialog(); // Show the Q2 form
            this.Close(); // Close the LoginForm
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            bool isCorrect = radioButtonCorrect4.Checked; // Assume radioButtonCorrect is the correct answer
            QuizManager.CheckAnswer(isCorrect);
            this.Hide();
            /*Quizform quizForm = new uizForm();
            Quizform.Show();*/
            Q5 q5Form = new Q5(); // Create an instance of Q2 form
            q5Form.ShowDialog(); // Show the Q2 form
            this.Close(); // Close the LoginForm
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

        private void radioButtonCorrect4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
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
