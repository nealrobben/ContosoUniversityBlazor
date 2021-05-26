using AutoMapper;
using ContosoUniversityBlazor.Application.Common.Mappings;
using ContosoUniversityBlazor.Domain.Entities;

namespace ContosoUniversityBlazor.Application.Departments.Queries.GetDepartmentsLookup
{
    public class DepartmentLookupVM : IMapFrom<Department>
    {
        public int DepartmentID { get; set; }

        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Department, DepartmentLookupVM>();
        }

        public override string ToString()
        {
            return $"{DepartmentID} - {Name}";
        }
    }
}
