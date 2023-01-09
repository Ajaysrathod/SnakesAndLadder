namespace SnakesAndLadder
{
    internal class Program
    {
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Program");
            //UC01 the Player Position
            int position = 0;
            int count = 0;
            Console.WriteLine("Single Player Starting Position" + position);
            // repeating until player gets wining position
            while (position < 100)
            {
                //UC02 Roll the dice to get a number
                Random random= new Random();
                int die = random.Next(1, 7);
                //UC03 Check for no play,snake,ladder
                Random random1= new Random();
                int option = random1.Next(0, 3);
                if (option == NoPlay )
                {
                    Console.WriteLine("Player is at same position (noPlay)");
                }
                else if (option == Ladder )
                {
                    position = position + die;
                    //UC05 staying at previous position till the player get exact number
                    if (position > 100)
                    {
                        position = position - die;
                    } 
                    else if (position == 100)
                    {
                        Console.WriteLine("Player has won");
                    }
                    Console.WriteLine("(Ladder) After getting the ladder player position is " + position);
                    count++;
                    
                }
                else
                {
                    position = position - die;
                    if (position < 0)
                    {
                        position = 0;
                    }
                    Console.WriteLine("(Snake) After snake bite player position is " + position);
                    count++;
                }
                Console.WriteLine("Die count to win the game is " + count);
            }
        }
    }
}