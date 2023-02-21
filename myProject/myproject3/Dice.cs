namespace myproject3
{
    public class Dice
    {
        public int value;
        Random random = new Random();   
    
    public Dice(Random random)
        {
            this.random = random;
        }
        public void Throw()
        {
            value = random.Next(1, 7);
        }
        public void DisplayValue()
        {
            Console.Write($"{value} ");
        }
    
    }
}
