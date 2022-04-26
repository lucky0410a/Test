using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface ICleaningCompany
    {
        string clear();
    }

    class ACompany : ICleaningCompany
    {
        public string clear()
        {
            return "A清潔公司: 打掃+拖地";
        }
    }

    class BCompany : ICleaningCompany
    {
        public string clear()
        {
            return "B清潔公司: 吸塵器";
        }
    }

    class Agent
    {
        public void callCleaningCompany()
        {
            ICleaningCompany cleaningCompany = new ACompany();
            System.Console.WriteLine(cleaningCompany.clear());     //顯示：A清潔公司: 打掃+拖地

            cleaningCompany = new BCompany();
            System.Console.WriteLine(cleaningCompany.clear());     //顯示：B清潔公司:吸塵器
        }
    }

    abstract class ABSCleaningCompany
    {
        public abstract string clear();
    }

    class ACompany1 : ABSCleaningCompany
    {
        public override  string clear()
        {
            return "A清潔公司: 打掃+拖地";
        }
    }

    class BCompany1 : ABSCleaningCompany
    {
        public override string clear()
        {
            return "B清潔公司: 吸塵器";
        }
    }

    class ABSAgent
    {
        public void callCleaningCompany()
        {
            ABSCleaningCompany cleaningCompany = new ACompany1();
            System.Console.WriteLine(cleaningCompany.clear());     //顯示：A清潔公司: 打掃+拖地

            cleaningCompany = new BCompany1();
            System.Console.WriteLine(cleaningCompany.clear());     //顯示：B清潔公司:吸塵器
        }
    }

}
