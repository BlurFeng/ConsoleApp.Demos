namespace ConsoleApp.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* - Arrays - *************");

            // -- Tips Start -- //
            // 数组是一个固定大小的集合，通常用于存储同一类型的数据。
            // 当你知道你需要存储多少个元素时，数组是一个很好的选择。
            // 它的性能通常比列表更好，因为它们在内存中是连续存储的。且在内存中分配的空间是连续的，且之后不会改变。
            // Arrays are a fixed-size collection, typically used to store data of the same type.
            // Arrays are a good choice when you know how many elements you need to store.
            // They generally perform better than lists because they are stored contiguously in memory.
            // -- Tips End -- //

            // 要求用户输入有多少个学生的成绩需要输入。
            // Tell me how many students adn grades are to be entered
            Console.Write("Please indicate the number of grades to be entered: ");
            int numberOfGrades = Convert.ToInt32(Console.ReadLine());

            // 声明固定大小的数组。当你声明一个数组时，系统会为你分配一块连续的内存空间。
            // Declare Fixed Size Array
            int[] grades = new int[numberOfGrades];
            string[] students = new string[numberOfGrades];

            // 5个空间地址/索引 - 0, 1, 2, 3, 4。
            // 如果n是数组的大小，那么你的数组的地址范围是从0到n-1。这是计算机科学中的一个常见约定。
            // 5 space addresses/indexes - 0, 1, 2, 3, 4
            // If n is the size of the array, then your array has addresses between 0 to n-1

            // 添加值到固定大小的数组。
            // Add values to Fixed Size Array
            //grades[0] = 45;
            //grades[1] = 25;
            //grades[2] = 38;
            //grades[3] = 45;
            //grades[4] = 54;

            // 通过循环来添加值到固定大小的数组。
            // Use a loop to add values to Fixed Size Array
            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.Write("Enter Student Name: ");
                students[i] = Console.ReadLine();

                Console.Write("Enter Grade: ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            // 打印固定大小数组中的值。
            // Print values in Fixed Size Array
            Console.WriteLine("The Grades you have entered are: ");
            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.WriteLine($"{students[i]}: {grades[i]}");
            }

            // Print values in list - foreach
            //foreach (int g in grades)
            //{
            //    Console.WriteLine(g);
            //}

            // Declare Variable Sized Array
            //string[] studentNames =  { "Newton", "Joshua", "etc..." };

            //// Add values to Variable Sized Array
            //for (int i = 0; i < studentNames.Length; i++)
            //{
            //    Console.Write("Enter Student Name: ");
            //    studentNames[i] = Console.ReadLine();
            //}

            //// Print values in Variable Sized Array
            //Console.WriteLine("The student names you have entered are: ");
            //for (int i = 0; i < studentNames.Length; i++)
            //{
            //    Console.WriteLine(studentNames[i]);
            //}
        }
    }
}
