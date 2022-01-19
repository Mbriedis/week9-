// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        string rootDirectory = @"C:\Users\marti\samples";
        Console.WriteLine("Enter directory name");
        string newDirectory = Console.ReadLine();
        Console.WriteLine("enter shopping list name ");
        string filename = Console.ReadLine() + ".txt";



        if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{filename}"))
        {

            Console.WriteLine($"shopping list already exists");

        }
        else
        {
            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            File.Create($"{rootDirectory}\\{newDirectory}\\{filename}");
            Console.WriteLine("New Shopping list has been created");

        }
    }
}       