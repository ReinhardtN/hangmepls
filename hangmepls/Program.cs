using System;

namespace hangmepls
{
    class Program
    {
        static void Main(string[] args)
        {
//foreach loop
bool ord
strings
arrays
if correct / if not /else
Int
Switch arraylista med ord
gissa ord / rätt / fel
loopa gissning
addera ord t listan
rita delar / 10 till
//
        }
    }
    Words words = new Words();
Word pickedWord = words.Pick;
PlayHangman playHangman = new PlayHangman();
playHangman.PickedWord = pickedWord;
    for (int i = 0; i<pickedWord.WordLength; i++)
    {
        Console.Write(" _ ");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    while (playHangman.Result() == GAMERESULT.CONTINUE)
    {
        Console.Write("Pick a letter --> ");
        ConsoleKeyInfo guessedLetter = Console.ReadKey();
        if (playHangman.AddGuessedLetters(guessedLetter.KeyChar))
            playHangman.Play();
    }
    if (playHangman.Result() == GAMERESULT.LOSE)
    {
        Console.WriteLine("You Died.");
        
    }
    else
    {
        
    }
}

    // console.writeline("|O|// \ "); 

    //

    ___
    |
    O
   \|/
    |
   / \
   
 
