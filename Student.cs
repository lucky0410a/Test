using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Student
    {
        public string Name; // Name欄位
        static public int Score; // Score欄位
        public void showMsg()
        {
            Console.WriteLine($"{Name}同學分數: {Score}");
        }

        static public void static_showMsg()
        {
            Console.WriteLine("static_showMsg()!!");
        }
    }
}
