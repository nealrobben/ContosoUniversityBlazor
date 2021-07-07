using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Departments
{
    public class DepartmentCreateViewModel : DepartmentViewModelBase
    {
        public DepartmentCreateViewModel(DepartmentService departmentService) 
            : base(departmentService)
        {

        }
    }
}
