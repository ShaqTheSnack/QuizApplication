using QuizApplikation.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplikation.ViewModels
{
    internal class CreateViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        public CreateViewModel(MainWindowViewModel main)
        {
            this.main = main;
        }

        public CreateViewModel()
        {

        }



        private string _FirstNameInput;
        public string FirstNameInput
        {
            get => _FirstNameInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _FirstNameInput, value, nameof(FirstNameInput));
            }


        }


        private string _LastNameInput;
        public string LastNameInput
        {
            get => _LastNameInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _LastNameInput, value, nameof(LastNameInput));
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


        private string _error;
        public string Error
        {
            get => _error;
            set
            {
                this.RaiseAndSetIfChanged(ref _error, value, nameof(Error));
            }
        }



        
        public void CreateUser()
        {
            string username = UserNameInput;
            string password = PasswordInput;
            string firstName = FirstNameInput;
            string lastName = LastNameInput;

            if (Database.Instance.IsUsernameExists(username))
            {
                Error = "Username is already in use. Please choose another username.";
            }
            else
            {
                Database.Instance.InsertData(username, password, firstName, lastName);
                main.SetViewModel(new LoginViewModel(main));
            }
        }
        
    }
}
