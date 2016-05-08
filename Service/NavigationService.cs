using Xamarin.Forms;

namespace TDC2016MVVM
{
    public class NavigationService
    {
        public async void NavigateTo(Page page)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
