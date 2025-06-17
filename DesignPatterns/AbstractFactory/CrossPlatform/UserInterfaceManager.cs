using CrossPlatform.Client;

namespace CrossPlatform;

public class UserInterfaceManager(IUserInterfaceApplication userInterfaceApplication)
{
    private readonly IUserInterfaceApplication _userInterfaceApplication = userInterfaceApplication;

    public void Run(string[] args)
    {
        _userInterfaceApplication.CreateLoginForm();
    }
}
