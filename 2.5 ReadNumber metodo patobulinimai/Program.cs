
ReadNumber();

static int ReadNumber()
{
    string userInput = Console.ReadLine();
    bool isInputANumber;
    do
    {
        isInputANumber = Int32.TryParse(userInput, out int input);
        if (!isInputANumber)
        {
            Console.WriteLine("Įvedėte ne skaičių. Įveskite dar kartą: ");
            userInput = Console.ReadLine();
        }
    }
    while (!isInputANumber);
    return int.Parse(userInput);
}