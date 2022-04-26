using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Data
    {
        string data = "Class_data";

        public void getData(string data)          // data="Object_data"
        {
            System.Console.WriteLine(data);       //顯示：Object_data
            System.Console.WriteLine(this.data);  //顯示：Class_data
        }
    }
}
