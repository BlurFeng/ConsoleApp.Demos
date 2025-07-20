using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.ClassesDemo.Utils;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    // 关于类的继承：
    // 类可以通过继承来扩展或修改其功能。子类通常在定义上是父类的一个种类或特化。
    // 继承允许一个类（子类）从另一个类（父类）获取属性和方法。
    // 子类可以添加新的属性和方法，或者重写父类的方法以改变其行为。
    // Inheritance in classes:
    // A class can extend or modify its functionality through inheritance. A subclass is typically a kind or specialization of the parent class.
    // Inheritance allows a class (subclass) to inherit properties and methods from another class (parent class).
    // A subclass can add new properties and methods, or override methods from the parent class to change their behavior.

    public class Student : Person
    {
        public void GenerateStudentIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("STU");
        }
    }
}
