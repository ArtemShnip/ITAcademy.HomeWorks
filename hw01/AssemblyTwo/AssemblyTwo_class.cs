using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class AssemblyTwo_class
    {
        static void Main(string[] args)
        {
            Employee test = new Employee();
            test.public1 = 1;

        }
        class Developer : Employee
        {
            void ITest_class()
            {
                Developer employee = new Developer();
                employee.protected1 = 2;
                employee.protectedInternal1 = "4";
            }
        }
    }
}
