using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]/[action]")]
public class LoginController : ControllerBase
{
    public LoginController()
    {
        
    }

    [HttpPost]
    public async Task<IActionResult> VerifyAccount(VerifyAccountRequestDto request)
    {
        return Ok(new 
        { 
            request.UserId,
            request.Password
        });
    }
}