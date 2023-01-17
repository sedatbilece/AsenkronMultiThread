using Microsoft.AspNetCore.Mvc;

namespace TaskWebApp.API.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> getContentAsync()
        {
            var mytext =  new HttpClient()
                .GetStringAsync("https://www.google.com");

            //

            var data = await  mytext;

            return Ok(data);
        }
        
    }
}
