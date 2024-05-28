using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DerivedClass:BaseClass
    {
        public DerivedClass(string message): base(message) { 
            
        }
        public override string Method1()
        {
            return "It is derived method1\n message:" + message;
        }
    }
}
