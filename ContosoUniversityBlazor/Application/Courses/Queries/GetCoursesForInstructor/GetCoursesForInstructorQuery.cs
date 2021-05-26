using ContosoUniversityBlazor.Application.Courses.Queries.GetCoursesForInstructor;
using MediatR;

namespace ContosoUniversityBlazor.Application.Courses.Queries.GetCoursesOverview
{
    public class GetCoursesForInstructorQuery : IRequest<CoursesForInstructorOverviewVM>
    {
        public int? ID { get; set; }

        public GetCoursesForInstructorQuery(int? id)
        {
            ID = id;
        }
    }
}
