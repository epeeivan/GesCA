namespace Gesca;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(cashierHome), typeof(cashierHome));
	}
}
