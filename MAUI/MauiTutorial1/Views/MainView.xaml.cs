using MauiTutorial1.ViewModels;

namespace MauiTutorial1.Views;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel viewModel)
	{
		InitializeComponent();

		BindingContext - viewModel;
	}
}