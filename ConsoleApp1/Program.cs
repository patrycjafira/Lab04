/*zad1*/
class Program1
{
    static double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
    {
        return a * x * x + b * x + c;
    }
}


/*zad2*/

class Program2
{
    static void Swap(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        double x = 10;
        double y = 20;
        Swap(ref x, ref y);
        Console.WriteLine($"x = {x}, y = {y}");
    }
}

/*zad3*/

class Program3
{
    static double Multiply(double a, double b)
    {
        return a * b;
    }
    static double Multiply(double a, double b, double c)
    {
        return a * b * c;
    }
    static double Multiply(params double[] numbers)
    {
        double result = 1;
        foreach (var num in numbers)
        {
            result *= num;
        }
        return result;
    }

    static void Main()
    {
        double result1 = Multiply(2.0, 3.0);
        Console.WriteLine(result1);

        double result2 = Multiply(2.0, 3.0, 4.0);
        Console.WriteLine(result2);

        double result3 = Multiply(2.0, 3.0, 4.0, 5.0);
        Console.WriteLine(result3);
    }
}


/*zad4*/

enum DayOfTheWeek
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}

class Program4
{
    static void PrintDayDetails(DayOfTheWeek day)
    {
        Console.WriteLine(day);
        Console.WriteLine((int)day);
        if (day == DayOfTheWeek.Saturday || day == DayOfTheWeek.Sunday)
        {
            Console.WriteLine("Jest weekend");
        }
        else
        {
            Console.WriteLine("Dzień pracujący");
        }
    }

    static void Main()
    {
        PrintDayDetails(DayOfTheWeek.Monday);
        Console.WriteLine();
        PrintDayDetails(DayOfTheWeek.Saturday);
        Console.WriteLine();
        PrintDayDetails(DayOfTheWeek.Sunday);
    }
}

/*zad5*/

class Program5
{
    static string FormatDateTime(DateTime date)
    {
        string formattedDate = $"{date.Day}...{date.ToString("MMMM")}...{date.Year}..." +
                               $"{date.Hour:D2}:{date.Minute:D2}:{date.Second:D2}..." +
                               $"{date.DayOfWeek}";

        return formattedDate;
    }

    static void Main()
    {
        DateTime now = DateTime.Now;
        string result = FormatDateTime(now);
        Console.WriteLine(result);
    }
}

/*zad6*/

class Program6
{
    static double Divide(double dividend, double divisor)
    {
        try
        {
            return dividend / divisor;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Nie można dzielić przez 0");
            return 0;
        }
    }

    static void Main()
    {
        double num1 = 10.0;
        double num2 = 0.0;

        double result = Divide(num1, num2);
        Console.WriteLine(result);
        double num3 = 10.0;
        double num4 = 2.0;
        double result2 = Divide(num3, num4);
        Console.WriteLine(result2);
    }
}


/*zad7*/

class Program7
{
    static void SetYourNewPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException("Hasło nie może być puste");
        }

        if (password.Length < 10 ||
            !password.Any(char.IsUpper) ||
            !password.Any(char.IsLower) ||
            !password.Any(char.IsDigit) ||
            !password.Any(c => !char.IsLetterOrDigit(c)))
        {
            throw new FormatException("Hasło musi zawierać dużą litere, cyfrę oraz znak specjlany NIE MOŻE BYC KRÓTSZE NIŻ 10 ZNAKÓW");
        }

        Console.WriteLine("Hasło ustawione popawnie");
    }
    static void TrySetPassword(string password)
    {
        try
        {
            SetYourNewPassword(password);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Main()
    {
        Console.WriteLine("Puste hasło:");
        TrySetPassword(" ");  

        Console.WriteLine("Zbyt krótkie hasło:");
        TrySetPassword("haslo");  

        Console.WriteLine("Hasło bez cyfry:");
        TrySetPassword("Haslo!");  

        Console.WriteLine("Hasło bez znaku specjlnego:");
        TrySetPassword("Haslo123"); 

        Console.WriteLine("Hasło poprawne:");
        TrySetPassword("PoprawneHaslo1!");  
    }
}
