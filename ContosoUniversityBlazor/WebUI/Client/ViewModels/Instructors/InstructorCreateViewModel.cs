using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Instructors
{
    public class InstructorCreateViewModel : InstructorViewModelBase
    {
        public InstructorCreateViewModel(InstructorService instructorService)
            :base(instructorService)
        {

        }
    }
}
