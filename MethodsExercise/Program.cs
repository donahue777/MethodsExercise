using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(params int[] list)
        {
            int sum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;

        }
        public static int Multiply(int x, int y, int z)
        {
            return x * y * z;
        }
        static void Main(string[] args)
        {
            int tacos = Multiply(8, 7, 11);
            //------------------------------------------Exercise 1-------------------------------------------------------
            Console.WriteLine("Hey, what's your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}, what's your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a wise choice, what is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("so far so good, now what's your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks {userName}, now we can use your information for the entertainment of the masses :D ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Once upon a time there was a person named {userName}.");
            Console.WriteLine($"{userName} has a companion who happens to be this person's favorite animal, and favorite color.");
            Console.WriteLine($"A {color} {animal} may not be your average color for a {animal}, but life is full of mysteries.");
            Console.WriteLine($"{userName} and the {animal} listened to {userName}'s favorite band {band} over and over");
            Console.WriteLine("for themselves and the forest's inhabitents to hear day and night for as long as they lived.");
            Console.WriteLine("The End.");

            //------------------------------------------Exercise 2-------------------------------------------------------
            Console.WriteLine("Input a number to add.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input a number to add to the first number.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one.");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the previous two.");
            int z = int.Parse(Console.ReadLine());

            int product = Multiply(x, y, z);
            Console.WriteLine($"The product is: {product}");

        }
    }
}
