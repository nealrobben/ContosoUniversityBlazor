using System.Collections.Generic;

namespace ContosoUniversityBlazor.Application.Students.Queries.GetStudentsForCourse
{
    public class StudentsForCourseVM
    {
        public IList<StudentForCourseVM> Students { get; }

        public StudentsForCourseVM(IList<StudentForCourseVM> students)
        {
            Students = students;
        }
    }
}
