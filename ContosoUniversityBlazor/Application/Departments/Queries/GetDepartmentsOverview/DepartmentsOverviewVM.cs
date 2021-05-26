using System.Collections.Generic;

namespace ContosoUniversityBlazor.Application.Departments.Queries.GetDepartmentsOverview
{
    public class DepartmentsOverviewVM
    {
        public IList<DepartmentVM> Departments { get; }

        public DepartmentsOverviewVM(IList<DepartmentVM> departments)
        {
            Departments = departments;
        }
    }
}
