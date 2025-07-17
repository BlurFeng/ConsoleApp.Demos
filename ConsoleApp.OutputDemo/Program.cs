namespace ConsoleApp.OutputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 在控制台输出文本并换行。换行符被自动添加到末尾。之后输出的文本将出现在新的一行。
            Console.WriteLine("Hello, World! My name is Blur.");
            Console.WriteLine("I am from China");

            // 在控制台输出文本但不换行。
            Console.Write("Line1");
            Console.Write("Line2");
        }
    }
}
