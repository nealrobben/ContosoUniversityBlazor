using System.Collections.Generic;

namespace ContosoUniversityBlazor.Application.Courses.Queries.GetCoursesForInstructor
{
    public class CoursesForInstructorOverviewVM
    {
        public IList<CourseForInstructorVM> Courses { get; }

        public CoursesForInstructorOverviewVM(IList<CourseForInstructorVM> courses)
        {
            Courses = courses;
        }
    }
}
