using Gesca.ViewModel;

namespace Gesca;

public partial class loginPage : ContentPage
{
	public loginPage(loginViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}