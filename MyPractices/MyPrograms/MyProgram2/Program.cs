
decimal firstNumberInput;
decimal secondNumberInput;
decimal total; //= 0;
int operationInput;

Console.WriteLine("Welcome to my Calcutor Program!");

try
{
    Console.WriteLine("Please enter the first number:");
    //var firstNumberInput = decimal.Parse(Console.ReadLine());
    decimal.TryParse(Console.ReadLine(), out firstNumberInput);
    Console.WriteLine("Please enter the second number:");
    //var secondNumberInput = Convert.ToDecimal( Console.ReadLine());
    decimal.TryParse(Console.ReadLine(), out secondNumberInput);

    Console.WriteLine("Please enter the operation you want to perform:");
    Console.WriteLine("1. Add, 2. Sustract, 3. Multiplication 4. Division 5. Exit");

    //var operationInput = Console.ReadLine();
    int.TryParse(Console.ReadLine(), out operationInput);

    //decimal firstNumberConverted = decimal.Parse(firstNumberInput);
    //decimal secondNumberConverted = decimal.Parse(secondNumberInput);

    //decimal total = firstNumberConverted + secondNumberConverted;
    ////decimal total = firstNumberInput + secondNumberInput;

    //logics operators
    // == equal to, != not equal to, > greater than, < less than, >= greater than or equal to, <= less than or equal to 

    //if (operationInput == 1)
    //{
    //    total = firstNumberInput + secondNumberInput; 
    //}
    //if(operationInput == 2)
    //{
    //    total = firstNumberInput - secondNumberInput;
    //}
    //if(operationInput == 3)
    //{
    //    total = firstNumberInput * secondNumberInput;
    //}
    //if(operationInput == 4)
    //{
    //    total = firstNumberInput / secondNumberInput;
    //}
    //if(operationInput == 5)
    //{
    //    Console.WriteLine("Exiting the program. Goodbye!");
    //    return;
    //}
    //var test = 0;
    //if (operationInput == 1)
    //{
    //    var test = 0;
    //    test = 1;
    //    total = firstNumberInput + secondNumberInput;
    //}
    //else
    //{  
    //    var test = 0;
    //    if (operationInput == 2)
    //    {

    //        test = 1;

    //        total = firstNumberInput - secondNumberInput;
    //    }
    //    else
    //    {
    //        if (operationInput == 3)
    //        {
    //            test = 1;

    //            total = firstNumberInput * secondNumberInput;
    //        }
    //        else
    //        {
    //            if (operationInput == 4)
    //            {
    //                total = firstNumberInput / secondNumberInput;
    //            }
    //            else
    //            {
    //                if (operationInput == 5)
    //                {
    //                    test = 18;

    //                    Console.WriteLine("Exiting the program. Goodbye!");
    //                    return;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Invalid operation selected. Please try again.");
    //                    return;
    //                }
    //            }
    //        }
    //    }
    //}

    //if (operationInput == 1)
    //{
    //    total = firstNumberInput + secondNumberInput;
    //}
    //else if (operationInput == 2)
    //{
    //    total = firstNumberInput - secondNumberInput;
    //}
    //else if (operationInput == 3)
    //{
    //    total = firstNumberInput * secondNumberInput;
    //}
    //else if (operationInput == 4)
    //{
    //    total = firstNumberInput / secondNumberInput;
    //}
    //else if (operationInput == 5)
    //{
    //    Console.WriteLine("Exiting the program. Goodbye!");
    //    return;
    //}
    //else
    //{
    //    Console.WriteLine("Invalid operation selected. Please try again.");
    //    return;
    //}

    switch (operationInput)
    {
        case 1:
            {
                total = firstNumberInput + secondNumberInput;
                break;
            }
        case 2:
            total = firstNumberInput - secondNumberInput;
            break;
        case 3:
            total = firstNumberInput * secondNumberInput;
            break;
        case 4:
            total = firstNumberInput / secondNumberInput;
            break;
        case 5:
            Console.WriteLine("Exiting the program. Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid operation selected. Please try again.");
            return;
    }

    Console.WriteLine($"The result of the operation is: {total}");

}
catch (Exception ex)
{
    Console.WriteLine("An error occurred while performing the calculation. Please make sure to enter valid numbers and select a valid operation.");
    Console.WriteLine($"Error details: {ex.Message}");
    //throw;
}

Console.ReadKey();


