using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class Employee
    {
        public const string CompanyNamePublic = "IT-Academy";
        protected const string CompanyNameProtected = "IT-Academy";
        internal const string CompanyNameInternal = "IT-Academy";
        protected internal const string CompanyNameProtectedInternal = "IT-Academy";
        private const string CompanyNamePrivate = "IT-Academy";
        private protected const string CompanyNamePrivateProtected = "IT-Academy";

        public static void PrintProtectedMember()
        {
            Console.WriteLine(CompanyNameProtected);
        }

        public static void PrintPrivateMember()
        {
            Console.WriteLine(CompanyNamePrivate);
        }

        public static void PrintPrivateProtected()
        {
            Console.WriteLine(CompanyNamePrivateProtected);
        }
    }

    public class Developer : Employee
    {

    }
}
