using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplikation.ViewModels
{
    public class RulesViewModel : ViewModelBase
    {
        private readonly MainWindowViewModel main;

        public RulesViewModel(MainWindowViewModel main)
        {
            this.main = main;
        }

        public void BackBtn()
        {
            main.SetViewModel(new HomePageViewModel(main));
        }
    }
}
