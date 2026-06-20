
//decimal firstNumberInput;
//decimal secondNumberInput;
//decimal[] typedNumbers = new decimal [2];
//decimal[] typedNumbers;
//List<decimal> typedNumbers = new List<decimal>();
List<decimal> typedNumbers ;
//typedNumbers = new decimal[2];
//typedNumbers = new decimal[1];
bool running = true;
bool notRunning = false;
//typedNumbers[1] = 15;
//typedNumbers[0] = 20;
//typedNumbers[2] = 20;

decimal total = 0;
int operationInput;
int wantToContinueInput = 1;

////declaration 
//int whatever;
////instantiation
//whatever = new int();
////initialization
//whatever = 0;
int whatever = 0;

Console.WriteLine("Welcome to my Calcutor Program!");

try
{

    while (running == true)
    // while (running)
    //while (notRunning == false)
    //while (!notRunning)
    {
         
        typedNumbers = new List<decimal>();

        Console.WriteLine("Please enter the operation you want to perform:");

        Console.WriteLine("1. Add, 2. Sustract, 3. Multiplication 4. Division 5. Exit");
        int.TryParse(Console.ReadLine(), out operationInput);

        //Console.WriteLine("Open db connection");

        Console.WriteLine("Please enter the first number:");

        //decimal.TryParse(Console.ReadLine(), out decimal captured);

        //typedNumbers.Add(0);
        //typedNumbers[0] = captured;

        //typedNumbers.Add(captured);
        typedNumbers.Add(decimal.Parse(Console.ReadLine()));


        //Console.WriteLine("Please enter the second number:"); 
        //decimal.TryParse(Console.ReadLine(), out typedNumbers[1]);

        //Console.WriteLine("Do you want to continue adding more numbers? 1. Yes, 2. No");
        //int.TryParse(Console.ReadLine(), out wantToContinueInput);

        //wantToContinueInput = 1;
        //int counter = 2; // Start from the third number
        //while (wantToContinueInput == 1)
        //{
        //    Console.WriteLine("Please enter the next number:");
        //    decimal nextNumberInput;
        //    decimal.TryParse(Console.ReadLine(), out nextNumberInput);

        //    counter++;
        //    //counter = counter + 1;
        //    //++counter;
        //    //counter += 1;

        //    var tempTypedNumerbs = typedNumbers;

        //    typedNumbers = new decimal[counter];

        //    for (int i = 0; i < tempTypedNumerbs.Length; i = i + 1)
        //    {
        //        typedNumbers[i] = tempTypedNumerbs[i];
        //    }

        //    typedNumbers[counter-1] = nextNumberInput; // Add the new number to the array

        //    Console.WriteLine("Do you want to continue adding more numbers? 1. Yes, 2. No");
        //    int.TryParse(Console.ReadLine(), out wantToContinueInput);

        //}


        //  int counter = 1; // Start from the third number
        do
        {
            Console.WriteLine("Please enter the next number:");
            //decimal nextNumberInput;
            //decimal.TryParse(Console.ReadLine(), out nextNumberInput);

            typedNumbers.Add(decimal.Parse(Console.ReadLine()));
            //  counter++;
            //counter = counter + 1;
            //++counter;
            //counter += 1;

            //var tempTypedNumerbs = typedNumbers;

            ////typedNumbers = new decimal[counter];
            //typedNumbers = new decimal[typedNumbers.Length + 1];

            //for (int i = 0; i < tempTypedNumerbs.Length; i = i + 1)
            //{
            //    typedNumbers[i] = tempTypedNumerbs[i];
            //}

            ////  typedNumbers[counter - 1] = nextNumberInput; // Add the new number to the array
            //typedNumbers[typedNumbers.Length] = nextNumberInput; // Add the new number to the array

            //typedNumbers.Append(nextNumberInput);

            Console.WriteLine("Do you want to continue adding more numbers? 1. Yes, 2. No");
            int.TryParse(Console.ReadLine(), out wantToContinueInput);
        }
        while (wantToContinueInput == 1);


        switch (operationInput)
        {
            case 1:
                {
                    //for (int i = 0; i < typedNumbers.Length; i++)
                    //for (int i = 0; i < typedNumbers.Count; i++)
                    //{
                    //    total = total + typedNumbers[i];
                    //    //total +=  typedNumbers[i];
                    //}
                    foreach (var typedNumber in typedNumbers)
                    {
                        total += typedNumber;
                    }

                    break;
                }
            case 2:
                foreach (var typedNumber in typedNumbers)
                {
                    total -= typedNumber;
                }
                break;
            case 3:
                total = 1;
                foreach (var typedNumber in typedNumbers)
                {
                    total *= typedNumber;
                }
                break;
            case 4:
                total = typedNumbers[0];
                for (int i = 1; i < typedNumbers.Count; i++)
                {
                    total = total / typedNumbers[i];
                }
                break;
            case 5:
                Console.WriteLine("Exiting the program. Goodbye!");
                running = false;
                return;
            default:
                Console.WriteLine("Invalid operation selected. Please try again.");
                return;
        }

        Console.WriteLine($"The result of the operation is: {total}");
    }

}

catch (Exception ex)
{
    Console.WriteLine("An error occurred while performing the calculation. Please make sure to enter valid numbers and select a valid operation.");
    Console.WriteLine($"Error details: {ex.Message}");
}
finally
{
    Console.WriteLine("Closing db connection");
}

Console.ReadKey();


