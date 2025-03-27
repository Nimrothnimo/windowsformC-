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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace myqizz_app
{
    public partial class Q1 : Form
    {
        public Q1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            bool isCorrect = radioButtonCorrect1.Checked; // Assume radioButtonCorrect is the correct answer
            QuizManager.CheckAnswer(isCorrect);

            this.Hide(); // Hide the Q1 form
            Q2 q2Form = new Q2(); // Create an instance of Q2 form
            q2Form.ShowDialog(); // Show the Q2 form
            this.Close(); // Close the Q1 form
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCorrect1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbltimer_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

            