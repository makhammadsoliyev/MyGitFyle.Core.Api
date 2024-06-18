using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitFyle.Core.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
        => Ok("Hello, Senior Software Engineer. Have a nice day.");
}
