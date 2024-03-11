using CanvasMauiClientBogdan.ViewModels;

namespace CanvasMauiClientBogdan.Pages;

public partial class GroupPage : ContentPage
{
    public GroupPage(GroupViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewModel = (GroupViewModel)BindingContext;
        viewModel.RefreshCommand.Execute(null);
    }
}
