using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Students
{
    public class StudentsViewModel : StudentViewModelBase
    {
        public StudentsViewModel(StudentService studentService)
            : base(studentService)
        {

        }
    }
}
