

List<decimal> typedNumbers = new List<decimal>();

decimal result = 0;
int typedOption = 1;
int wantToContinue = 0;

DisplayHeader();

try
{
    typedOption = Convert.ToInt32(Console.ReadLine());

    if (typedOption == 5)
    {
        Console.WriteLine("Closing the progran");
        return;
    }

    if (typedOption < 1 || typedOption > 5)
    {
        Console.WriteLine("The option is invalid");
        return;
    }

    Console.WriteLine("Please Type the first number");
    typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

    Console.WriteLine("Please Type the second number");
    typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

    while (wantToContinue != 2)
    {
        Console.WriteLine("you want to continue inserting numbers? 1. Yes, 2. No");
        wantToContinue = Convert.ToInt32(Console.ReadLine());
        if (wantToContinue == 1)
        {
            //int quantityElementsInTheArray = typedNumbers.Count + 1;

            Console.WriteLine("Please Type another number");
            typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

        }
    }

    switch (typedOption)
    {
        case 1:
            {
                result = AddList(typedNumbers);
            }
            break;
        case 2:
            result = typedNumbers[0];
            for (int i = 1; i <typedNumbers.Count; i++)
            {
                result -= typedNumbers[i];
            }
            break;
        case 3:
            result = typedNumbers[0];
            for (int i = 1; i < typedNumbers.Count; i++)
            {
                result *= typedNumbers[i];
            }
            break;
        case 4:
            result = typedNumbers[0];
            for (int i = 1; i < typedNumbers.Count; i++)
            {
                if (typedNumbers[i] == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
                result /= typedNumbers[i];
            }
            break;
        //case 5:
        //    Console.WriteLine("Closing the progran");
        //    return;

        //default:
        //    result = 0;
        //    break;
    }

    Console.WriteLine($"The Result of the operation is:{result}");

}

catch (Exception ex)
{
    Console.WriteLine($"You need to choose a correct option: {ex.Message}");
}
finally
{
    Console.WriteLine("Closing Db Conection");
}

//procceess
static decimal AddList(List<decimal> typedNumbers)
{
    decimal result = 0;
    foreach (decimal typedNumer in typedNumbers)
    {
        result += typedNumer;
    }
    return result;
}

static void DisplayHeader()
{
    Console.WriteLine("This is the best calculator");
    Console.WriteLine("Please Type the option number than you want");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("\n 1. Sum, \n 2. Substract,  \n 3. Multiplication,  \n 4. Division,  \n 5. Exit");
}