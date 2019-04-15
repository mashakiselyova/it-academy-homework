using System;

namespace homework08
{
    class SecurityOfficer
    {
        public bool SecurityCheck(Passenger passenger)
        {
            if (!passenger.ForbiddenThings)
            {
                Console.WriteLine("Please, procede to passport control");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, but we cannot let you on board.");
                Console.ReadLine();
                return false;
            }
        }
    }
}
