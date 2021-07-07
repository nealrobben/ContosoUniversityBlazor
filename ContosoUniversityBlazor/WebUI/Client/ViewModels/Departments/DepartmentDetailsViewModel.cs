using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Departments
{
    public class DepartmentDetailsViewModel : DepartmentViewModelBase
    {
        public DepartmentDetailsViewModel(DepartmentService departmentService)
            : base(departmentService)
        {

        }
    }
}
