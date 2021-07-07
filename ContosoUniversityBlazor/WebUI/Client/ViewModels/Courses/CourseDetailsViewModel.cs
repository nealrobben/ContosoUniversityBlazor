using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Courses
{
    public class CourseDetailsViewModel : CoursesViewModelBase
    {
        public CourseDetailsViewModel(CourseService courseService)
            : base(courseService)
        {

        }
    }
}
