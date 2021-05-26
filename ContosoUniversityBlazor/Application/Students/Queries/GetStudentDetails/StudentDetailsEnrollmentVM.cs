using AutoMapper;
using ContosoUniversityBlazor.Application.Common.Mappings;
using ContosoUniversityBlazor.Domain.Entities;
using ContosoUniversityBlazor.Domain.Enums;

namespace ContosoUniversityBlazor.Application.Students.Queries.GetStudentDetails
{
    public class StudentDetailsEnrollmentVM : IMapFrom<Enrollment>
    {
        public string CourseTitle { get; set; }

        public Grade? Grade { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Enrollment, StudentDetailsEnrollmentVM>()
                .ForMember(d => d.CourseTitle, opt => opt.MapFrom(s => s.Course.Title))
                .ForMember(d => d.Grade, opt => opt.MapFrom(s => s.Grade));
        }
    }
}