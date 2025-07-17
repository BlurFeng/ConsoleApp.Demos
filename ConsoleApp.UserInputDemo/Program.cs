namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 声明变量。
            string name = string.Empty;
            int age = 0;
            int retirementAge = 65;

            // 提示用户输入姓名和年龄。
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();

            // 提示用户输入年龄。
            Console.WriteLine("Please enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            // 处理数据。
            int workingYearsRemaining = retirementAge - age;

            // 输出结果。
            Console.WriteLine($"Full name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
        }
    }
}
