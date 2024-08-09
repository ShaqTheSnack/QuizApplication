using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplikation.Models
{
    public class GameMode
    { 
        public string GameCategory { get; set; } = string.Empty;
        public int GameNumber { get; set; }
        public int TimePerGame { get; set; } = 15; //Ændre værdien for at skifte hvor langtid spillet tager før nyt spørgsmål skifter (Det står i sekunder)
    }
}
