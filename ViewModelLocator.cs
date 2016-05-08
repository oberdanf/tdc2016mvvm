namespace TDC2016MVVM
{
    public static class ViewModelLocator
    {
        private static UserViewModel userViewModel;

        public static UserViewModel UserViewModel => userViewModel ?? (userViewModel = new UserViewModel());

        public static BeerViewModel BeerViewModel => new BeerViewModel();
    }
}