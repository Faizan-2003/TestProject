namespace myProject1
{
    public class Programmer
    {
        public string Name;
        public Specialty Specialty;
        public Programmer(string name, Specialty specialty)
        {
            this.Name = name;
            this.Specialty = specialty;
        }
        public Programmer(string name) : this(name, Specialty.Unknown)
        {
            this.Name = name;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Specialty: {Specialty}");
        }

    }
    
}
