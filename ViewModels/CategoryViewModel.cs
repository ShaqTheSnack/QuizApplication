using QuizApplikation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplikation.ViewModels
{
    public class CategoryViewModel : ViewModelBase
    {
        readonly private MainWindowViewModel main;
        // Opretter instanser af Category, GameMode og ProcedureNames
        public Category cate = new();
        public GameMode mode = new();
        public static ProcedureNames procedures = new();

        // Konstruktor som tager en MainWindowViewModel som parameter
        public CategoryViewModel(MainWindowViewModel main)
        {
            this.main = main;
        }

        #region CategoryBtnPressed
        // Sætter GameCategory og CategoryProcedure for History og starter spillet
        public void HistoryCategory()
        {
            mode.GameCategory = cate.History;
            procedures.CategoryProcedure = procedures.HistoryProcedure;
            GameStarts();
        }

        public void ScienceCategory()
        {
            mode.GameCategory = cate.Science;
            procedures.CategoryProcedure = procedures.ScienceProcedure;
            GameStarts();
        }

        public void MoviesCategory()
        {
            mode.GameCategory = cate.Movies;
            procedures.CategoryProcedure = procedures.MovieProcedure;
            GameStarts();
        }

        public void GeographyCategory()
        {
            mode.GameCategory = cate.Geography;
            procedures.CategoryProcedure = procedures.GeographyProcedure;
            GameStarts();
        }

        public void SportsCategory()
        {
            mode.GameCategory = cate.Sports;
            procedures.CategoryProcedure = procedures.SportsProcedure;
            GameStarts();
        }

        public void ProgrammingCategory()
        {
            mode.GameCategory = cate.Programming;
            procedures.CategoryProcedure = procedures.ProgrammingProcedure;
            GameStarts();
        }

        public void DatabaseCategory()
        {
            mode.GameCategory = cate.Database;
            procedures.CategoryProcedure = procedures.DatabaseProcedure;
            GameStarts();
        }

        public void ClientSideCategory()
        {
            mode.GameCategory = cate.ClientSide;
            procedures.CategoryProcedure = procedures.ClientSideProcedure;
            GameStarts();
        }

        public void NetworkCategory()
        {
            mode.GameCategory = cate.Network;
            procedures.CategoryProcedure = procedures.NetworkingProcedure;
            GameStarts();
        }

        public void GUICategory()
        {
            mode.GameCategory = cate.GUI;
            GameStarts();
            procedures.CategoryProcedure = procedures.GUIProcedure;
        }

        #endregion

        // Starter spillet ved at ændre ViewModel til QuizStartedViewModel
        public void GameStarts()
        {
            main.SetViewModel(new QuizStartedViewModel(main));
        }

        // Går tilbage til startsiden ved at ændre ViewModel til HomePageViewModel
        public void BackBtn()
        {
            main.SetViewModel(new HomePageViewModel(main));
        }
    }
}
