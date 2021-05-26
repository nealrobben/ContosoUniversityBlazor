using AutoMapper;
using ContosoUniversityBlazor.Domain.Entities;
using ContosoUniversityBlazor.Application.Common.Mappings;

namespace ContosoUniversityBlazor.Application.Instructors.Queries.GetInstructorsLookup
{
    public class InstructorLookupVM : IMapFrom<Instructor>
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Instructor, InstructorLookupVM>();
        }

        public override string ToString()
        {
            return $"{ID} - {FullName}";
        }
    }
}
