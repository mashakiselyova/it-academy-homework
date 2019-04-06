using System;

namespace homework08
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger;
            Console.WriteLine("Welcome to the IT-Academy airport. Please, tell your name.");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();             
            Console.WriteLine("Do you have baggage? (Enter Yes or No)");
            string check = Console.ReadLine();
            if (string.Equals(check, "Yes") || string.Equals(check, "yes"))
            {
                bool baggage = true;
                passenger = new Passenger(firstName, lastName, baggage);
            }
            else
                passenger = new Passenger(firstName, lastName);
            Console.WriteLine("Here is your boarding pass. Please, procede to the security check");
            Console.WriteLine();
            Console.WriteLine("Do you have any forbidden things with you? (Enter Yes or No)");
            check = Console.ReadLine();
            passenger.ForbiddenThings = false;
            if (string.Equals(check, "Yes") || string.Equals(check, "yes"))
                passenger.ForbiddenThings = true;
            var securityOfficer = new SecurityOfficer();
            if (!securityOfficer.SecurityCheck(passenger))
                return;
            Console.WriteLine("Do you have visa?");
            check = Console.ReadLine();
            passenger.Visa = false;
            if (string.Equals(check, "Yes") || string.Equals(check, "yes"))
                passenger.Visa = true;
            var passportControlOfficer = new PassportControlOfficer();
            passportControlOfficer.PassportCheck(passenger);
            Console.Read();
        }
    }
}
