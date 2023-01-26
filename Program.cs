namespace learningcsharpc1;
class Program
{
    static void Main(string[] args)
    {
string username;

int response;

        Console.WriteLine("What is your name?");
        username = Console.ReadLine();
        Console.WriteLine("What is your year of birth written xxxx?");
        response = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine($"Goodbye, {username}!");
        Console.ReadKey(true);
    }
}
