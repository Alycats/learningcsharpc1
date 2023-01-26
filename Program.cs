namespace learningcsharpc1;
class Program
{
    static void Main(string[] args)
    {
        conditions();
        Console.ReadKey(true);
    }


    static void conditions()
    {
        //check if x is larger than y
        int x = 20;
        int y = 2;

        if (x > y)
        {
            Console.WriteLine("x is greater than y");
        }

    }



    static void BirthdayAge()
    {
        string name;
        string birthdayTHisYear;
        int yearOfBirth;



        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("What is your year of birth written xxxx?");
        yearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you had a birthday? Type yes or no.");
        birthdayTHisYear = Console.ReadLine();
    }

    }
