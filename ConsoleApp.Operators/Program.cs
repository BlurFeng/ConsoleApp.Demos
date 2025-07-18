namespace ConsoleApp.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second number:");
            string input = Console.ReadLine();
            int num2 = Convert.ToInt32(input);

            // 相加。
            int sum = num1 + num2;

            // 相减。
            int difference = num1 - num2;

            // 相乘。
            int product = num1 * num2;

            // 相除。
            int quotient = num1 / num2;

            // 取余。
            int modulus = num1 % num2;

            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
            Console.WriteLine($"The difference between {num1} and {num2} is: {difference}");
            Console.WriteLine($"The product of {num1} and {num2} is: {product}");
            Console.WriteLine($"The quotient of {num1} and {num2} is: {quotient}");
            Console.WriteLine($"The modulus of {num1} and {num2} is: {modulus}");
        }
    }
}
