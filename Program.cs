// Edwin Storz - 2022-2023
int answer = 0;
int guess = 0;

Random number = new Random();

answer = number.Next(1, 11);
//For Loop
for (int i = 1; i <= 6; i++)
{

    if (i > 5)
    {
        Console.WriteLine("Out of attempts. Get better.  The answer was {0}", answer);
        Console.WriteLine("https://github.com/SearchIP");
        break;
    }

    Console.Write("Attempt: {0}: ", i);
    guess = Convert.ToInt32(Console.ReadLine());
    // Goed Antwoord.
    if (guess == answer)
    {
        Console.WriteLine("{0} is the correct number gg.", answer);
        Console.WriteLine("You Tried {0} times in order to get the right number", i);
        break;
    }
    // Verkeerd antwoord
    else if (answer < guess)
    {
        Console.WriteLine("The Number I have in mind is lower than {0}.", guess);
    }
    else if (answer > guess)
    {
        Console.WriteLine("The Number I have in mind is higher than {0}.", guess);
    }
}//end for loop


Console.ReadKey();