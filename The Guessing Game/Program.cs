namespace The_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our guessing game \n it will be hard \n you may want to cry \n but don't worry you'll get it eventually");

            int theNumber = 7;

            Console.WriteLine("Please guess a number between 1 and 10");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber == theNumber)
            {
                Console.WriteLine("Congrats you are not an idiot that is correct!!!!!");

            } else if (userNumber != theNumber) { Console.WriteLine($"You're an idiot of course it's not {userNumber} please try again"); }

            else if (userNumber < 1 || userNumber >10) { 
                Console.WriteLine("the number you have chosen is outside the paramaters of the question \n Please make sure it is a number between 1 and 10"); 
            } else { Console.WriteLine("Don't write the number out you idiot, use the digit"); }







        }
    }
}