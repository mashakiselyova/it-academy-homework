namespace homework08
{
    class Passenger
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly bool _baggage;
        public bool ForbiddenThings { get; set; }
        public bool Visa { get; set; }

        public Passenger(string firstName, string lastName)
            : this(firstName, lastName, false)
        {           
        }

        public Passenger(string firstName, string lastName , bool baggage)
        {
            _firstName = firstName;
            _lastName = lastName;
            _baggage = baggage;
        }
    }
}
