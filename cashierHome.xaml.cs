using Gesca.ViewModel;

namespace Gesca;

public partial class cashierHome : ContentPage
{
	public cashierHome(CashierViewModel vm)
	{
		InitializeComponent();
		BindingContext=vm;
	}
}