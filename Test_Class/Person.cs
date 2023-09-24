namespace Test_Class
{
    public class Person
    {
        public string Name;
        public string SurName;
        public void Intruduce(string name, string surname)
        {
            Console.WriteLine($"Hi {name} {surname}, i am {Name} {SurName}");
        }
        public Person()
        {
            
        }
        public Person(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }
    }
}