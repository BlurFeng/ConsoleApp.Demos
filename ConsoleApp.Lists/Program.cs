namespace ConsoleApp.Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* - Lists - *************");

            // -- Tips Start -- //
            // 列表是一个动态大小的集合，通常用于存储同一类型的数据。
            // 当你不知道需要存储多少个元素时，列表是一个很好的选择。
            // 列表可以根据需要动态调整大小，允许你添加或删除元素。
            // 但列表的性能通常比数组稍差（但通常不必太在意），其实列表也是有长度的，当Add操作超过当前长度时，列表会自动扩展。
            // 这会开辟新的内存空间，并将现有元素复制到新的内存空间中。旧的内存空间会被释放。
            // Lists are a dynamic-size collection, typically used to store data of the same type.
            // Lists are a good choice when you don't know how many elements you need to store.
            // Lists can dynamically resize as needed, allowing you to add or remove elements.
            // However, lists generally perform slightly worse than arrays (but usually not a big deal).
            // Lists also have a length, and when the Add operation exceeds the current length, the list automatically expands.
            // -- Tips End -- //

            // 声明一个列表。
            // Declare a List
            List<int> grades = new List<int>();
            List<string> students = new List<string>();
            int grade = 0;
            string name;
            int gradeCount = 0;
            int @continue;
            //var grades = new List<int>();
            //List<int> grades = new();

            // 添加值到列表。
            // Add values to list
            //grades.Add(45);
            //grades.Add(95);
            //Console.WriteLine(grades[0]);
            //Console.WriteLine(grades[1]);

            // 通过循环来添加值到列表。
            do
            {
                gradeCount += 1;
                Console.Write("Enter Student Name: ");
                name = Console.ReadLine();
                students.Add(name);

                Console.Write("Enter Grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade != -1)
                {
                    grades.Add(grade);
                }

                Console.Write("Do you wish to continue? (1 = yes | 2 = no): ");
                @continue = Convert.ToInt32(Console.ReadLine());
            } while (@continue == 1);

            // 打印列表中的值。
            // Print values in list - for
            Console.WriteLine("The Grades you have entered are: ");
            for (int i = 0; i < gradeCount; i++)
            {
                Console.WriteLine($"{students[i]}: {grades[i]}");
            }

            //Console.WriteLine("Printing grades via for loop");
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    Console.WriteLine(grades[i]);
            //}

            //// Print values in list - foreach
            //Console.WriteLine("Printing grades via foreach loop");
            //foreach (int g in grades)
            //{
            //    Console.WriteLine(g);
            //}
        }
    }
}
