public class LoginService : ILoginService
{
    public LoginService() { }

    public async Task<(bool IsSuccess, string ErrorMessage)> ValidateAccount(string userId, string password)
    {
        if (string.IsNullOrEmpty(userId))
        {
            return (false, "Please enter the User ID");
        }

        if(userId != "joseninogarcia")
        {
            return (false, "Incorrect User ID");
        }

        if(password != "123456")
        {
            return (false, "Password is incorrect");
        }

        return (true, string.Empty);
    }
}