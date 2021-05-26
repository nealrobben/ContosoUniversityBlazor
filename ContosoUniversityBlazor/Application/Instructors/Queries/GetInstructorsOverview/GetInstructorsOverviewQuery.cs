using MediatR;

namespace ContosoUniversityCQRS.Application.Instructors.Queries.GetInstructorsOverview
{
    public class GetInstructorsOverviewQuery : IRequest<InstructorsOverviewVM>
    {
    }
}
