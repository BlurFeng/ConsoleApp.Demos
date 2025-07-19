namespace ConsoleApp.ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 接受用户输入的年龄并打印到屏幕上。如果收到无效输入，则显示错误消息。
            // Write a program that takes a user's age as input and prints it to the screen. Display an error message if an invalid input is received.
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"You are {age} years old. ");
            }
            catch (Exception)
            {
                Console.WriteLine("Your age value was incorrect, please try again. ");
                //throw;
            }
            finally
            {
                Console.WriteLine("********** - Thank you for using this program - ***********");
            }
        }
    }
}
