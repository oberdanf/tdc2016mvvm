namespace TDC2016MVVM
{
    public static class ServiceLocator
    {
        private static UserService userService;

        public static UserService UserService = userService ?? (userService = new UserService());
    }
}
