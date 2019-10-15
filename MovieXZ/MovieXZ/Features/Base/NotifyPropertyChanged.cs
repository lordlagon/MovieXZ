using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Core
{
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void SetProperty<TValue>(ref TValue prop, TValue value, [CallerMemberName] string propertyName = "")
        {
            prop = value;
            RaisePropertyChanged(propertyName);
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
         => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}