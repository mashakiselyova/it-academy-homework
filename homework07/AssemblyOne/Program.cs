using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Public member in the same assembly: " + Employee.CompanyNamePublic);
            Console.Write("Protected member from base class in the same assembly: ");
            Employee.PrintProtectedMember();
            Console.Write("Protected member from derived class in the same : ");
            Developer.PrintProtectedMember();
            Console.WriteLine("Internal member from base class: " + Employee.CompanyNameInternal);
            Console.WriteLine("Internal member from derived class: " + Developer.CompanyNameInternal);
            Console.WriteLine("Protected Internal member from base class in the same assembly: " + Employee.CompanyNameProtectedInternal);
            Console.WriteLine("Protected Internal member from derived class in the same assembly: " + Developer.CompanyNameProtectedInternal);
            Console.Write("Private member: ");
            Employee.PrintPrivateMember();
            Console.Write("Private Protected member from base class: ");
            Employee.PrintPrivateProtected();
            Console.Write("Private Protected member from derived class: ");
            Developer.PrintPrivateProtected();

            Console.Read();
        }
    }
}
