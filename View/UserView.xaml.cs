using Xamarin.Forms;

namespace TDC2016MVVM
{
    public partial class UserView : ContentPage
    {
        public UserView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.usernameEntry.BackgroundColor = Color.FromHex("#FFEEC3").MultiplyAlpha(0.5);
        }
    }
}
