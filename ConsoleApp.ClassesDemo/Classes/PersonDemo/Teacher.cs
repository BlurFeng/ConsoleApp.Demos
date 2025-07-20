using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.ClassesDemo.Utils;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public class Teacher : Person
    {
        public void GenerateTeacherIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("TCH");
        }
    }
}
