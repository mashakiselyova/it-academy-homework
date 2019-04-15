using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Public member in a different assembly: " + Employee.CompanyNamePublic);
            Console.Write("Protected member from base class in another assembly: ");
            Employee.PrintProtectedMember();
            Console.Write("Protected member from derived class in another assembly: ");
            Developer.PrintProtectedMember();
            AnotherDeveloper.PrintProtectedInternal();


            Console.Read();
        }
    }

    public class AnotherDeveloper : Employee
    {
        public static void PrintProtectedInternal()
        {
            Console.WriteLine("Protected Internal member in derived class in another assembly: " + CompanyNameProtectedInternal);
        }
    }
}
