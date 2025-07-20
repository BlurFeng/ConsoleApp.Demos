using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using ConsoleApp.ClassesDemo.Classes.ShapeDemo;

namespace ConsoleApp.ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* - Classes and Objects - *************");
            // Read more https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers 
            
            // 定义一个类型为 Person 的对象。默认情况下，这将为 null。如果没有新的实例，它在使用时会给出 null 异常。
            // Define an object of type Person. this will be null by default. Without the new instance, it will give a null exception if it is used.

            Person person;
            // person = new Person(); // Can be initialized at another point of the code. 

            // 声明并使用 new 关键字来实例化一个新的对象。
            // It is best to define and declare a new object. 
            Person baby = new Person();

            // 声明并实例化一个新的对象后，可以设置其属性。
            // Using the . operator, we can access public properties and methods.
            baby.LastName = "Thompson";
            baby.FirstName = "Theresa";
            baby.DateofBirth = new DateOnly(2023, 10, 29);

            // 调用类中定义的方法来打印全名和首字母缩写。
            // Call the methods defined in the class to print full name and initials.
            baby.PrintFullName();
            baby.PrintInitials();
            baby.GenerateTaxNumber();
            var taxNumber = baby.GetTaxNumber();
            Console.WriteLine(taxNumber);

            // 使用非默认构造函数声明对象。你可以自己按需定义构造函数。
            // Object declaration using non-default constructors
            var person1 = new Person("Developer", "One", new DateOnly(2000, 10, 31));
            person1.PrintFullName();
            person1.PrintInitials();

            var person2 = new Person("Developer", "Two", "741852963");
            person2.PrintFullName();
            person2.PrintInitials();
            person2.GenerateTaxNumber();
            var person2IdNumber = person2.GetIdNumber();
            Console.WriteLine(person2IdNumber);

            // 使用从基类派生的来的类。（父类和子类）
            // Using classes derived from the base class.
            // 你可以像这样使用构造函数来初始化对象，一次性设置所有属性。
            // Objects can be initialized like this alternatively, where the object's properties  are set all at once.
            var teacher = new Teacher
            {
                LastName = "Thompson",
                FirstName = "Theresa",
                DateofBirth = new DateOnly(2023, 10, 29)
            };

            teacher.PrintFullName();
            teacher.PrintInitials();
            teacher.GenerateTaxNumber();
            var teachertaxNumber = teacher.GetTaxNumber();
            Console.WriteLine(teachertaxNumber);
            teacher.GenerateTeacherIdNumber();
            var teacherIdNumber = teacher.GetIdNumber();
            Console.WriteLine(teacherIdNumber);


            Student student = new();
            student.LastName = "Thompson";
            student.FirstName = "Theresa";
            student.DateofBirth = new DateOnly(2023, 10, 29);
            student.PrintFullName();
            student.PrintInitials();
            student.GenerateTaxNumber();
            student.GenerateStudentIdNumber();
            var studentIdNumber = student.GetIdNumber();
            Console.WriteLine(studentIdNumber);

            // 抽象类的使用。我们不能直接实例化抽象类，但可以声明和实例化从抽象类派生的类。
            //Polygon polygon = new Polygon(); // compiler error
            Rectangle rectangle = new(10, 20);
            var rectangleArea = rectangle.Area();
            var rectanglePerimeter = rectangle.Perimeter();
            rectangle.GetShapeName();
            Console.WriteLine($"Rectangle perimeter is: {rectanglePerimeter}");
            Console.WriteLine($"Rectangle area is: {rectangleArea}");

            Square square = new(50);
            var sqaureArea = square.Area();
            Console.WriteLine($"Sqaure area is: {sqaureArea}");


            Cuboid cuboid = new(1, 5, 7);
            var cuboidArea = cuboid.Area();
            var cuboidVolume = cuboid.Volume();
            var cuboidPerimeter = cuboid.Perimeter();
            Console.WriteLine($"Cuboid area is: {cuboidArea}");
            Console.WriteLine($"Cuboid volume is: {cuboidVolume}");
            Console.WriteLine($"Cuboid perimeter is: {cuboidPerimeter}");

            Sphere sphere = new(7);
            var sphereCircumference = sphere.Circumference();
            var sphereVolume = sphere.Volume();
            Console.WriteLine($"{nameof(Sphere)} volume is: {sphereVolume}");
            Console.WriteLine($"{nameof(Sphere)} Circumference is: {sphereCircumference}");
        }
    }
}
