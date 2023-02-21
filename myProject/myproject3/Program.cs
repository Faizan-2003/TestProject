namespace myproject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            PlayYahtzee(yahtzeeGame);
        }
        void PlayYahtzee(YahtzeeGame game)
        {
            int numberOFattempts = 0;
            do
            {
                game.Throw();
                game.DisplayValues();
                numberOFattempts++;

            }while(!game.Yahtzee());

            Console.WriteLine($"Number of attempts (for Yahtzee): {numberOFattempts}");
        }
    }
}