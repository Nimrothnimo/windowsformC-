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
    public partial class confirm : Form
    {
        public confirm()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Q5 q5Form = new Q5(); 
            q5Form.ShowDialog(); // Show the Q2 form
            this.Close(); // Close the LoginForm
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
           
            int percentage = QuizManager.CalculatePercentage();

            // Show the score percentage in a message box
            MessageBox.Show($"Your score is: {percentage}%", "Quiz Results", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide(); 
            Finishform finishForm = new Finishform(); 
            finishForm.ShowDialog(); // Show the FinishForm
            this.Close(); // Close the Q5 form
            
        }


    }
}
