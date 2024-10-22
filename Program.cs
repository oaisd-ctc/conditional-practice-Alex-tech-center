
public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
         CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
         CheckForPositiveNegativeZero(1); // This should output: "Your number is zero"
         CheckForPositiveNegativeZero(0); // This should output: "Your number is positive"
        FindMinimum(1,2,3);
        FindMinimum(2,1,3);
        FindMinimum(3,2,1);
        FindMaximum(1,2,3);
        FindMaximum(2,1,3);
        FindMaximum(3,2,1);
        IsDivisibleBy5(6);
        IsDivisibleBy5(5);
        CheckEvenOrOdd(3);
        CheckEvenOrOdd(2);
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');
         DisplayDayOfWeek(0); // This should output: "Sunday"
         DisplayDayOfWeek(1);
         DisplayDayOfWeek(2);
         DisplayDayOfWeek(3);
         DisplayDayOfWeek(4);
         DisplayDayOfWeek(5);
         DisplayDayOfWeek(6);
         DisplayDayOfWeek(7);

    }
        public static void CheckForPositiveNegativeZero(int number)
        {
            if (number <= -1) 
            {
                Console.WriteLine("Your number is a negative.");
            }

            else if (number == 0)
            {
                Console.WriteLine("Your number is zero.");
            }

            else if (number >= 1)
            {
                Console.WriteLine("Your number is postive");
            }

        }

            public static void FindMinimum(int num1, int num2, int num3)
            {

                if (num1 <= num2 && num1 <= num3)
                {
                    Console.WriteLine("The Minimum is " + num1 + ".");
                }

                else if (num2 <= num1 && num2 <= num3)
                {
                    Console.WriteLine("The Minimum is " + num2 + ".");
                }

                else if (num3 <= num1 && num3 <= num2)
                {
                    Console.WriteLine("THe Minimum is " + num3 + ".");
                }

            }

             public static void FindMaximum(int num1, int num2, int num3)
             {
                 if (num1 <= num2 && num1 <= num3)
                 {
                    Console.WriteLine("THe Maximum is " + num3 + ".");
                 }

                 else if (num2 <= num1 && num2 <= num3)
                 {
                    Console.WriteLine("The Maximum is " + num3 + ".");
                 }

                 else if (num3 <= num1 && num3 <= num2)
                 {
                    Console.WriteLine("The Maximum is " + num1 + ".");
                 }
             }

             public static void IsDivisibleBy5(int number)
             {

                if (number ==  6)
                {
                    Console.WriteLine(number + " is not divisible by 5.");
                }

                else if (number == 5)
                {
                    Console.WriteLine(number + " is divisible by 5.");
                }

             }

             public static void CheckEvenOrOdd(int number)
             {

                if (number == 3)
                {
                    Console.WriteLine(number + " is an odd number.");
                }
                
                else if (number == 2)
                {
                    Console.WriteLine(number + " is an even number.");
                }

             }

             public static void CheckVowelOrConsonant(char letter)
             {

                if (letter == 'e')
                {
                    Console.WriteLine(letter + " is a vowel");
                }

                else if (letter == 't')
                {
                    Console.WriteLine(letter + " is a consonant.");
                }

             }

             public static void DisplayDayOfWeek(int dayCode)
             {

                if (dayCode == 0)
                {
                    Console.WriteLine("Sunday");
                }

                else if (dayCode == 1)
                {
                    Console.WriteLine("Monday");
                }

                else if (dayCode == 2)
                {
                    Console.WriteLine("Tuesday");
                }

                else if (dayCode == 3)
                {
                    Console.WriteLine("Wednesday");
                }

                else if (dayCode == 4)
                {
                    Console.WriteLine("Thursday");
                }

                else if (dayCode == 5)
                {
                    Console.WriteLine("Friday");
                }

                else if (dayCode == 6)
                {
                    Console.WriteLine("Saturday");
                }


             }

             




    
    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:

}
