using System.Collections.ObjectModel;
using System.Windows.Input;
using CanvasMauiClientBogdan.Models;
using CanvasMauiClientBogdan.Services;

namespace CanvasMauiClientBogdan.ViewModels;

public class GroupViewModel
{
    private readonly IGroupService _groupService;
    public ObservableCollection<Group> Groups { get; set; }
    public ICommand RefreshCommand { get; set; }
    public GroupViewModel(IGroupService groupService)
    {
        _groupService = groupService;
        Groups = new ObservableCollection<Group>();
        RefreshCommand = new Command(async () => await GetGroupsAsync());
    }
    private async Task GetGroupsAsync()
    {
        var groups = await _groupService.GetGroups();
        Groups.Clear();
        foreach (var group in groups)
        {
            Groups.Add(group);
        }
    }
}