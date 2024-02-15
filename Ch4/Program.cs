internal class Program
{
    private static void Main()
    {
        /*
        Creating a simple number asking program for Chapter 4
        This code must at least exicute once, knowing that I feel like a do while is an approprate way to go
         */

        int counter = 0;
        int shift = 0;
        int input = 0;
        string userInput;


        Console.Write("Wanna play a game? Enter a number from 1 to 9, I will repeat this number and keep a count. After you get bored, press 0 and I will exit and show what the count would be if a shifted left in binary!\n \n");

        do
        {

            Console.Write("Enter your number: ");

            userInput = Console.ReadLine();
            input = Int32.Parse(userInput);

            counter++; // Increase counter here. Even if they put 0 immediately, they still have entered an input once.

            if (input == 3 || input == 5 || input == 7)
            {
                Console.WriteLine($"{userInput}!\n");
            }
            else if(input == 4 || input == 6)
            {
                Console.WriteLine($"It's a {input}!\n");
            }
            else if(input == 1 || input == 2 || input == 8 || input == 9)
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("You have entered 0, goodbye!");
            }


        } while (input != 0);

        Console.WriteLine($"The total count is: {counter}");
        shift = counter << 1;

        Console.WriteLine($"The binary shift of the counter is: {shift}");
    }
}