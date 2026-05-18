using ProxyEx.Services;

public class Program
{
    public static void Main()
    {
        IUserService userService = new UserServiceProxy();
        userService.CreateUser("João", 17);
    }
}