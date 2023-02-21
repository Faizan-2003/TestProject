namespace myProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program myProgram= new Program();
            myProgram.Start();
        }
        void Start()
        {
            Programmer programmer1= new Programmer("Peter", Specialty.Csharp);
            Programmer programmer2= new Programmer("Kevin", Specialty.Java);
            Programmer programmer3= new Programmer("John", Specialty.Csharp);
            Programmer programmer4= new Programmer("Susan", Specialty.Java);
            Programmer programmer5= new Programmer("Emma");

            Team team = new Team(); 

            team.AddProgrammer(programmer1);
            team.AddProgrammer(programmer2);
            team.AddProgrammer(programmer3);
            team.AddProgrammer(programmer4);
            team.AddProgrammer(programmer5);

            team.PrintAllProgrammer();
        }
    }
}