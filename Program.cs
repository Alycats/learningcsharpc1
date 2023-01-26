namespace learningcsharpc1;
class Program
{
    static void Main(string[] args)
    {
        Multiplication();
        Console.ReadKey(true);
    }


    static void conditions()
    {
        //check if x is larger than y
        int x = 20;
        int y = 20;

        if (x == y)
        {
            Console.WriteLine("x and y are equal");
        }
        else if(y > x)
        {
             Console.WriteLine("y is greater than x");
        }
        else
        {
            Console.WriteLine("x is greater than y");
        }

    }



    static void BirthdayAge()
    {
        string name;
        string birthdayTHisYear = "yes";
        int yearOfBirth =2000;
        int year = DateTime.Now.Year;
        int age =1000;


        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("What is your year of birth written xxxx?");
        yearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you had a birthday? Type yes or no.");
        birthdayTHisYear = Console.ReadLine().ToLower();

if (birthdayTHisYear =="yes" || birthdayTHisYear=="y")
{
    age = year - yearOfBirth;
    Console.WriteLine($"Age = {age}");
}
else 
{
    age = year - yearOfBirth-1;
    Console.WriteLine($"Age = {age}");
}
if (age < 18)
{
    Console.WriteLine($"You are a junior {name}");
}
else if (age >= 18 && age < 30)
    {
          Console.WriteLine($"You are a young adult {name}");
    }
else if (age >= 30 && age < 60)
    {
          Console.WriteLine($"You are an adult {name}");
    }
    else
    {
        Console.WriteLine($"You are a senior {name}");
    }
    }



static void Multiplication()
{
    int num =0;
    int i;
    int result;


    Console.WriteLine("Enter the number");
    num = Convert.ToInt32(Console.ReadLine() );

    for ( i= 0; i<=10; i++)
    {
        result = num * i;
        Console.WriteLine($"{num}*{i}={result}");
    }

}


    }
