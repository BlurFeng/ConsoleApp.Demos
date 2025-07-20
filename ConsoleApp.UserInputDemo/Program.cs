using System.Globalization;

namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 声明变量。

            char choice = char.MinValue;
            string? firstName = string.Empty;
            string lastName = string.Empty;
            int age;
            DateOnly dob = new DateOnly();
            decimal salary;
            char gender = char.MinValue;
            bool working = true;

            List<Person> persons = new List<Person>();

            while (choice != 'E')
            {
                // 提示用户输入信息。
                // Prompt the user for input
                Console.Write("Please enter your first name: ");
                firstName = Console.ReadLine();

                Console.Write("Please enter your last name: ");
                lastName = Console.ReadLine();

                Console.Write("Please enter your date of birth (dd/mm/yyyy): ");
                dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Please enter your salary: ");
                salary = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Please enter your gender (M or F): ");
                gender = Convert.ToChar(Console.ReadLine());

                Console.Write("Are you working? (true or false): ");
                working = Convert.ToBoolean(Console.ReadLine());

                Person person = new(dob)
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Gender = gender,
                    IsWorking = working,
                    Salary = salary
                };
                persons.Add(person);

                //persons.Add(new Person(dob)
                //{
                //    FirstName = firstName,
                //    LastName = lastName,
                //    Gender = gender,
                //    IsWorking = working,
                //    Salary = salary
                //});

                // 提示用户是否继续。
                // Prompt the user to continue.
                Console.WriteLine("C - Continue | E - Exit");
                choice = Convert.ToChar(Console.ReadLine());
            }

            foreach (var person in persons)
            {
                // 输出结果。
                // Output the results to the user
                Console.WriteLine();
                Console.WriteLine($"Full name: {person.ToString()}");
                Console.WriteLine($"Age: {person.GetAge()}");
                Console.WriteLine($"Your Salary is: {person.Salary.ToString("C")}");
                Console.WriteLine($"Your Gender is: {person.Gender}");
                Console.WriteLine($"You Are Employed: {person.IsWorking}");
                Console.WriteLine($"Number of working years remaining: {person.GetNumberOfWorkingYearsRemaining()}");
                Console.WriteLine($"Estimated Retirement year: {person.GetEstimatedRetirementDate().Year}");
            }
        }
    }
}
