
using ConsoleApp1;
using ConsoleApp1.Constants;

Console.WriteLine(Messages.GreetingMessage);

Console.WriteLine(Messages.Options);
int input = Convert.ToInt32(Console.ReadLine());

User user = new User();

switch (input)
{
    case 1:
        user.signup();
        break;
    case 2:
        user.login();
        break;
    default:
        Environment.Exit(0);
        break;

}


