namespace MyApp
{
    class Citizen : IBuyer
    {
        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Birthday = birthday;
            Id = id;
            Age = age;
            
        }

        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public int Food { get ; set ; } = 0;

        public void BuyFood()
        {
            Food+=10;

        }
    }
}