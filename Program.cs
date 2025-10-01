//Spencer Solt, 9/30/25, Mastermind
Console.WriteLine("Hello, I have chosen 4 letters between 'a' and 'g' and have arranged them in a particular order. Your job is to guess the letters and put them in the right order.");
string secret = "gbcf";
string? guess;
int guessNumber = 0;
do
{
    guessNumber++;
    Console.WriteLine($"Guess #{guessNumber}: Please guess a sequence of 4 lowercase letters with no repeats.");
    guess = Console.ReadLine();
}
while (guess != secret);
Console.WriteLine("You did it!");