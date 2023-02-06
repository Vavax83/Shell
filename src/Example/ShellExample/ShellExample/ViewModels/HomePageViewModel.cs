using System.Threading.Tasks;
using System.Windows.Input;
using AvaloniaInside.Shell.Services;
using ReactiveUI;

namespace ShellExample.ViewModels;

public class HomePageViewModel : ViewModelBase
{
	private readonly INavigationService _navigationService;

	public ICommand NavigateToSecondPage { get; set; }

	public HomePageViewModel(INavigationService navigationService)
	{
		_navigationService = navigationService;
		NavigateToSecondPage = ReactiveCommand.CreateFromTask(Navigate);

	}

	private Task Navigate()
	{
		return _navigationService.NavigateAsync("/second");
	}
}