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

            // -- Math Operations and operators -- //

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

            Console.WriteLine("***************** Math Results **************");
            Console.WriteLine("");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Modulus: {modulus}");
            Console.WriteLine("");
            Console.WriteLine("***************** End Math Results **************");

            // -- Logic Operations and Operators -- //

            bool isGreaterThan = num1 > num2;
            bool isLessThan = num1 < num2;
            bool isEqualTo = num1 == num2;
            bool isGreaterThanOrEqualTo = num1 >= num2;
            bool isLessThanOrEqualTo = num1 <= num2;
            bool isNotEqual = num1 != num2;

            Console.WriteLine("***************** Logic Results **************");
            Console.WriteLine();
            Console.WriteLine($"Is Greater Than: {isGreaterThan}");
            Console.WriteLine($"Is Less Than: {isLessThan}");
            Console.WriteLine($"Is Equal To: {isEqualTo}");
            Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
            Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
            Console.WriteLine($"Is Not Equal: {isNotEqual}");
            Console.WriteLine();
            Console.WriteLine("***************** End Logic Results **************");
        }
    }
}
