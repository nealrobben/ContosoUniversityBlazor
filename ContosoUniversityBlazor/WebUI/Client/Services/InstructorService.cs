using System.Net.Http;

namespace WebUI.Client.Services
{
    public class InstructorService : ServiceBase
    {
        public InstructorService(HttpClient http) : base(http)
        {
        }
    }
}
