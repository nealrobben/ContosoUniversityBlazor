using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Students
{
    public class StudentCreateViewModel : StudentViewModelBase
    {
        public StudentCreateViewModel(StudentService studentService)
            :base(studentService)
        {

        }
    }
}
