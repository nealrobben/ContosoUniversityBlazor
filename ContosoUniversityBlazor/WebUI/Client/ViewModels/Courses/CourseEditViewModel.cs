using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Courses
{
    public class CourseEditViewModel : CoursesViewModelBase
    {
        public CourseEditViewModel(CourseService courseService)
            : base(courseService)
        {

        }
    }
}
