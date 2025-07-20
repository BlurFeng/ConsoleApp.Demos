using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    // 关于类：
    // 类是面向对象编程的基本构建块。
    // 类通过抽象化现实世界的实体来定义对象的属性和行为。
    // 比如一个人，他有名字、姓氏、出生日期等属性。有吃饭、睡觉等行为。
    // 然后通过类的实例化，我们可以创建一个具体的人对象。
    // 比如一个“人”类叫“张三”，他有名字“张”，姓氏“三”，出生日期“1990年1月1日”等属性。
    // About classes:
    // A class is the fundamental building block of object-oriented programming.
    // A class defines the properties and behaviors of an object by abstracting real-world entities.
    // For example, a person has properties like first name, last name, and date of birth, and behaviors like eating and sleeping.
    // By instantiating a class, we can create a specific object of that class.
    // For example, a "Person" class named "Zhang San" has properties like first name "Zhang", last name "San", and date of birth "January 1, 1990".

    public partial class Person
    {
        public Person()
        {

        }

        public Person(string firstName, string lastName, string taxNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            _taxNumber = taxNumber;
        }

        // Properties/Data Members
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateofBirth { get; set; }

        // Field member
        private string _taxNumber;
        protected string _idNumber = "N/A";


        public void PrintFullName()
        {
            var type = GetType().Name;
            Console.WriteLine($"{type} name: {FirstName} {LastName}");
        }

        public void PrintInitials()
        {
            var type = GetType().Name;
            var firstInitial = FirstName[0];
            var lastInitial = LastName[0];
            Console.WriteLine($"{type} initials: {firstInitial} {lastInitial}");
        }

        public void GenerateTaxNumber()
        {
            if (string.IsNullOrEmpty(_taxNumber))
            {
                _taxNumber = GetRandomNumber();
            }
            else
            {
                Console.WriteLine($"Tax number already exists for {FirstName} {LastName}");
            }
        }

        public string GetTaxNumber()
        {
            return _taxNumber;
        }

        public string GetIdNumber()
        {
            return _idNumber;
        }

        protected string GetRandomNumber()
        {
            return RandomNumberGenerator
                    .GetInt32(100000, 9999999)
                    .ToString();
        }
    }
}
