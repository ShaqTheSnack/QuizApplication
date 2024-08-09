using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplikation.Models
{
    public class Points
    {
        public int Score { get; set; }
        public int TotalScore { get; set; }

        // Når denne metode bliver kaldt i mit QuizStartedViewModel, så opdatere den din score med 1 hvis svaret er rigtig.
        public void IncreaseScore()
        {
            Score += 1;
            TotalScore = Score;
        }
    }
}
