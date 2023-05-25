namespace The_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();
            int theNumber = random.Next(1, 11);
            int userNumber;
            int attempts =  3;
            for (int i = 1; i <= 3; i++) {


                Console.WriteLine("Welcome to our guessing game \nit will be hard \nyou may want to cry \nbut don't worry you'll get it eventually");



                Console.WriteLine("Please guess a number between 1 and 10");
                userNumber = Convert.ToInt32(Console.ReadLine());



                if (userNumber == theNumber)
                {
                    Console.WriteLine("Congrats you are not an idiot that is correct!!!!!");
                    break;
                }
                else if (userNumber < 1 || userNumber > 10)
                {
                    Console.WriteLine("The number you have chosen is outside the paramaters of the question \nPlease make sure it is a digit between 1 and 10");

                }

                else if  (i >= 3)
                {
                    Console.WriteLine("You're out of tries oops");
                    

                } else if (userNumber != theNumber) { Console.WriteLine($"You're an idiot of course it's not {userNumber}. \nYou are {Math.Abs(theNumber - userNumber)} away from the correct answer. \n\nPlease try again\n\n"); }
            }








        }
    }
}