using Microsoft.CodeAnalysis.CSharp.Syntax;
using QuizApplikation.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuizApplikation.ViewModels
{
    public class QuizStartedViewModel : ViewModelBase
    {
        readonly private MainWindowViewModel main;
        private Answers answer;
        readonly private Database database = new();
        readonly public GameMode mode = new();
        readonly public static Points point = new();

        private CancellationTokenSource gameCancellationTokenSource; // Til at annullere timer

        public QuizStartedViewModel(MainWindowViewModel main)
        {
            this.main = main;
            GetData(); // Henter data til visning ved oprettelse af view model
        }

        // Metode til at hente data (spørgsmål og svarmuligheder)
        private async void GetData()
        {
            if (mode.GameNumber == 10) // Hvis spilnummer er 10, naviger til FinishedViewModel
            {
                main.SetViewModel(new FinishedViewModel(main));
                return; // Stopper at if ikke gøre igen
            }

            // Annuller den aktuelle timer, hvis den kører
            gameCancellationTokenSource?.Cancel();

            // Hent spørgsmål og svar fra databasen baseret på spilnummer
            answer = database.ExtractData()[mode.GameNumber];

            // Opdater properties med spørgsmål og svarmuligheder
            Question = answer.QuestionTitle;
            TextBlue = answer.A;
            TextRed = answer.B;
            TextYellow = answer.C;
            TextGreen = answer.D;
            TextPink = answer.E;

            // Start ny nedtælling
            await GameTimerAsync();
        }

        #region Properties til binding med View

        private int _timer;
        public int SecondTimer
        {
            get => _timer;
            set => this.RaiseAndSetIfChanged(ref _timer, value);
        }

        private string _question;
        public string Question
        {
            get => _question;
            set => this.RaiseAndSetIfChanged(ref _question, value);
        }

        private string _textBlue;
        public string TextBlue
        {
            get => _textBlue;
            set => this.RaiseAndSetIfChanged(ref _textBlue, value);
        }

        private string _textRed;
        public string TextRed
        {
            get => _textRed;
            set => this.RaiseAndSetIfChanged(ref _textRed, value);
        }

        private string _textYellow;
        public string TextYellow
        {
            get => _textYellow;
            set => this.RaiseAndSetIfChanged(ref _textYellow, value);
        }

        private string _textGreen;
        public string TextGreen
        {
            get => _textGreen;
            set => this.RaiseAndSetIfChanged(ref _textGreen, value);
        }

        private string _textPink;
        public string TextPink
        {
            get => _textPink;
            set => this.RaiseAndSetIfChanged(ref _textPink, value);
        }

        #endregion

        // Metode til spiltimer
        private async Task GameTimerAsync()
        {
            gameCancellationTokenSource = new CancellationTokenSource();

            try
            {
                await CountDownTimerAsync(gameCancellationTokenSource.Token);

                // Når nedtælling er færdig, øg spilnummeret og hent næste spørgsmål
                mode.GameNumber += 1;
                GetData();
            }
            catch (OperationCanceledException)
            {
                // Handle annullering af timeren
            }
        }

        private async Task CountDownTimerAsync(CancellationToken cancellationToken)
        {
            // Sæt 'SecondTimer' til startværdien før nedtællingen
            SecondTimer = mode.TimePerGame;

            // Løkke der kører fra værdien af 'TimePerGame' i 'mode' objektet/model til 1
            for (int i = mode.TimePerGame; i > 0; i--)
            {
                // Vent i (1 sekund)
                await Task.Delay(1000, cancellationToken);

                // Opdater 'SecondTimer' til den aktuelle værdi af 'i' efter forsinkelsen
                SecondTimer = i - 1;
            }
        }

        // Knapmetoder
        public void Blue()
        {
            CheckAnswer(answer.A);
        }

        public void Red()
        {
            CheckAnswer(answer.B);
        }

        public void Yellow()
        {
            CheckAnswer(answer.C);
        }

        public void Green()
        {
            CheckAnswer(answer.D);
        }

        public void Pink()
        {
            CheckAnswer(answer.E);
        }

        private void CheckAnswer(string selectedAnswer)
        {
            if (selectedAnswer == answer.CorrectAnswer)
            {
                point.IncreaseScore();
            }

            // Stop den aktuelle timer
            gameCancellationTokenSource?.Cancel();

            // Gå til næste spørgsmål
            mode.GameNumber += 1;
            GetData();
        }

        // Metode til at afslutte quizzen
        public void ExitBtn()
        {
            main.SetViewModel(new CategoryViewModel(main)); // Navigerer til kategoriviewmodel i hovedvinduet
        }
    }
}
