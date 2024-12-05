

// Random random = new();
// int secretNumber = random.Next(10, 15);

// Console.WriteLine("=====Guess Any Number======");
// int guesnumber = int.Parse(Console.ReadLine()!);



//  string result = (guesnumber != secretNumber) ? "You Guess Wrong Boboyi !! " : "You Guess Right Nigga Gbayii";
//  Console.ForegroundColor = ConsoleColor.Green;
// if (guesnumber != secretNumber)
// {
//     Console.WriteLine("You Guess Wrong !!");
//     Console.ForegroundColor = ConsoleColor.Red;
    
// }

// else 
// {
//     Console.WriteLine("You Guess Right");
//     Console.ForegroundColor = ConsoleColor.Green;
    
// }

// Console.WriteLine(guesnumber);
// Console.Write($"The Secret numer is : {secretNumber}  e shock you? ");




// Methods are a way to organize code into reusable blocks.


// Console.ForegroundColor = ConsoleColor.Cyan;
// Console.WriteLine("Welcome to our Simple Calculator App");
// Console.BackgroundColor = ConsoleColor.White;
// Console.ResetColor();
// Console.WriteLine("Choose An Option");
// Console.WriteLine("Enter 1 to Multiply\nEnter 2 to Add\nEnter 3 to Subtract\nEnter 4 to Divide\nEnter 5 for Modulo");
// bool userInput = int.TryParse(Console.ReadLine(), out int value);


// if (userInput == false)
// {
//     Console.WriteLine("Wetin be this!!");
//     Console.WriteLine("Gimme number boboyi");
// }
// else if (value > 5 || value < 1)
// {
//     Console.WriteLine("Read the instruction");
// }
// else
// {
//     Console.WriteLine("Your head dey there");
// }



// try
// {


// switch (value)
// {
//     case 1:
//         int input = Prompt("Enter Your First Number: ");
//         int input2 = Prompt("Enter Your Second Number: ");
//         float multiplyResult = Multiply(input, input2);
//         Console.WriteLine("The result is {0}", multiplyResult);
//         break;
//     case 2:
//       int add1 = Prompt("Enter Your First Number: ");
//         int add12 = Prompt("Enter Your Second Number: ");
//         int addResult = Add(add1, add12);
//         Console.WriteLine("The result is {0}", addResult);
//         break;
//     case 3:
//        int subtract1 = Prompt("Enter Your First Number: ");
//         int subtract2 = Prompt("Enter Your Second Number: ");
//         int subtractResult = Subtract(subtract1, subtract2);
//         Console.WriteLine("The result is {0}", subtractResult);
//         break;
//     case 4:
//         int nominator = Prompt("Enter Your Numerator: ");
//         int denominator = Prompt("Enter your Denominator: ");
//         decimal divideNums = Divide(nominator, denominator);
//         Console.WriteLine(divideNums);
//         break;
//     case 5:
//         int modulo = Prompt("Enter Your First Number: ");
//         int moduloSecondNum = Prompt("Enter your Second Number: ");
//         int remainder = Modulo(modulo, moduloSecondNum);
//         Console.WriteLine(remainder);
//         break;

//     default:
//         Console.WriteLine("Not Found");
//         break;{
            
//         }
// }
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error Message: ", ex.Message);
// }





// // Multiplication  --> Float
// float Multiply(int a, int b)
// {
//     return a * b;
// }

// // Addition   --> int
// int Add(int a, int b)
// {
//     return a + b;
// }
// // Subtraction   --> int
// int Subtract(int a, int b)
// {
//     return a - b;
// }
// // Division  --> decimal
// decimal Divide(int a, int b)
// {
//     return a / b;
// }
// // Modulo  --> int
// int Modulo(int a, int b)
// {
//     return a % b;
// }

// int Prompt(string text)
// {
//     Console.Write(text);
//     bool value = int.TryParse(Console.ReadLine(), out int result);
//     while (value == false)
//     {
//         if (value == false)
//         {
//             Console.Write("Enter a Valid Number: ");
//         }
//         value = int.TryParse(Console.ReadLine(), out  result);

//     }

//     return result;
// }








