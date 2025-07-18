namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 声明变量。
            string firstName = string.Empty;
            string lastName = string.Empty;
            int age = 0;
            int retirementAge = 65;
            decimal salary = 0;
            char gender = char.MinValue;
            bool working = true;

            // 提示用户输入姓名和年龄。
            Console.WriteLine("Please enter your first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            lastName = Console.ReadLine();

            // 提示用户输入年龄。
            Console.WriteLine("Please enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your salary:");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter your gender (M or F):");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Are you working? (true or false):");
            working = Convert.ToBoolean(Console.ReadLine());

            // 处理数据。
            int workingYearsRemaining = retirementAge - age;

            // 输出结果。
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Your Salary is: {salary}");
            Console.WriteLine($"Your Gender is: {gender}");
            Console.WriteLine($"You Are Employed: {working}");
            Console.WriteLine($"Working years remaining: {workingYearsRemaining}");


        }
    }
}
