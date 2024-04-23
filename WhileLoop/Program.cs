
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");

    int userNumber = Int32.Parse(Console.ReadLine() );

    if ( userNumber == cpuRandom)
    {
        Console.WriteLine("Congratiulations, you won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oos. Try again.");
    }
}

Console.WriteLine("have a nice day!");