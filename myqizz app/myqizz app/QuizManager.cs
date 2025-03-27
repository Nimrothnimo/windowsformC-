using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public static class QuizManager
    {

        public static int Score { get; private set; } = 0;
        public static int TotalQuestions { get; private set; } = 5;
        public static void CheckAnswer(bool isCorrect)
        {
            if (isCorrect) Score++;
        }

        public static void ResetScore()
        {
            Score = 0;
        }
        public static int CalculatePercentage()
        {
            return (Score * 100) / TotalQuestions;
        }
    }
}

