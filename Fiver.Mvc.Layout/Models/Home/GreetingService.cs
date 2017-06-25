namespace Fiver.Mvc.Layout.Models.Home
{
    public interface IGreetingService
    {
        string Greet(string firstname, string surname);
    }

    public class GreetingService : IGreetingService
    {
        public string Greet(string firstname, string surname)
        {
            return $"Hello {firstname} {surname}";
        }
    }
}
