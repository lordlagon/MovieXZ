using System.Globalization;
using Refit;

namespace Core
{
    public abstract class BaseService
    {
        protected string Language => CultureInfo.CurrentUICulture.Name;

        protected IApiRestfull Api
            => RestService.For<IApiRestfull>(ConstantHelper.ApiUrl);
    }
}
