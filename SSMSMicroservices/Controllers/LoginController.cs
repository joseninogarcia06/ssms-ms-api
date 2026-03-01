using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]/[action]")]
public class LoginController : ControllerBase
{
    private readonly ILoginService _loginService;

    public LoginController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [HttpPost]
    public async Task<IActionResult> VerifyAccount(VerifyAccountRequestDto request)
    {
        var service = await _loginService.ValidateAccount(request.UserId, request.Password);

        return Ok(new 
        { 
            service.IsSuccess,
            service.ErrorMessage
        });
    }
}