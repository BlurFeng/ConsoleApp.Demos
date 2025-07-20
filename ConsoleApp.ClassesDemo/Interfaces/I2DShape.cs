using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Interfaces
{
    // 关于接口：
    // 接口是一种特殊的类，它只包含方法签名和属性定义，没有具体的实现。
    // 接口像是一个合同，任何实现该接口的类都必须提供接口中定义的方法的具体实现。
    // 然后类通过继承接口来实现这些方法。其他系统通过接口来调用这些方法，而不需要知道具体的实现细节。
    // about interfaces:
    // interface is a special kind of class that only contains method signatures and property definitions, without concrete implementations.
    // An interface is like a contract, and any class that implements the interface must provide concrete implementations of the methods defined in the interface.
    // Classes then inherit the interface to implement these methods. Other systems can call these methods through the interface without needing to know the specific implementation details.

    internal interface I2DShape
    {
        double Perimeter();
    }
}
