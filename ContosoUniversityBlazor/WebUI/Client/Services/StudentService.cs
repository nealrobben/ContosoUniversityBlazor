﻿using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebUI.Shared.Students.Queries.GetStudentDetails;
using WebUI.Shared.Students.Queries.GetStudentsOverview;

namespace WebUI.Client.Services
{
    public class StudentService : ServiceBase
    {
        public StudentService(HttpClient http) : base(http)
        {
        }

        public async Task<StudentsOverviewVM> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<StudentsOverviewVM>("/api/students");
        }

        public async Task<StudentDetailsVM> GetAsync(string id)
        {
            return await _http.GetFromJsonAsync<StudentDetailsVM>($"/api/students/{id}");
        }
    }
}
