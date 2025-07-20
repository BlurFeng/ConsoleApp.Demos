using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Utils
{
    // 关于静态类:
    // 静态类是不能被实例化的。
    // 静态类中只能包含静态成员。静态成员能够被直接访问，而不需要创建类的实例。
    // 静态类通常用于提供全局访问的工具方法或常量。
    // about static class:
    // A static class cannot be instantiated.
    // A static class can only contain static members. Static members can be accessed directly without creating an instance of the class.
    // Static classes are typically used to provide globally accessible utility methods or constants.

    /// <summary>
    /// 一个静态工具类，用于帮助个人类进行一些通用操作。
    /// a static utility class to help the Person class with some common operations.
    /// </summary>
    public static class PersonHelper
    {
        public static string GenerateIdNumber(string prefix)
        {
            var randomNumber = RandomNumberGenerator
                .GetInt32(100000, 9999999)
                .ToString();
            return $"{prefix}-{randomNumber}";
        }
    }
}