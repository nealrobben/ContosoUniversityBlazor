using AutoMapper;
using ContosoUniversityBlazor.Application.Common.Mappings;

namespace ContosoUniversityBlazor.Application.Courses.Queries.GetCoursesForInstructor
{
    public class CourseForInstructorVM : IMapFrom<Domain.Entities.Course>
    {
        public int CourseID { get; set; }

        public string Title { get; set; }

        public string DepartmentName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Course, CourseForInstructorVM>()
                .ForMember(d => d.DepartmentName, opt => opt.MapFrom(s => s.Department.Name));
        }

        public override string ToString()
        {
            return $"{CourseID} - {Title} - {DepartmentName}";
        }
    }
}
