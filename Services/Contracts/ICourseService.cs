using CanvasMauiClientBogdan.Models;
namespace CanvasMauiClientBogdan;

public interface ICourseService
{
    Task<List<Course>> GetCourses();
Task<Course> GetCourse(int id);

}
