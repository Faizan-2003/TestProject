namespace myProject1
{
    public class Team
    {
        List<Programmer> programmers;
        
        public Team()
        {
            programmers = new List<Programmer>();    
        }
        public void AddProgrammer(Programmer programmer)
        {
            programmers.Add(programmer);
        }
        public void PrintAllProgrammer()
        {
            foreach(var member in programmers)
            {
                Console.WriteLine($"Name: {member.Name}, Specialty: {member.Specialty}");
            }
        }
    }
}
