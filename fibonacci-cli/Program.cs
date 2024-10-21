void GenerateFibonacci()
{
    Console.WriteLine("Enter the amount of fibonacci numbers to generate:");

    // recieve user input, check for null before calling trim, if it is null, use null coalescing value to return tmpty string.
    string userInput = Console.ReadLine()?.Trim() ?? "";

    // check to see that the user input is a valid integer
    bool isValidInt = int.TryParse(userInput, out int numbersToGenerate);

    //if the user enter nothing, or the input is not a valid int, alert them and re-run the program.
    if (userInput == "" || userInput == null || !isValidInt)
    {
        Console.WriteLine("Please enter in a valid number.");
        GenerateFibonacci();
    }
    else
    {
        // assign first two numbers of fibonacci sequence as these can't be generated using the pattern
        List<ulong> fibSequence = new List<ulong> { 0, 1 };

// start the for loop at index 2 so the first two values don't get overwritten
        for (int i = 2; i < numbersToGenerate; i++)
        {
                // execute the pattern on the rest of the amount of numbers
                ulong nextFib = fibSequence[i - 1] + fibSequence[i - 2];
                fibSequence.Add(nextFib);
        };

        // convert the List into a string to print out
        Console.WriteLine(String.Join(",", fibSequence));
    }


}

GenerateFibonacci();
