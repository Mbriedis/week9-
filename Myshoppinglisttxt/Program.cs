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
        { 


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
          string [] itemsFromFile = File.ReadAllLines($"{rootDirectory}\\{newDirectory}\\{filename}");
        List<string> myShoppingList = itemsFromFile.ToList<string>();

        bool loopactive = true;
        while (loopactive)
        {
            Console.WriteLine("Would you like to add something to the Shopping list? Y/N");
            char userInput = Convert.ToChar(Console.ReadLine().ToLower());

            if (userInput == 'y')
            {
                Console.WriteLine("Enter an item");
                string stuff = Console.ReadLine();
                myShoppingList.Add(stuff);

            }
            else if (userInput == 'n')
            {
                Console.WriteLine("Are u sure? O.o press any other button to finish");
            }
            else
                loopactive = false;
        }
        
        Console.Clear();
        foreach (string item in myShoppingList)
        {
            Console.WriteLine($"Your shopping list : {item}");
        }
        File.WriteAllLines($"{newDirectory}{filename}",myShoppingList);
    }

}