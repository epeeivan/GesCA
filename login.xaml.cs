using Gesca.ViewModel;

namespace Gesca;

public partial class NewPage1 : ContentPage
{
	public NewPage1(loginViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}