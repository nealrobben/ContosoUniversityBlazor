using System.Collections.Generic;

namespace WebUI.Shared.Instructors.Queries.GetInstructorsOverview
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