using CanvasMauiClientBogdan.Models;
namespace CanvasMauiClientBogdan;

public interface IGroupService
{
    Task<List<Group>> GetGroups();
    Task<Group> GetGroup(int id);
}