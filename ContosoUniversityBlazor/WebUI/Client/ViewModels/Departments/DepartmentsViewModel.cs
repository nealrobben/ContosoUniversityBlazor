using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using WebUI.Client.Services;
using WebUI.Shared.Departments.Queries.GetDepartmentsOverview;

namespace WebUI.Client.ViewModels.Departments
{
    public class DepartmentsViewModel
    {
        private readonly DepartmentService _departmentService;
        private readonly IJSRuntime _jSRuntime;
        private readonly NavigationManager _navManager;

        public DepartmentsOverviewVM departmentsOverview { get; set; }

        public DepartmentsViewModel(DepartmentService departmentService, 
            IJSRuntime jSRuntime, NavigationManager navManager)
        {
            _departmentService = departmentService;
            _jSRuntime = jSRuntime;
            _navManager = navManager;
        }

        public async Task Initialize()
        {
            departmentsOverview = await _departmentService.GetAllAsync();
        }

        public async Task DeleteDepartment(int departmentId, string departmentName)
        {
            if (!await _jSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete the department '{departmentName}'?"))
                return;

            var result = await _departmentService.DeleteAsync(departmentId.ToString());

            if (result.IsSuccessStatusCode)
            {
                departmentsOverview = await _departmentService.GetAllAsync();
            }
        }
    }
}
