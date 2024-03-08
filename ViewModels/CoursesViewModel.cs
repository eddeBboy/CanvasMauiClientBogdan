using System.Collections.ObjectModel;
using System.Windows.Input;
using CanvasMauiClientBogdan.Models;
using CanvasMauiClientBogdan.Services;

namespace CanvasMauiClientBogdan.ViewModels;

public class CoursesViewModel
{
    private readonly ICourseService _courseService;
public ObservableCollection<Course> Courses { get; set; }
public ICommand RefreshCommand { get; set; }
public CoursesViewModel(ICourseService courseService)
{
_courseService = courseService;
Courses = new ObservableCollection<Course>();
RefreshCommand = new Command(async () => await GetCoursesAsync());
}
private async Task GetCoursesAsync()
{
var courses = await _courseService.GetCourses();
Courses.Clear();
foreach (var course in courses)
{
Courses.Add(course);
}
}

}
