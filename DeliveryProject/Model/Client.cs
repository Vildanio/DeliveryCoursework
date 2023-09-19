namespace DeliveryProject
{
    public record Client
    {
        public string Name { get; }

        public string Location { get; }

        public Client(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
}
