using System;

namespace AssemblyOne
{
    public class AssemblyOne_class
    {
        static void Main(string[] args)
        {
            Developer employee = new Developer();
            employee.public1 = 2;
            employee.internal1 = "4";
            employee.protectedInternal1 = "5";
        }
        class Developer : Employee
        {
            void ITest_class()
            {
                Developer employee = new Developer();
                employee.protected1 = 3;
                employee.privateProtected1 = 6;
            }
        }
    }
}
