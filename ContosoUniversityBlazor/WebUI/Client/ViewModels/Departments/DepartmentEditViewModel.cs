using WebUI.Client.Services;

namespace WebUI.Client.ViewModels.Departments
{
    public class DepartmentEditViewModel : DepartmentViewModelBase
    {
        public DepartmentEditViewModel(DepartmentService departmentService)
            : base(departmentService)
        {

        }
    }
}
