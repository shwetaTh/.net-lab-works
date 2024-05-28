using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BaseClass
    {
        public string message;
        public BaseClass(string message) { 
            this.message = message;
        }
        public virtual string Method1()
        {
            return "Ït is a base class method1";
        }
        public virtual string Method2()
        {
            return "Ït is a base class method2";
        }
    }
}
