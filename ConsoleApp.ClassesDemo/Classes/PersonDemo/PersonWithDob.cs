using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    // 关于类的部分实现：
    // 当你觉得一个类的实现过于复杂时，可以将其拆分成多个部分。
    // 这可以通过 partial class 关键字来实现。
    // 在不同分布类中按功能或特性将类的实现分开。
    // 或者在一个类中你也可以使用 region 来将代码块分组进行管理。
    // Partial implementation of a class:
    // When you find the implementation of a class too complex, you can split it into multiple parts.
    // This can be done using the partial class keyword.
    // You can separate the implementation of a class into different distributed classes by functionality or feature.
    // Or you can also use regions within a class to group code blocks for better organization.

    public partial class Person
    {
        public Person(string firstName, string lastName, DateOnly dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = dob;
        }


        public int GetAge()
        {
            var age = DateTime.Now.Year - DateofBirth.Year;
            return age;
        }

        public int GetAge(int year)
        {
            var age = year - DateofBirth.Year;
            return age;
        }
    }
}
