namespace TDC2016MVVM
{
    public class UserService
    {
        public User CurrentUser { get; set; }

        public void Save(User user)
        {
            CurrentUser = user;
        }
    }
}
