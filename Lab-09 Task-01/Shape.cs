using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Task_01
{
    internal class Shape
    {
        public string name;

        public virtual string whoAmI()
        {
            string info = "My name is " + name + ".";
            return info;
        }
    }
}
