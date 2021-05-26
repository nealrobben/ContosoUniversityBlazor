using System.Collections.Generic;

namespace ContosoUniversityBlazor.Application.Instructors.Queries.GetInstructorsLookup
{
    public class InstructorsLookupVM
    {
        public IList<InstructorLookupVM> Instructors { get; }

        public InstructorsLookupVM(IList<InstructorLookupVM> instructors)
        {
            Instructors = instructors;
        }
    }
}
