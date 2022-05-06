// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello! Let's play a game.");
//Console.WriteLine("I'm going to think of a number between 1 and 100. Take a guess.");
string userGuess = "";

//Intro to the game
for (Console.Write("I'm going to think of a number between 1 and 10. Take a guess.\n\nGuess: ");
    userGuess is not "Goodbye" and not "goodbye"; Console.Write("\nGuess: "))
    {
//Taking the user guess and translating to an integer.
    userGuess = Console.ReadLine();
    //Console.Write("\n");
    int userNumber;
    bool guessIsNumber = Int32.TryParse(userGuess, out userNumber);

//Generating a random number
    Random random = new Random();
    int randomNumber = random.Next(1, 11);

    //Random messages
    string[] rudePhrases = { "stupidhead", "idiot", "nincompoop", "cotton-headeed ninny muggins", "bird brain",
                    "you're really about as sharp as a bowling ball", "you're not the sharpest tool in the shed",
                    "your elevator doesn't go up to the top floor"};
    int randomRudeName = random.Next(rudePhrases.Length);

//If they type something that isn't an integer...
        if (guessIsNumber == false)
            {
            Console.WriteLine("Asshole.");
            break;
            }

//If they type an integer.
        else
            {
             if (userNumber == randomNumber)
                {
                Console.WriteLine("Whoa!! You guessed it right! Nice job!!");
                }
             else if (userNumber != randomNumber && userNumber < 11)
                {
                Console.WriteLine($"The real answer was {randomNumber}, {rudePhrases[randomRudeName]}.");
                }
             else if (userNumber > 10)
                {
                Console.WriteLine($"That's not even in the range, {rudePhrases[randomRudeName]}.");
                }
            //Console.WriteLine($"Your guess was: {userNumber}");
            }
    }