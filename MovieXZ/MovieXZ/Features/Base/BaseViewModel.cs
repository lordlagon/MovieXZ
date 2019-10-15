using System.Threading.Tasks;

namespace Core
{
    public abstract class BaseViewModel : NotifyPropertyChanged
    {
        protected IAlertService _alertService;

        string _title;
        public string Title
        {
            get => _title;
            protected set => SetProperty(ref _title, value);
        }

        bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        protected BaseViewModel(string title)
            => Title = title;

        public virtual async Task InitializeAsync(object navigationData) { }

        public virtual async Task InitializeAsync() { }
    }
}
