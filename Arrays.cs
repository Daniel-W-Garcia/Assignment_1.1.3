namespace Assignment_1._1._3;

public class Arrays
{
    private string[] names;
    private int[] numbers = {1, 3, 5, 7, 9};
    private double[] doubles = {2.4, 3.5, 4.6, 5.7, 6.8};
    
    private string[,] twoDinmensionalArray = new string[5, 5];
    private string[,,] threeDimensionalArray = new string[5, 5, 5];
    private string[][] multiDimensionalArray = new string[5][];


    public void PopulateNames(UserInterface userInterface)
    {
        Console.Write("How many names would you like to enter? ");
        int size = int.Parse(Console.ReadLine());
    
        names = new string[size];
    
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Enter name #{i+1}: ");
            names[i] = Console.ReadLine();
        }
        
        Console.WriteLine("Would you like to see your names? (y/n)");
        string answer = Console.ReadLine();
        
        if (answer.ToLower() == "y")
        {
            PrintNames(names);
            
            Console.WriteLine("Would you like to reverse the names? (y/n)");
            
            answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                ReverseArray();
                Console.WriteLine("\nPress any key to return to the array menu...");
                Console.ReadKey();
                    
            }
            else
            {
                ClearScreenAndReturnToMenu(userInterface);
            }
        }
        else
        {
            ClearScreenAndReturnToMenu(userInterface);
        }
    }
    
    public void PrintNames(string[] names)
    {
        Console.WriteLine("Your names are:");
        
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
    }
    
    public void SumOfAllIntegers()
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine(sum);
        
        Console.WriteLine("\nPress any key to return to the array menu...");
        Console.ReadKey();
    }

    public void SumOfAllDoubles()
    {
        double sum = 0;
        for (int i =0; i < doubles.Length; i++)
        {
            sum += doubles[i];
        }
        Console.WriteLine(sum);
        
        Console.WriteLine("\nPress any key to return to the array menu...");
        Console.ReadKey();
    }

    public void ReverseArray()
    {
        string[] reversedArray = new string[names.Length];
        for (int i = 0; i < names.Length; i++)
        {
            reversedArray[i] = names[names.Length - i - 1];
        }
        PrintNames(reversedArray);
    }

    public void ClearScreenAndReturnToMenu(UserInterface userInterface)
    {
        Console.Clear();
        Console.WriteLine("""
                          Where would you like to go next?
                          1. Main Menu
                          2. Array Menu
                          3. Exit
                          """);
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                userInterface.UserInterfaceToolSelection();
                break;
            case "2":
                userInterface.UserInterfaceLoopForArrays();
                break;
            case "3":
                userInterface.UserInterfaceLoopForAreas();
                break;
            case "4":
                Environment.Exit(0);
                break;
        }
    }
}