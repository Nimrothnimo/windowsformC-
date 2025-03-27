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
    public partial class Q3 : Form
    {
        public Q3()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            bool isCorrect = radioButtonCorrect3.Checked; // Assume radioButtonCorrect is the correct answer
            QuizManager.CheckAnswer(isCorrect);
            this.Hide();
            /*Quizform quizForm = new uizForm();
            Quizform.Show();*/
            Q4 q4Form = new Q4(); // Create an instance of Q2 form
            q4Form.ShowDialog(); // Show the Q2 form
            this.Close(); // Close the LoginForm
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            bool isCorrect = radioButtonCorrect3.Checked; // Assume radioButtonCorrect is the correct answer
            QuizManager.CheckAnswer(isCorrect);
            this.Hide();
            /*Quizform quizForm = new uizForm();
            Quizform.Show();*/
            Q2 q2Form = new Q2(); // Create an instance of Q2 form
            q2Form.ShowDialog(); // Show the Q2 form
            this.Close(); // Close the LoginForm
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCorrect3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
