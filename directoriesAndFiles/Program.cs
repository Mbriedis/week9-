
class program
{
    static void Main(string[] args)
    {
        string rootDirectory = @"C:\Users\marti\samples";
        Console.WriteLine("Enter directory name");
        string newDirectory = Console.ReadLine();
        Console.WriteLine("enter file name");
        string filename = Console.ReadLine();


        
        if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{filename}"))
        {
            Console.WriteLine($"directory and file exist");
        }
        else
        {
            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            File.Create($"{rootDirectory}\\{newDirectory}\\{filename}");

        }

    }
}