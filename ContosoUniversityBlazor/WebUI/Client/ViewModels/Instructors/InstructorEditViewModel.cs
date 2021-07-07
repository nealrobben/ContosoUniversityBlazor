using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Instructors
{
    public class InstructorEditViewModel : InstructorViewModelBase
    {
        public InstructorEditViewModel(InstructorService instructorService)
            : base(instructorService)
        {

        }
    }
}
