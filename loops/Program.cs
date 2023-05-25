namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while (condition)
            // {
            //code
            // }
            /*
                        Console.WriteLine("Enter a number greater than 0");
                        int userNumber = Convert.ToInt32(Console.ReadLine());
                        while (userNumber > 0)
                        {
                            Console.WriteLine(userNumber);
                            userNumber--;
                        }


                        string password = "hi";
                        bool isRunning = true;
                        while (isRunning)
                        {
                            Console.WriteLine("Enter your password");
                            string passwordGuess = (Console.ReadLine());

                            if (passwordGuess.Equals(password))
                            {
                                isRunning = false;
                                Console.WriteLine("Password is correct");

                            }
                            else
                            {
                                Console.WriteLine("Password is incorrect \nPlease try again");
                            }
                        }

                        //  do
                        //  {

                        //  }
                        //  while (condition);

                        string soupTemp;

                        do
                        {
                            Console.WriteLine("please enter the temp");
                            Console.WriteLine("type \"help\" to list options");
                            soupTemp = Console.ReadLine();
                            if (soupTemp.Equals("help"))
                            {

                                Console.WriteLine("Options: too hot, too cold, just right");

                            }

                        } while (soupTemp.Equals("help"));

                        Random random = new Random();
                        int magicNumber = random.Next(1, 5);         //Next() Returns a positive random integer within the default range - 2,147,483,648 to 2,147,483, 647.
                        int usersNumber;                         //Next(int)   Returns a positive random integer that is less than the specified maximum value.
                                                                 //Next(int, int)  Returns a positive random integer within the specified minimum and maximum range(includes min and excludes max).
                                                                 //NextDouble()    Generates random floating - point number that is greater than or equal to 0.0 and less than 1.0.
                                                                 //NextByte()  Fills the specified array with the random bytes.
                        do
                        {
                            Console.WriteLine("Guess the number: ");
                            usersNumber = Convert.ToInt32(Console.ReadLine());
                            if (usersNumber == magicNumber)
                            {
                                Console.WriteLine("Correct");

                            }
                            else Console.WriteLine(magicNumber);

                        } while (usersNumber != magicNumber);

                        //  while(true){
                        //     Console.WriteLine("infinite loop!!");

                        //  }



                        int userPin = 1234;
                        bool isTrue = true;

                        while (isTrue)
                        {

                            Console.WriteLine("Please enter your pin");
                            int userPinGuess = Convert.ToInt32(Console.ReadLine());

                            if (userPin == userPinGuess)
                            {
                                Console.WriteLine("Correct you can now withdraw money");
                                isTrue = false;
                            }
                            else { Console.WriteLine("Please try again"); }
                        }

                        */


            /*

            Console.WriteLine("please enter a number bewtween 1 and 10");
            int useInt = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int n = 0;
            int x = 0;

            while (useInt > 0)
            {
                n = useInt--;
                x = n + useInt;                
                sum = sum + x;
                useInt--;
            }
            Console.WriteLine(sum);

            */


            bool isntWroing = true;
            int sum = 0;
            while (isntWroing)
            {
                Console.WriteLine("you will enter two numbers, make sure the first is higher than the second\nplease enter your first number");
                int useInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter your second number");
                int useInt2 = Convert.ToInt32(Console.ReadLine());
                if (useInt > useInt2)
                {
                    while (useInt >= useInt2)
                    {
                        sum += useInt--;
                    }
                    Console.WriteLine(sum);
                    isntWroing = false;
                } else { Console.WriteLine("Retry and be sure that the first number is bigger than the second"); }
            }


            //for loops

            //   for   (initial stattement; conditional; incrementer)
            //      {   // code

            //      }

            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine(i);
            }   // outputs 1-8


            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j} \t");
                }
                Console.WriteLine();

            }
            /*1       2       3       4       5       6       7       8       9       10
                2       4       6       8       10      12      14      16      18      20
                3       6       9       12      15      18      21      24      27      30
                4       8       12      16      20      24      28      32      36      40
                5       10      15      20      25      30      35      40      45      50
                6       12      18      24      30      36      42      48      54      60
                7       14      21      28      35      42      49      56      63      70
                8       16      24      32      40      48      56      64      72      80
                9       18      27      36      45      54      63      72      81      90
               10      20      30      40      50      60      70      80      90      100 */
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("pick a number between 1 and 50");
            int userRows = Convert.ToInt32(Console.ReadLine());

            for (int i = userRows; userRows > 0; userRows--)
            {
                Console.Write("\n*\n**\t");
            }

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }                              
            }

            
            int summ = 0; 
            int indivNumber;
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                indivNumber = number % 10;
                summ += indivNumber;
                number = number / 10;
            }
            Console.Write("Sum is = " + summ);



            //int summm = 0;
            //for (int uN = 1; uN >= 0; uN++)
            //{
            //    summ += uN;
            //    uN = uN / 10;
            //}



        }


    }
}