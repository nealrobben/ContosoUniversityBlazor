using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebUI.Shared.Instructors.Queries.GetInstructorDetails;
using WebUI.Shared.Instructors.Queries.GetInstructorsOverview;

namespace WebUI.Client.Services
{
    public class InstructorService : ServiceBase
    {
        public InstructorService(HttpClient http) : base(http)
        {
        }

        public async Task<InstructorsOverviewVM> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<InstructorsOverviewVM>("/api/instructors");
        }

        public async Task<InstructorDetailsVM> GetAsync(string id)
        {
            return await _http.GetFromJsonAsync<InstructorDetailsVM>($"/api/instructors/{id}");
        }
    }
}
