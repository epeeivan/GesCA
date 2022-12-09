using GalaSoft.MvvmLight;

namespace Gesca.ViewModel
{
    public partial class loginViewModel:ObservableObject
    {
        [ICommand]
         async Task Tap(String s)
        {
            await Shell.Current.GoToAsync(nameof(cashierHome));
        }
    }
}
