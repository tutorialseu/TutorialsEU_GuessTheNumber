public class Program
{
    // Initialise the secretNumber to zero
    int secretNumber = 0;
    // Initialise the guess to zero
    int guess = 0;
    // Initialize the tries to zero
    int tries = 0;
    static void Main()
    {
        //Set the console to white and text to black
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;

        // Initilaise an instance of the Random class
        Random random = new Random();

        //Create an instance reference of our Program class
        Program program = new Program();
        // Generate a random (secret) number between 1 and 10
        program.secretNumber = random.Next(1, 10);

        // Prompt the game to the user
        Console.WriteLine("I am thinking of a number between 1-10. Can you guess what it is?");

        // Call the instanced Guess method
        program.Guess();
    }
    void Guess()
    {
        guess = Convert.ToInt32(Console.ReadLine());
        tries++;

        if (guess < secretNumber)
        {
            // If the player's guess is less than the secret number
            // Give the player a hint and call guess again
            Console.WriteLine("No, the number I am thinking of is higher than " + guess + ". Can you guess what it is?");
            Guess();
        }
        else if (guess > secretNumber)
        {
            // If the player's guess number is greater than the secret number
            // Give the player a hint and call guess again
            Console.WriteLine("No, the number I am thinking of is lower than " + guess + ". Can you guess what it is?");
            Guess();
        }
        else
        {
            // Any case other than the previous two, is a match and therefore, a win condition. So call Win method with the current guess attached.
            Win();
        }
    }
    void Win()
    {
        Console.WriteLine("Well done! Your guess of " + guess + " matched with the secret number of " + secretNumber + "! Only took you " + tries + " tries!");
    }
}