using System.Runtime.Versioning;

namespace myproject3
{
    public class YahtzeeGame
    {
        Dice[] dices = new Dice[5];

        public YahtzeeGame()
        {
            Random random = new Random();   
            for (int i = 0; i < dices.Length; i++)
            {
                Dice dice = new Dice(random);
                dices[i] = dice;
            }
        }

        public void Throw()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].Throw();       
            }
        }
        public void DisplayValues()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].DisplayValue();
            }
            Console.WriteLine();
        }
        public bool Yahtzee()
        {
            bool yahtzeeThrown = true;
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[0].value != dices[i].value)
                {
                    yahtzeeThrown = false;
                    break;
                }         
            }
            return yahtzeeThrown;
        }
    }
}
