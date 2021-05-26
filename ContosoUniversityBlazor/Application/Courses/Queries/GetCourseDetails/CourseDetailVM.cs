using AutoMapper;
using ContosoUniversityBlazor.Application.Common.Mappings;
using ContosoUniversityBlazor.Domain.Entities;

namespace ContosoUniversityBlazor.Application.Courses.Queries.GetCourseDetails
{
    public class CourseDetailVM : IMapFrom<Course>
    {
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Course, CourseDetailVM>();
        }

        public override string ToString()
        {
            return $"{CourseID} - {Title}";
        }
    }
}
