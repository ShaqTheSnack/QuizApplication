using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace QuizApplikation.Models
{
    public class Answers
    {
        // Definerer egenskaber til svarmuligheder og spørgsmålstitel
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public string QuestionTitle { get; set; }
        public string CorrectAnswer { get; set; }

        // Konstruktor som tager spørgsmål og svarmuligheder som parametre
        public Answers(string Question, string RealAnswer, string FalseAnswer1, string FalseAnswer2, string FalseAnswer3, string FalseAnswer4)
        {
            // Opretter et array med alle mulige svar
            string[] possibleValues = { RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4 };

            // Opretter et array med spørgsmålstitlen
            string[] TitleQuestion = { Question };

            // Opretter et array med det korrekte svar
            string[] Correct = { RealAnswer };

            // Initialiserer en ny instans af Random-klassen
            Random rnd = new();

            // Konverterer arrayet til en liste og tildeler første element til QuestionTitle
            List<string> Title = TitleQuestion.ToList();
            QuestionTitle = Title[0];

            // Konverterer det korrekte svar til en liste og tildeler første element til CorrectAnswer
            List<string> True = Correct.ToList();
            CorrectAnswer = True[0];

            // Konverterer alle mulige svar til en liste
            List<string> valuesList = possibleValues.ToList();

            // Tildeler en tilfældig værdi fra listen til A og fjerner den tildelte værdi fra listen
            A = valuesList[rnd.Next(valuesList.Count)];
            valuesList.Remove(A);

            B = valuesList[rnd.Next(valuesList.Count)];
            valuesList.Remove(B);

            C = valuesList[rnd.Next(valuesList.Count)];
            valuesList.Remove(C);

            D = valuesList[rnd.Next(valuesList.Count)];
            valuesList.Remove(D);

            E = valuesList[rnd.Next(valuesList.Count)];
            valuesList.Remove(E);
        }
    }
}
