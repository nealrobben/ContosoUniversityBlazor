using ContosoUniversityBlazor.Application.Home.Queries.GetAboutInfo;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ContosoUniversityBlazor.WebUI.Controllers
{
    public class AboutController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<AboutInfoVM>> GetAboutInfo()
        {
            var result = await Mediator.Send(new GetAboutInfoQuery());

            return Ok(result);
        }
    }
}
