namespace The_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



            for (int i = 0; i < 3; i++) { 


            Console.WriteLine("Welcome to our guessing game \n it will be hard \n you may want to cry \n but don't worry you'll get it eventually");

            int theNumber = 7;

            Console.WriteLine("Please guess a number between 1 and 10");
            int userNumber = Convert.ToInt32(Console.ReadLine());


            if (userNumber == theNumber)
            {
                Console.WriteLine("Congrats you are not an idiot that is correct!!!!!");

            }
            else if (userNumber < 1 || userNumber > 10)
            {
                Console.WriteLine("the number you have chosen is outside the paramaters of the question \nPlease make sure it is a digit between 1 and 10");
       
            }

            else
            {

                Console.WriteLine($"You're an idiot of course it's not {userNumber} please try again");
            }
                Console.WriteLine("you're out of tries oops");
            }










        }
    }
}