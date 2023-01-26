namespace learningcsharpc1;
class Program
{
    static void Main(string[] args)
    {
string username;
int responsetwo;
int response;



        Console.WriteLine("What is your name?");
        username = Console.ReadLine();
        Console.WriteLine("What is your year of birth written xxxx?");
        response = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Have you had a birthday? Type yes=1 or no=2.");
        responsetwo = Convert.ToInt32(Console.ReadLine() );


        Console.ReadKey(true);
    }
}
