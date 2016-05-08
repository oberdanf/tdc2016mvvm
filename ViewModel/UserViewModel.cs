using System.Windows.Input;
using Xamarin.Forms;

namespace TDC2016MVVM
{
    public class UserViewModel : BaseViewModel
    {
        private const int MIN_CHARACTERS_LENGTH = 5;
        private const int MAX_CHARACTERS_LENGTH = 15;
        private const string UNAVAILABLE_USERNAME = "Este nome não pode ser usado!";
        private static readonly string MAX_CHARACTERS_ERROR_MESSAGE = $"Seu nome deve ter no máximo {MAX_CHARACTERS_LENGTH} caracteres";
        private static readonly string MIN_CHARACTERS_ERROR_MESSAGE = $"Seu nome deve ter no mínimo {MIN_CHARACTERS_LENGTH} caracteres";

        private string username;
        private string errorMessage;

        public UserViewModel()
        {
            EnterCommand = new Command(obj => OnEnter());
        }

        public string Username
        {
            get { return this.username; }
            set { SetPropertyAndNotify(ref this.username, value); }
        }

        public string ErrorMessage
        {
            get { return this.errorMessage; }
            set { SetPropertyAndNotify(ref this.errorMessage, value); }
        }

        public ICommand EnterCommand { get; set; }

        private void OnEnter()
        {
            if (IsUsernameValid())
            {
                ServiceLocator.UserService.Save(new User { Name = Username });
                NavigationService.NavigateTo(new BeerView());
            }
        }

        private bool IsUsernameValid()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                return false;
            }

            if (Username.Equals("Darth Vader", System.StringComparison.OrdinalIgnoreCase))
            {
                ErrorMessage = UNAVAILABLE_USERNAME;
                return false;
            }

            if (Username.Length < MIN_CHARACTERS_LENGTH)
            {
                ErrorMessage = MIN_CHARACTERS_ERROR_MESSAGE;
                return false;
            }

            if (Username.Length > MAX_CHARACTERS_LENGTH)
            {
                ErrorMessage = MAX_CHARACTERS_ERROR_MESSAGE;
                return false;
            }

            ErrorMessage = string.Empty;
            return true;
        }
    }
}

