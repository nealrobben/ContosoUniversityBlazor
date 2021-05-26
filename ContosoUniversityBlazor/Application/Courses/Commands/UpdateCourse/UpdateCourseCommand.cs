using MediatR;

namespace ContosoUniversityBlazor.Application.Courses.Commands.UpdateCourse
{
    public class UpdateCourseCommand : IRequest
    {
        public int? CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public int DepartmentID { get; set; }
    }
}
