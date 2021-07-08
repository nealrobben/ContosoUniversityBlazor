using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Students
{
    public class StudentDetailsViewModel : StudentViewModelBase
    {
        public StudentDetailsViewModel(StudentService studentService)
            : base(studentService)
        {

        }
    }
}
