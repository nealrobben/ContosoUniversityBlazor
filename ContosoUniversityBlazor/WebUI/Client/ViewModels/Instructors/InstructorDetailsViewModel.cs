using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Instructors
{
    public class InstructorDetailsViewModel : InstructorViewModelBase
    {
        public InstructorDetailsViewModel(InstructorService instructorService)
            :base(instructorService)
        {

        }
    }
}
