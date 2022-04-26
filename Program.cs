using System;

namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {
            Data test = new Data();
            test.getData("Object_data");
        }
    }

    public class Animals
    {
        public virtual void Voice()
        {
            Console.WriteLine("叫聲: " + "聲音");
        }
    }

    public class Dog : Animals
    {
        override public void Voice()
        {
            Console.WriteLine("狗 叫聲: " + "汪汪汪");
        }
    }

    public class Cat : Animals
    {
        override public void Voice()
        {
            Console.WriteLine("貓 叫聲: " + "喵喵喵");
        }
    }

}
