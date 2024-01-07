// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to our game ");
Console.WriteLine("here you need to guess nuber between 2 to 11");
bool IsCorrect = false;
Random random = new Random();
int randomIncrease = random.Next(2, 11);
while (!IsCorrect)
{
    Console.WriteLine("write your guess");
    int guess=int.Parse(Console.ReadLine());
    if (guess > randomIncrease)
    {
        Console.WriteLine("it is too high");
    }else if(guess < randomIncrease)
    {
        Console.WriteLine("it is too low");
    }
    else
    {
        Console.WriteLine("correct");
        IsCorrect = true;
    }
}
