Random random = new();
int secretNumber = random.Next(10, 15);

Console.WriteLine("=====Guess Any Number======");
int guesnumber = int.Parse(Console.ReadLine()!);



// string result = (guesnumber != secretNumber) ? "You Guess Wrong Boboyi !! " : "You Guess Right Nigga";
// Console.ForegroundColor = ConsoleColor.Green;
if (guesnumber != secretNumber)
{
    Console.WriteLine("You Guess Wrong !!");
    Console.ForegroundColor = ConsoleColor.Red;
    
}

else 
{
    Console.WriteLine("You Guess Right");
    Console.ForegroundColor = ConsoleColor.Green;
    
}

Console.WriteLine(guesnumber);
Console.Write($"The Secret numer is : {secretNumber}  e shock you? ");
