using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebUI.Shared.Courses.Queries.GetCourseDetails;
using WebUI.Shared.Courses.Queries.GetCoursesOverview;

namespace WebUI.Client.Services
{
    public class CourseService : ServiceBase
    {
        public CourseService(HttpClient http) : base(http)
        {
        }

        public async Task<CoursesOverviewVM> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<CoursesOverviewVM>("/api/courses");
        }

        public async Task<CourseDetailVM> GetAsync(string id)
        {
            return await _http.GetFromJsonAsync<CourseDetailVM>($"/api/courses/{id}");
        }

        public async Task<HttpResponseMessage> DeleteAsync(string id)
        {
            return await _http.DeleteAsync($"/api/courses/{id}");
        }
    }
}
