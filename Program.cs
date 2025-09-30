//Spencer Solt, 9/30/25, Mastermind
Console.WriteLine("Hello, I have chosen 4 letters between 'a' and 'g' and have arranged them in a particular order. Your job is to guess the letters and put them in the right order.");
string chosenWord = "gbcf";
string guess;
do
{
    guess = Console.ReadLine();
}
while (guess != chosenWord);
Console.WriteLine("You did it!");