using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace TDC2016MVVM
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public NavigationService NavigationService { get; set; } = new NavigationService();

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetPropertyAndNotify<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
