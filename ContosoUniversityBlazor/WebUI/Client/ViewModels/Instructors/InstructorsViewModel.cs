using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Instructors
{
    public class InstructorsViewModel : InstructorViewModelBase
    {
        public InstructorsViewModel(InstructorService instructorService)
            : base(instructorService)
        {

        }
    }
}
