Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11); //0 - 10
    randomSum = myRandomNum + myRandomNum;
    Console.WriteLine($"My random is: {myRandomNum}");                                
}



Console.WriteLine($"random sum total: {randomSum}");
    
