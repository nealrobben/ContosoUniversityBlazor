using AutoMapper;
using ContosoUniversityBlazor.Application.Common.Mappings;

namespace ContosoUniversityBlazor.Application.Instructors.Queries.GetInstructorsOverview
{
    public class CourseAssignmentVM : IMapFrom<Domain.Entities.CourseAssignment>
    {
        public int CourseID { get; set; }

        public string CourseTitle { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.CourseAssignment, CourseAssignmentVM>()
                .ForMember(d => d.CourseTitle, opt => opt.MapFrom(s => s.Course.Title));
        }
    }
}
