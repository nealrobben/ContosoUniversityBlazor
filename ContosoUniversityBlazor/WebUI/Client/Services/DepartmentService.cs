﻿using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebUI.Shared.Departments.Queries.GetDepartmentsOverview;

namespace WebUI.Client.Services
{
    public class DepartmentService
    {
        private HttpClient _http;

        public DepartmentService(HttpClient http)
        {
            _http = http;
        }

        public async Task<DepartmentsOverviewVM> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<DepartmentsOverviewVM>("/api/departments");
        }
    }
}
