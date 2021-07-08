using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Students
{
    public class StudentEditViewModel : StudentViewModelBase
    {
        public StudentEditViewModel(StudentService studentService)
            : base(studentService)
        {

        }
    }
}
