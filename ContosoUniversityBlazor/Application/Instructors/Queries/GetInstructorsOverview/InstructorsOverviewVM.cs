using ContosoUniversityBlazor.Application.Instructors.Queries.GetInstructorsOverview;
using System.Collections.Generic;

namespace ContosoUniversityCQRS.Application.Instructors.Queries.GetInstructorsOverview
{
    public class InstructorsOverviewVM
    {
        public IList<InstructorVM> Instructors { get; }

        public InstructorsOverviewVM(IList<InstructorVM> instructors)
        {
            Instructors = instructors;
        }
    }
}