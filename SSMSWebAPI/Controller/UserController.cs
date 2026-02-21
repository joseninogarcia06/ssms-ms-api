using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]/[action]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetData()
    {
        return Ok(new { Message = "ok" });
    }
}