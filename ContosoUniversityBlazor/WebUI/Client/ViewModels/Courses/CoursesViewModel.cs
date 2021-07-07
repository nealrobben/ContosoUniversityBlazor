using Microsoft.JSInterop;
using System.Threading.Tasks;
using WebUI.Client.Services;
using WebUI.Shared.Courses.Queries.GetCoursesOverview;

namespace WebUI.Client.ViewModels.Courses
{
    public class CoursesViewModel
    {
        private readonly CourseService _courseService;
        private readonly IJSRuntime _jSRuntime;

        public CoursesOverviewVM coursesOverview { get; set; }

        public CoursesViewModel(CourseService courseService,
            IJSRuntime jSRuntime)
        {
            _courseService = courseService;
            _jSRuntime = jSRuntime;
        }

        public async Task Initialize()
        {
            coursesOverview = await _courseService.GetAllAsync();
        }

        public async Task DeleteCourse(int courseId, string title)
        {
            if (!await _jSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete the course '{title}'?"))
                return;

            var result = await _courseService.DeleteAsync(courseId.ToString());

            if (result.IsSuccessStatusCode)
            {
                coursesOverview = await _courseService.GetAllAsync();
            }
        }
    }
}
