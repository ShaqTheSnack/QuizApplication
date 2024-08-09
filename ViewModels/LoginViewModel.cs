using QuizApplikation.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplikation.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        public LoginViewModel(MainWindowViewModel main)
        {
            this.main = main;
        }

        public LoginViewModel()
        {

        }

        public void CreateUser()
        {
            main.SetViewModel(new CreateViewModel(main));
        }

        public void HomePage()
        {
            Handlers();
        }

        private string _error;
        public string Error
        {
            get => _error;
            set
            {
                this.RaiseAndSetIfChanged(ref _error, value, nameof(Error));
            }
        }

        private string _UserNameInput;
        public string UserNameInput
        {
            get => _UserNameInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _UserNameInput, value, nameof(UserNameInput));
            }
        }

        private string _PasswordInput;
        public string PasswordInput
        {
            get => _PasswordInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _PasswordInput, value, nameof(PasswordInput));
            }
        }


        public void Handlers()
        {
            if (Database.Instance.LoginOrNot(UserNameInput, PasswordInput))
            {
                main.SetViewModel(new HomePageViewModel(main));
            }
            else
            {
                Error = "Invalid [Username] or [Password]";
            }
        }
        

    }
}
