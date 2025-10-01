//Spencer Solt, 9/30/25, Mastermind
Console.WriteLine("Hello, I have chosen 4 letters between 'a' and 'g' and have arranged them in a particular order. Your job is to guess the letters and put them in the right order.");
string secret = "gbcf";
string? guess;
int guessNumber = 0;
int correctLetters = 0;
do //keeps the game going until the secret is guessed
{
    int wrongPosition = 0;
    correctLetters = 0;
    guessNumber++; //adds the amount of times the secret has been guessed
    Console.WriteLine($"Guess #{guessNumber}: Please guess a sequence of 4 lowercase letters with no repeats.");
    guess = Console.ReadLine(); //gets the users guess
    for (int i = 0; i < 4; i++)
    {
        if (secret.Substring(i, 1) == guess.Substring(i, 1))
            correctLetters++;
        else
        {
            for (int x = 0; x < 4; x++)
                if (secret.Substring(i, 1) == guess.Substring(x, 1))
                    wrongPosition++;
        }
    }
    Console.WriteLine($"- {correctLetters} in the correct position");
    Console.WriteLine($"- {wrongPosition} in the wrong position");
}
while (guess != secret); //condition to keep the game going until the secret is correctly guessed
Console.WriteLine($"You did it! You guessed my secret ({secret}) in {guessNumber} guesses.");