using System;

class Program
{
    // This is the method declaration inside the Program class
    public static void excerciseOne()
    {
        string namn = "";
        string adress = "";
        string favoritmat = "";

        Console.WriteLine("Vad är ditt namn?");
        namn = Console.ReadLine();

        Console.WriteLine("Vad är din adress?");
        adress = Console.ReadLine();

        Console.WriteLine("Vad är din favoritmat?");
        favoritmat = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Din favoritmat är " + favoritmat);
        Console.WriteLine("Du bor på " + adress);
        Console.WriteLine("Du heter " + namn);
    }
    public static void excerciseTwo()
    {
        int userNumber = 0;
        Console.WriteLine("Ange ett tal");
        userNumber = int.Parse(Console.ReadLine());
        int outputNumber = userNumber * userNumber;
        Console.WriteLine("Kvadraten av ditt tal är " + outputNumber);
    }
    public static void excerciseThree()
    {
        Console.WriteLine("Ange ett tal");
        int userNumber1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ange ännu ett tal");
        int userNumber2 = int.Parse(Console.ReadLine());
        
        int combinedNumber = userNumber1 + userNumber2;
        Console.WriteLine(combinedNumber);
    }
    public static void excerciseFour()
    {
        Console.WriteLine("Skriv in längden på din rektangel");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in bredden på din rektangel");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Arean av din rektangel är " + length * width);
    }
    public static void excerciseFive()
    {
        Console.WriteLine("Ange ett tal");
        int userNumber = int.Parse(Console.ReadLine());
        if (userNumber > 5)
        {
            Console.WriteLine(userNumber * userNumber);
        }
        else if (userNumber > 0 && userNumber < 6)
        {
            Console.WriteLine(userNumber*2);
        }
        else if (userNumber < 0)
        {
            Console.WriteLine(Math.Abs(userNumber));
        }
        else if (userNumber == 0)
        {
            Console.WriteLine("zero");
        }
    }
    public static void excerciseSix()
    {
        Console.WriteLine("Skriv vilket år du är född");
        int birthday = int.Parse(Console.ReadLine());
        int yearToday = DateTime.Now.Year;
        int age = yearToday - birthday;
        Console.WriteLine("Du fyller " + age + " år.");
    }
    public static void excerciseSeven()
    {
        Console.WriteLine("Skriv in ditt namn");
        string namn = Console.ReadLine();
        int length = namn.Length;
        Console.WriteLine("Ditt namn är " + length + " bokstäver långt");
    }
    public static void excerciseEight()
    {
        Console.WriteLine("Ange ett heltal");
        int userNumber = int.Parse(Console.ReadLine());
        Console.Clear();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(userNumber * i);
        }
    }
    public static void excerciseNine()
    {
        Console.WriteLine("Skriv in ett tal");
        int userNumber1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in ännu ett tal");
        int userNumber2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Vilken operation vill du genomföra?");
        Console.WriteLine("1: Addition");
        Console.WriteLine("2: Subtraktion");
        Console.WriteLine("3: Division");
        Console.WriteLine("4: Multiplikation");
        int val = int.Parse(Console.ReadLine());

        switch (val)
        {
            case 1:
                Console.WriteLine(userNumber1 + userNumber2);
                break;
            
            case 2:
                Console.WriteLine(userNumber1 - userNumber2);
                break;

            case 3:
                Console.WriteLine(userNumber1 / userNumber2);
                break;

            case 4:
                Console.WriteLine(userNumber1*userNumber2);
                break;

            default:
                Console.WriteLine("Du måste ange ett av elternativen");
                break;

        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Vilken övning vill du köra? (1-9)");

        int excerciseChoice = int.Parse(Console.ReadLine());

        switch (excerciseChoice)
        {
            case 1:
                excerciseOne();
                break;
            
            case 2:
                excerciseTwo();
                break;
            
            case 3: 
                excerciseThree();
                break;

            case 4:
                excerciseFour();
                break;

            case 5: 
                excerciseFive();
                break;

            case 6:
                excerciseSix();
                break;

            case 7:
                excerciseSeven();
                break;

            case 8:
                excerciseEight();
                break;

            case 9:
                excerciseNine();
                break;
        }
    }
}
