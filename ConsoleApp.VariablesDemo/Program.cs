namespace ConsoleApp.VariablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * text - string
             * integers - int, long, short, byte
             * decimal - decimal, double, float
             * logical - bool
             */
            string name = "Blur";
            Console.WriteLine("Name: " + name);
            Console.WriteLine(string.Format("Hello, World! I am {0}.", name));
            Console.WriteLine("They call me {0}.", name);
            Console.WriteLine($"I was given the name {name}.");

            int age = 54;
            int retirementAge = 65;
            int retirementYearLeft = retirementAge - age;
            Console.WriteLine("My age is " + age + ".");
            Console.WriteLine($"I will retire in {retirementYearLeft} years, at the age of {retirementAge}.");
        
            bool isRetired = age >= retirementAge;
            Console.WriteLine($"Am I Retired? " + isRetired);
        }
    }
}
