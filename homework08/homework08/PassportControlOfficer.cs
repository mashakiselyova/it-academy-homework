using System;

namespace homework08
{
    class PassportControlOfficer
    {
        public bool PassportCheck(Passenger passenger)
        {
            if (passenger.Visa)
            {
                Console.WriteLine($"Welcome on board!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, but we cannot let you on board.");
                return false;
            }
        }
    }
}
