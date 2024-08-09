using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizApplikation.Models;
using ReactiveUI;

namespace QuizApplikation.ViewModels
{
    public class FinishedViewModel : ViewModelBase
    {
        readonly private MainWindowViewModel main;
        public QuizFeedback QuizFeedback = new();
        public Points points  = QuizStartedViewModel.point;

        public FinishedViewModel(MainWindowViewModel main)
        {
            // Initialiserer main feltet og kalder metoder til at få feedback og total score
            this.main = main;
            GetPointFeedback();
            TotalScore();
        }

        public void GetPointFeedback()
        {
            // Switch-statement til at sætte PointFeedback baseret på TotalScore
            switch (points.TotalScore)
            {
                case 0:
                    PointFeedback = QuizFeedback.Point0;
                    break;
                case 1:
                    PointFeedback = QuizFeedback.Point1;
                    break;
                case 2:
                    PointFeedback = QuizFeedback.Point2;
                    break;
                case 3:
                    PointFeedback = QuizFeedback.Point3;
                    break;
                case 4:
                    PointFeedback = QuizFeedback.Point4;
                    break;
                case 5:
                    PointFeedback = QuizFeedback.Point5;
                    break;
                case 6:
                    PointFeedback = QuizFeedback.Point6;
                    break;
                case 7:
                    PointFeedback = QuizFeedback.Point7;
                    break;
                case 8:
                    PointFeedback = QuizFeedback.Point8;
                    break;
                case 9:
                    PointFeedback = QuizFeedback.Point9;
                    break;
                case 10:
                    PointFeedback = QuizFeedback.Point10;
                    break;
            }
        }

        public void TotalScore()
        {
            // Konverterer score til string og sætter PointScore med en feedback besked
            string total = points.Score.ToString();
            PointScore = $"Du fik {total}/10 Rigtige";
        }

        // Privat felt til PointFeedback
        private string _pointFeedback;

        // Til binding a view
        public string? PointFeedback
        {
            get => _pointFeedback;
            set => this.RaiseAndSetIfChanged(ref _pointFeedback, value);
        }

        // Privat felt til PointScore
        private string _pointScore;

        // Til binding a view
        public string? PointScore
        {
            get => _pointScore;
            set => this.RaiseAndSetIfChanged(ref _pointScore, value);
        }

        public void ExitBtn()
        {
            main.SetViewModel(new HomePageViewModel(main));
        }
    }
}
