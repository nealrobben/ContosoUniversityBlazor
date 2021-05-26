﻿using AutoMapper;
using ContosoUniversityBlazor.Application.Common.Mappings;
using ContosoUniversityBlazor.Domain.Entities;
using System;

namespace ContosoUniversityBlazor.Application.Departments.Queries.GetDepartmentsOverview
{
    public class DepartmentVM : IMapFrom<Department>
    {
        public int DepartmentID { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public string AdministratorName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Department, DepartmentVM>()
                .ForMember(d => d.AdministratorName, opt => opt.MapFrom(s => s.Administrator != null ? s.Administrator.FullName : string.Empty));
        }

        public override string ToString()
        {
            return $"{DepartmentID} - {Name}";
        }
    }
}
