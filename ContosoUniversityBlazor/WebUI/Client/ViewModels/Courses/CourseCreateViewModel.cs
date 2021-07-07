using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Courses
{
    public class CourseCreateViewModel : CoursesViewModelBase
    {
        public CourseCreateViewModel(CourseService courseService)
            :base(courseService)
        {

        }
    }
}
