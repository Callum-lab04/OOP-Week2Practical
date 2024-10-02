/*
 * Practical 2
 * Information: Methods demo
 * Version 1
 * Author Callum McConnell
 * Date: October 2024
 */

Main();
void Main()
{
    int option;
    do
    {
        PrintMenu();
        option = InputOption();
        GetMessage(option);
    }
    while (option != 0);
}
static void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below: ");
    Console.WriteLine("1. Hello in French");
    Console.WriteLine("2. Hello in Spanish");
    Console.WriteLine("3. Hello in German");
    Console.WriteLine("4. Hello in Italian");
    Console.WriteLine("0. Exit application");
}
static int InputOption()
{
    Console.WriteLine("Please select an option");
    string UserInput = Console.ReadLine();

    try
    {
        int option  = Convert.ToInt32(UserInput);
        return option;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error. {ex.Message}");
        return InputOption();
    }
}

static void GetMessage(int option)
{
    switch (option)
    {
        case 0:
            Console.WriteLine("Goodbye");
            break;
        case 1:
            Console.WriteLine("Bonjour");
            break;
        case 2:
            Console.WriteLine("Hola");
            break;
        case 3:
            Console.WriteLine("Hallo");
            break;
        case 4:
            Console.WriteLine("Ciao");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

/* Task 5 
 * 
 * Console.WriteLine("Enter a string:");
String UserInput = Console.ReadLine();
int Length = UserInput.Length;
Console.WriteLine("Number of words = {0}", Length);
/*
