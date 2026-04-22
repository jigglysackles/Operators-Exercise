namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Thought Exercise:
            // What is the value of k in the following code?:
            // var is implicit type inferrence (more on this later)
            // var i = 3;
            // var j = 4;
            // var k = ++i * j++;
            // Console.WriteLine(k); // ouputs ?
            // My Answer:  The value of var k in the above exercise will be 16 because 'i' is incremented before the function and 'j' is incremented after the function.

            Console.Clear();
            Console.WriteLine("Hello and welcome peasant! Need some help with basic math? I gotchu boo.");
            Console.WriteLine("Whatchu got? (A - Add, S - Subtract, M - Multiply, D - Divide, R - Remainder)");
            Console.WriteLine("Not so secret option: RADIUS");

            string? menuSelect;
            char userSelect;

            do
            {
                menuSelect = Console.ReadLine().ToLower();
                if (menuSelect == "radius")
                {
                    Console.Clear();
                    Console.WriteLine("\nI'm going to assume some competence now and not check if your input is valid. So do it right.\n");
                    Console.WriteLine($"When the menu comes around again use the character 'q'. Got it?\n");
                    Console.WriteLine("The program is going to tell you you chose poorly now but just ignore it. It doesn't know anything anyways.\n");
                    Console.WriteLine("If you understand hit enter now.");
                    Console.ReadLine();
                    Console.Clear();
                }
                if ((!char.TryParse(menuSelect, out userSelect) || userSelect != 'a' && userSelect != 's' &&
                     userSelect != 'm' && userSelect != 'd' && userSelect != 'r'))
                {
                    Console.WriteLine($"You chose poorly!\nYou really need to put in a valid letter for this to go anywhere.");
                }
                
            } while (!char.TryParse(menuSelect, out userSelect) || userSelect != 'a' && userSelect != 's' &&
                     userSelect != 'm' && userSelect != 'd' && userSelect != 'r'&& userSelect != 'q');

            // int userNumberOne; 
            // int userNumberTwo;
            // int dumDumA = 0;
            // int dumDumB = 0;
            switch (userSelect) 
            {
                case 'a':
                    int userNumberOneAdd; 
                    int userNumberTwoAdd;
                    int dumDumA = 0;
                    int dumDumB = 0;
                    bool validUserInputOneAdd = false;
                    bool validUserInputTwoAdd = false;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Please enter your first number: ");
                        string? readResultAddNum1 = Console.ReadLine();
                        if(int.TryParse(readResultAddNum1, out userNumberOneAdd))
                        {
                           break;
                        }
                        
                        dumDumA++;
                        if(dumDumA == 2)
                        {
                            userNumberOneAdd = dumDumA;
                            Console.WriteLine($"...really though? Fine, your first number is now {userNumberOneAdd} Moving on.");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                        
                    }while(!validUserInputOneAdd);
                    
                    
                    do
                    {
                        Console.WriteLine("Please enter your second number: ");
                        string? readResultAddNum2 = Console.ReadLine();
                        if(int.TryParse(readResultAddNum2, out userNumberTwoAdd))
                        {
                            break;
                        }
                        
                        dumDumB++;
                        if(dumDumB > 2)
                        {
                            Console.WriteLine($"\nDUDE...We've been over this! \nYour second number is now {AddNum(dumDumA, dumDumB)} because that's how many times you've failed me.");
                            userNumberTwoAdd = AddNum(dumDumA, dumDumB);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                    }while(!validUserInputTwoAdd);
                    
                    Console.WriteLine($"\nCongrats! You've added {userNumberOneAdd} and {userNumberTwoAdd} which equal {AddNum(userNumberOneAdd,userNumberTwoAdd)}.");
                    Console.WriteLine("Peace oot ya hoser. Hit enter or somethin eh?");
                    Console.ReadLine();
                    
                    return;
                
                
                case 's':
                    int userNumberOneSub; 
                    int userNumberTwoSub;
                    int dumDumASub = 0;
                    int dumDumBSub = 0;
                    bool validUserInputOneSub = false;
                    bool validUserInputTwoSub = false;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Please enter your first number: ");
                        string? readResultSubNum1 = Console.ReadLine();
                        if(int.TryParse(readResultSubNum1, out userNumberOneSub))
                        {
                            break;
                        }
                        
                        dumDumASub++;
                        if(dumDumASub == 2)
                        {
                            userNumberOneSub = dumDumASub;
                            Console.WriteLine($"...really though? Fine, your first number is now {userNumberOneSub}. Moving on...");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                        
                    }while(!validUserInputOneSub);
                    
                    do
                    {
                        Console.WriteLine("Please enter your second number: ");
                        string? readResultSubNum2 = Console.ReadLine();
                        
                        if(int.TryParse(readResultSubNum2, out userNumberTwoSub))
                        {
                            break;
                        }
                        
                        dumDumBSub++;
                        if(dumDumBSub > 2)
                        {
                            Console.WriteLine($"\nDUDE...We've been over this! \nYour second number is now {AddNum(dumDumASub, dumDumBSub)} because that's how many times you've failed me.");
                            userNumberTwoSub = AddNum(dumDumASub, dumDumBSub);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                        
                    }while(!validUserInputTwoSub);
                    
                    Console.WriteLine($"\nCongrats! You've subtracted {userNumberTwoSub} from {userNumberOneSub} which equals {SubtractNum(userNumberOneSub,userNumberTwoSub)}.");
                    Console.WriteLine("Peace oot ya hoser. Hit enter or somethin eh?");
                    Console.ReadLine();

                    return;
                
                case 'm':
                    int userNumberOneMultiply; 
                    int userNumberTwoMultiply;
                    int dumDumAMultiply = 0;
                    int dumDumBMultiply = 0;
                    bool validUserInputOneMultiply = false;
                    bool validUserInputTwoMultiply = false;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Please enter your first number: ");
                        string? readResultMultiplyNum1 = Console.ReadLine();
                        if(int.TryParse(readResultMultiplyNum1, out userNumberOneMultiply))
                        {
                            break;
                        }
                        
                        dumDumAMultiply++;
                        if(dumDumAMultiply == 2)
                        {
                            userNumberOneMultiply = dumDumAMultiply;
                            Console.WriteLine($"\n...really though? Fine, your first number is now {userNumberOneMultiply}. Moving on...\n");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                        
                    }while(!validUserInputOneMultiply);
                    
                    do
                    {
                        Console.WriteLine("Please enter your second number: ");
                        string? readResultMultiplyNum2 = Console.ReadLine();
                        
                        if(int.TryParse(readResultMultiplyNum2, out userNumberTwoMultiply))
                        {
                            break;
                        }
                        
                        dumDumBMultiply++;
                        if(dumDumBMultiply > 2)
                        {
                            Console.WriteLine($"\n\nI hate so much about the things you choose to be. \n\nYour second number is now {AddNum(dumDumAMultiply, dumDumBMultiply)} because that's how many times you've failed me.");
                            userNumberTwoMultiply = AddNum(dumDumAMultiply, dumDumBMultiply);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                        
                    }while(!validUserInputTwoMultiply);
                    
                    Console.WriteLine($"\nCongrats! You've multiplied {userNumberOneMultiply} and {userNumberTwoMultiply} which equals {MultiplyNum(userNumberOneMultiply,userNumberTwoMultiply)}.");
                    Console.WriteLine("Peace oot ya hoser. Hit enter or somethin eh?");
                    Console.ReadLine();
                    
                    return;
                
                case 'd':
                    int userNumberOneDivide; 
                    int userNumberTwoDivide;
                    int dumDumADivide = 0;
                    int dumDumBDivide = 0;
                    bool validUserInputOneDivide = false;
                    bool validUserInputTwoDivide = false;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Please enter your first number: ");
                        string? readResultDivideNum1 = Console.ReadLine();
                        if(int.TryParse(readResultDivideNum1, out userNumberOneDivide))
                        {
                            break;
                        }
                        
                        dumDumADivide++;
                        if(dumDumADivide == 2)
                        {
                            userNumberOneDivide = dumDumADivide;
                            Console.WriteLine($"\n...really though? Fine, your first number is now {userNumberOneDivide}. Moving on...\n");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                        
                    }while(!validUserInputOneDivide);
                    
                    do
                    {
                        Console.WriteLine("Please enter your second number: ");
                        string? readResultDivideNum2 = Console.ReadLine();
                        
                        if(int.TryParse(readResultDivideNum2, out userNumberTwoDivide))
                        {
                            break;
                        }
                        
                        dumDumBDivide++;
                        if(dumDumBDivide > 2)
                        {
                            Console.WriteLine($"\n\nI hate so much about the things you choose to be. \n\nYour second number is now {AddNum(dumDumADivide, dumDumBDivide)} because that's how many times you've failed me.");
                            userNumberTwoDivide = AddNum(dumDumADivide, dumDumBDivide);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                        
                    }while(!validUserInputTwoDivide);
                    
                    Console.WriteLine($"\nCongrats! You've divided {userNumberOneDivide} by {userNumberTwoDivide} which equals {DivideNum(userNumberOneDivide,userNumberTwoDivide)}.");
                    Console.WriteLine("Peace oot ya hoser. Hit enter or somethin eh?");
                    Console.ReadLine();
                    
                    return;
                
                case 'r':
                    int userNumberOneModulus; 
                    int userNumberTwoModulus;
                    int dumDumAModulus = 0;
                    int dumDumBModulus = 0;
                    bool validUserInputOneModulus = false;
                    bool validUserInputTwoModulus = false;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Please enter your first number: ");
                        string? readResultModulusNum1 = Console.ReadLine();
                        if(int.TryParse(readResultModulusNum1, out userNumberOneModulus))
                        {
                            break;
                        }
                        
                        dumDumAModulus++;
                        if(dumDumAModulus == 2)
                        {
                            userNumberOneModulus = dumDumAModulus;
                            Console.WriteLine($"\n...really though? Fine, your first number is now {userNumberOneModulus}. Moving on...\n");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                        
                    }while(!validUserInputOneModulus);
                    
                    do
                    {
                        Console.WriteLine("Please enter your second number: ");
                        string? readResultModulusNum2 = Console.ReadLine();
                        
                        if(int.TryParse(readResultModulusNum2, out userNumberTwoModulus))
                        {
                            break;
                        }
                        
                        dumDumBModulus++;
                        if(dumDumBModulus > 2)
                        {
                            Console.WriteLine($"\n\nWhy must you fail me so often?! \n\nYour second number is now {AddNum(dumDumAModulus, dumDumBModulus)} because that's how many times you've failed me.");
                            userNumberTwoModulus = AddNum(dumDumAModulus, dumDumBModulus);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                        
                    }while(!validUserInputTwoModulus);
                    
                    Console.WriteLine($"\nCongrats! You've divided {userNumberOneModulus} by {userNumberTwoModulus} which gives a remainder of {ModulusNum(userNumberOneModulus,userNumberTwoModulus)}.");
                    Console.WriteLine("Peace oot ya hoser. Hit enter or somethin eh?");
                    Console.ReadLine();
                    
                    return;
                
                 case 'q':
                    int userNumberRadius; 
                    int dumDumRadius = 0;
                    bool validUserInputRadius = false;
                    Console.Clear();
                    Console.WriteLine("\n\nCongrats on finding the not really secret menu!");
                    do
                    {
                        Console.WriteLine("Please enter your radius: ");
                        string? readResultRadius = Console.ReadLine();
                        if(int.TryParse(readResultRadius, out userNumberRadius))
                        {
                           break;
                        }
                        
                        dumDumRadius++;
                        if(dumDumRadius == 2)
                        {
                            userNumberRadius = dumDumRadius;
                            Console.WriteLine($"...really though? Fine, your first number is now {userNumberRadius} Moving on.");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Let's try a valid number this time shall we? /s -_- ");
                        }
                        
                    }while(!validUserInputRadius);
                    

                    
                    Console.WriteLine($"\nAll these squares make a circle...\nAll these squares make a circle...\nAll these squares make a circle...\nAll these squares make a circle...\nAll these squares make a circle...\nAll these squares make a circle...");
                    Console.WriteLine($"The area of the circle with the radius of {userNumberRadius} is {AreaOfCircle(userNumberRadius)}.");
                    
                    Console.WriteLine("Peace oot ya hoser. Hit enter or somethin eh?");
                    Console.ReadLine();
                    
                    return;
                    
            }

        }
        
        public static int AddNum(int num1, int num2) => num1 + num2;
        public static int SubtractNum(int num1, int num2) => num1 - num2;
        public static int MultiplyNum(int num1, int num2) => num1 * num2;
        public static int DivideNum(int num1, int num2) => num1 / num2;
        public static int ModulusNum(int num1, int num2) => num1 % num2;
        public static double AreaOfCircle(double radius) => Math.PI * Math.Pow(radius, 2);
    }
}
