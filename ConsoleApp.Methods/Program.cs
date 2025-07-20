using System.ComponentModel.DataAnnotations;

namespace ConsoleApp.Methods
{
    internal class Program
    {
        // 此方法是程序的入口点。是静态方法。
        // This method is the entry point of the program. It is a static method.
        static void Main(string[] args)
        {
            Console.WriteLine("************* - Methods - *************");

            // -- Tips Start -- //
            // 以下方法都是Main方法中的局部方法。只能在Main方法中调用。
            // 在实际应用中，方法可以在类的任何位置定义，并且可以是静态或实例方法。
            // 一般我们会定义在类的顶部或底部。很少直接定义在某个方法内部。
            // 并且方法会在不同类之间调用。
            // The following methods are local methods within the Main method. They can only be called within the Main method.
            // In practice, methods can be defined anywhere in the class and can be static or instance methods.
            // Typically, we define them at the top or bottom of the class. It's rare to define them directly within another method.
            // And methods are called between different classes.
            // -- Tips End -- //

            // void 方法 - 完成任务而不返回值。
            // void methods - complete a task without returning a value
            void PrintName()
            {
                // Method code
                Console.WriteLine("Trevoir");
            }

            // 返回值方法 - 在操作后返回一个值。
            // value returning methods - returns a value after an operation
            int GetFiveYearsAgo()
            {
                int year = DateTime.Now.AddYears(-5).Year;
                return year;
            }

            // 有参数的方法 - 表示传递到方法中的数据。
            // methods with parameters - represent data being passed into a method.
            void PrintNameWithParams(string name)
            {
                // Method code
                Console.WriteLine("You name is: " + name);
            }

            // 获取年份差异的方法 - 计算当前年份与传入年数之间的差异。
            int GetYearDifferenceWithParams(int year)
            {
                int yearDifference = DateTime.Now.Year - year;
                return yearDifference;
            }

            // 带有可选参数的方法 - 参数不是必需的，也有默认值。
            // methods with optional parameters - parameter is not required..also has a default value
            int GetFutureOrPastYear(int numberOfYears = 0)
            {
                var year = DateTime.Now.AddYears(numberOfYears).Year;
                return year;
            }

            // 有可空参数的方法 - 允许传递 null 值的参数。
            // methods with nullable parameters
            void PrintNameNullableParam(string? name, int? count)
            {
                //if (string.IsNullOrEmpty(name))
                //{
                //    name = "Default Name";
                //}

                //if(!count.HasValue)
                //{
                //    count = 1;
                //}

                // The null-coalescing assignment operator ??= assigns the value of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to null.
                https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
                name ??= "Default Name";
                count ??= 1;

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(name);
                }
            }

            // 调用方法示例。
            /* Function Calls */
            PrintName();
            int fiveYearsAgo = GetFiveYearsAgo();
            Console.WriteLine("Five Years Ago was: " + fiveYearsAgo);

            Console.WriteLine("Enter your name");
            string name1 = Console.ReadLine();
            PrintNameWithParams(name1);

            Console.WriteLine("Enter a year");
            int pastYear = Convert.ToInt32(Console.ReadLine());
            int yearsAgo = GetYearDifferenceWithParams(pastYear);
            Console.WriteLine("This was " + yearsAgo + " years ago");

            Console.WriteLine("Enter number of years in the future or past");
            int numberOfYears = Convert.ToInt32(Console.ReadLine());

            var pastYear1 = GetFutureOrPastYear();
            Console.WriteLine("The year is: " + pastYear1);

            var pastYear2 = GetFutureOrPastYear(numberOfYears);
            Console.WriteLine("The year is: " + pastYear2);

            PrintNameNullableParam(null, null);
            PrintNameNullableParam("Chester", 5);
        }

        // 静态方法 - 可以在没有实例化类的情况下调用。
        // static methods - can be called without instantiating the class.
        public static void PrintNameStatic()
        {
            // Static method code
            Console.WriteLine("Trevoir");
        }
    }
}
