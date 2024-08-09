using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplikation.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        readonly private MainWindowViewModel main;

        public HomePageViewModel(MainWindowViewModel main)
        {
            this.main = main;
        }


        public void KategoriBtn()
        {
            main.SetViewModel(new CategoryViewModel(main));
        }

        public void ReglerBtn()
        {
            main.SetViewModel(new RulesViewModel(main));
        }


        public void SignOutBtn()
        {
            main.SetViewModel(new LoginViewModel(main));
        }
    }
}
