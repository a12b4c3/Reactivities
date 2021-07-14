using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // controller is a placeholder that gets replaced with whatever the class name is, minus controller
    public class baseApiController : ControllerBase
    {
        
    }
}