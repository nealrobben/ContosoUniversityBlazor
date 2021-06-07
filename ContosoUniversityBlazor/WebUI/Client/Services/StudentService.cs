using System.Net.Http;

namespace WebUI.Client.Services
{
    public class StudentService : ServiceBase
    {
        public StudentService(HttpClient http) : base(http)
        {
        }
    }
}
