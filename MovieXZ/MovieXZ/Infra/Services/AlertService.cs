using Xamarin.Forms;
using System.Threading.Tasks;

namespace Core
{
    public interface IAlertService
    {
        Task<bool> ShowAsync(string title, string message, string ok, string cancel);
        Task ShowAsync(string title, string message, string cancel);
    }

    public class AlertService : IAlertService
    {
        public async Task<bool> ShowAsync(string title, string message, string ok, string cancel) =>
            await Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);

        public async Task ShowAsync(string title, string message, string cancel) =>
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
    }
}
