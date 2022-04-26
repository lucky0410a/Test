using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class AbstractClass
    {
        public string name;
        public static void run()
        {
            Console.WriteLine("run()");
        }
        public abstract void absRun();
    }

    class SubClass : AbstractClass
    {
        public override void absRun()
        {
            Console.WriteLine("absRun()");
        }
    }
}
