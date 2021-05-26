using MediatR;
using System;

namespace ContosoUniversityBlazor.Application.Departments.Commands.UpdateDepartment
{
    public class UpdateDepartmentCommand : IRequest
    {
        public int? DepartmentID { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public byte[] RowVersion { get; set; }

        public int? InstructorID { get; set; }
    }
}
