class Program
{

    public static void Main()
    {

        var mc = new Program();
        // 1.Užduotis
        mc.Task1();

        // 2.Užduotis
        mc.Task2();

        //3.Užduotis
        mc.Task3();

        //4.Užduotis
        mc.Task4();

        //5.Užduotis
        mc.Task5();

        //6.Užduotis
        mc.Task6();

        //7.Užduotis
        mc.Task7();

    }


    public void Task1()
    {
        // 1.Užduotis

        Console.WriteLine("1. Užduotis");
        var arr1 = new int[0];
        string userInput1;

        do
        {
            Console.WriteLine(@"Įveskite saičių (arba ""exit"").");
            userInput1 = Console.ReadLine();
            if (Int32.TryParse(userInput1, out int inputNumber))
            {
                Array.Resize(ref arr1, arr1.Length + 1);
                arr1[arr1.Length - 1] = inputNumber;
            }
            else Console.WriteLine("Įvesti galima tik skaičių, arba 'exit'.");

            Console.WriteLine($"Sugeneruotas masyvas: {string.Join(", ", arr1)}");
        }
        while (userInput1 != "exit");
    }

    public void Task2()
    {

        // 2.Užduotis

        Console.WriteLine("2. Užduotis");
        var arr2 = new int[0];
        string userInput2;

        do
        {
            Console.WriteLine(@"Įveskite saičių (arba ""exit"").");
            userInput2 = Console.ReadLine();
            if (Int32.TryParse(userInput2, out int inputNumber))
            {
                Array.Resize(ref arr2, arr2.Length + 1);
                arr2[arr2.Length - 1] = inputNumber;
            }
            else Console.WriteLine("Įvesti galima tik skaičių, arba 'exit'.");
            Console.Write("Sugeneruotas masyvas atbuline tvarka: ");

            for (var arrItem = arr2.Length - 1; arrItem >= 0; arrItem--)
            { Console.Write($"{arr2[arrItem]} "); }
            Console.WriteLine();
        }
        while (userInput2 != "exit");

    }

    public void Task3()
    {
        //3.Užduotis
        Console.WriteLine("3. Užduotis");
        var arr3 = new int[0];
        string userInput3;

        do
        {
            int arrItemSum = 0;
            userInput3 = null;
            Console.WriteLine(@"Įveskite saičių (arba ""exit"").");
            userInput3 = Console.ReadLine();
            if (Int32.TryParse(userInput3, out int inputNumber))
            {
                Array.Resize(ref arr3, arr3.Length + 1);
                arr3[arr3.Length - 1] = inputNumber;
            }
            else Console.WriteLine("Įvesti galima tik skaičių, arba 'exit'.");

            for (var arrItem = 0; arrItem < arr3.Length; arrItem++)
            { arrItemSum += arr3[arrItem]; }

            Console.WriteLine($"Įvestų skaičių suma: {arrItemSum}");
        }
        while (userInput3 != "exit");
    }

    public void Task4()
    {
        //4.Užduotis
        //4.Parašykite programą, kuri suformuotų n*m elementų masyvą iš klaviatūra įvedamų skaičių ir atspausdintų reikšmes į ekraną.

        Console.WriteLine("4. Užduotis");
        var rows = ReadValue("Enter Dimension1: ");
        var cols = ReadValue("Enter Dimension2: ");

        var matrix1 = ReadMatrix(rows, cols);

        // Print matrix

        for (var row = 0; row < rows; row++)
        {
            var outputRow = new int[cols];
            for (var col = 0; col < cols; col++)
            {
                outputRow[col] = matrix1[row, col];
            }
            Console.WriteLine(string.Join('\t', outputRow));
        }
    }

    public void Task5()
    {
        //5.Užduotis
        //5.Parašykite programą, kuri suformuotų du dvimačius n*m elementų masyvus iš klaviatūra įvedamų skaičių ir sudėtų jų reikšmes į trečią n*m dvimatį masyvą.

        Console.WriteLine("5. Užduotis");
        var rows = ReadValue("Enter Dimension1: ");
        var cols = ReadValue("Enter Dimension2: ");

        var matrix1 = ReadMatrix(rows, cols);
        var matrix2 = ReadMatrix(rows, cols);
        var resultMatrix = new int[rows, cols];

        // Multiply matrix1 and matrix2
        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                resultMatrix[row, col] = matrix1[row, col] + matrix2[row, col];
            }
        }

        // Print result matrix

        for (var row = 0; row < rows; row++)
        {
            var outputRow = new int[cols];
            for (var col = 0; col < cols; col++)
            {
                outputRow[col] = resultMatrix[row, col];
            }
            Console.WriteLine(string.Join('\t', outputRow));
        }
    }


    public void Task6()
    {
        //6.Užduotis
        //6.Parašykite programą, kuri suformuotų du dvimačius masyvus iš klaviatūra įvedamų skaičių ir sudaugintų jų reikšmes į trečią dvimatį masyvą.

        Console.WriteLine("6. Užduotis");
        var rows = ReadValue("Enter Dimension1: ");
        var cols = ReadValue("Enter Dimension2: ");

        var matrix1 = ReadMatrix(rows, cols);
        var matrix2 = ReadMatrix(rows, cols);
        var resultMatrix = new int[rows, cols];

        // Multiply matrix1 and matrix2
        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                resultMatrix[row, col] = matrix1[row, col] * matrix2[row, col];
            }
        }

        // Print result matrix

        for (var row = 0; row < rows; row++)
        {
            var outputRow = new int[cols];
            for (var col = 0; col < cols; col++)
            {
                outputRow[col] = resultMatrix[row, col];
            }
            Console.WriteLine(string.Join('\t', outputRow));
        }
    }

    public void Task7()
    {
        //7.Užduotis
        //. Parašykite programą, kuri suformuotų atsitiktinių skaičių masyvą. Surikiuokite elementus panaudojus Bubble sort algoritmą.

        Console.WriteLine("7. Užduotis");
        int arrayLength = ReadValue("Įveskite masyvo ilgį: ");
        int[] randomArray = new int[arrayLength];
        Random randObj = new(arrayLength);
        bool isArraySorted = false;

        for (int n = 0; n < arrayLength; n++)
        {
            randomArray[n] = randObj.Next(0, 10);
        }


        Console.WriteLine($"Atsitiktinai sugeneruotas masyvas: {string.Join(", ", randomArray)}");

        while (!isArraySorted)
        {
            isArraySorted = true;
            for (int n = 0; n < arrayLength; n++)
            {
                if (n + 1 < arrayLength)
                {
                    if (randomArray[n] > randomArray[n + 1])
                    {
                        var temp = randomArray[n];
                        randomArray[n] = randomArray[n + 1];
                        randomArray[n + 1] = temp;
                        isArraySorted = false;
                    }
                }
            }
        }
        Console.WriteLine($"Išrikiuotas masyvas: {string.Join(", ", randomArray)}");
    }
    public int[,] ReadMatrix(int rows, int cols)
    {
        Console.WriteLine("Enter matrix:");
        var matrix = new int[rows, cols];
        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                matrix[row, col] = ReadValue($"Enter row {row} column {col} value: ");
            }
        }
        return matrix;
    }

    public int ReadValue(string inputQuestion)
    {
        Console.Write(inputQuestion);
        return ReadNumber();
    }

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
}