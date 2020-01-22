using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Employee
    {
        public const string hw = "HW_08";
        public int public1;
        protected int protected1;
        internal string internal1;
        protected internal string protectedInternal1;
        private int private1;
        private protected int privateProtected1;
    }
    public class Developer : Employee
    {
        public static void D()
        {
            Developer test = new Developer();
            test.public1 = 1;
            test.protected1 = 2;
            test.internal1 = "3";
            test.protectedInternal1 = "4";
            test.privateProtected1 = 5;
        }
    }
}
