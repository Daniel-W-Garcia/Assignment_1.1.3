namespace Assignment_1._1._3;

public class UserInterface
{
    private Formulas formulas = new();
    private Arrays arrays = new();
    
    bool exitProgram;

    public void UserInterfaceToolSelection()
    {
        exitProgram = false;
        Console.Clear();
        Console.WriteLine("""
                          What tool would you like to use?
                          1. Area Calculator
                          2. Create Arrays

                          """);
        
        string choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":
                UserInterfaceLoopForAreas();
                break;
            case "2":
                UserInterfaceLoopForArrays();
                break;
        }
    }
    public void UserInterfaceLoopForAreas()
    {
        while (!exitProgram)
        {
            Console.Clear();
            Console.WriteLine("""
                              Area Calculator
                              ===============
                              1. Calculate Triangle Area
                              2. Calculate Square Area
                              3. Calculate Rectangle Area
                              4. Exit
                              
                              """);

            Console.Write("\nEnter your choice (1-4): ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    CalculateTriangleArea();
                    break;
                case "2":
                    CalculateSquareArea();
                    break;
                case "3":
                    CalculateRectangleArea();
                    break;
                case "4":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    public void UserInterfaceLoopForArrays()
    {
        while (!exitProgram)
        {
            Console.Clear();
            Console.WriteLine("""
                              Create Arrays
                              ===============
                              
                              1. Populate a name array
                              2. Get sum from an integer array
                              3. Get sum from a double array
                              4. Back to main menu
                              5. Exit
                              
                              """);
            Console.Write("\nEnter your choice (1-5): ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    arrays.PopulateNames(this);
                    break;
                case "2":
                    arrays.SumOfAllIntegers();
                    break;
                case "3":
                    arrays.SumOfAllDoubles();
                    break;
                case "4":
                    UserInterfaceToolSelection();
                    break;
                case "5":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        } 
    }
    
    private void CalculateTriangleArea()
    {
        Console.Clear();
        Console.WriteLine("Triangle Area Calculator");
        Console.WriteLine("=======================");
        
        double baseLength = GetValidInput("Enter base length: ");
        double height = GetValidInput("Enter height: ");
        
        double area = formulas.TriangleArea(baseLength, height);
        
        Console.WriteLine($"\nThe area of the triangle is: {area}");
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }
    
    private void CalculateSquareArea()
    {
        Console.Clear();
        Console.WriteLine("Square Area Calculator");
        Console.WriteLine("=====================");
        
        double side = GetValidInput("Enter the side length: ");
        
        double area = formulas.SquareArea(side);
        
        Console.WriteLine($"\nThe area of the square is: {area}");
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }
    
    private void CalculateRectangleArea()
    {
        Console.Clear();
        Console.WriteLine("Rectangle Area Calculator");
        Console.WriteLine("========================");
        
        double length = GetValidInput("Enter length: ");
        double width = GetValidInput("Enter width: ");
        
        double area = formulas.RectangleArea(length, width);
        
        Console.WriteLine($"\nThe area of the rectangle is: {area}");
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }
    
    private double GetValidInput(string instructions)
    {
        double value;
        bool isValid = false;
        
        do
        {
            Console.Write(instructions);
            string input = Console.ReadLine();
            
            if (double.TryParse(input, out value) && value > 0)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        } while (!isValid);
        
        return value;
    }
}