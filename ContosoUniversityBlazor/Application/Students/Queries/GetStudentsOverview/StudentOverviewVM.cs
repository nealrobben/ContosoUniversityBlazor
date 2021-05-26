using AutoMapper;
using ContosoUniversityBlazor.Application.Common.Mappings;
using ContosoUniversityBlazor.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversityBlazor.Application.Students.Queries.GetStudentsOverview
{
    public class StudentOverviewVM : IMapFrom<Student>
    {
        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Student, StudentOverviewVM>()
                .ForMember(d => d.StudentID, opt => opt.MapFrom(s => s.ID))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstMidName));
        }
    }
}
