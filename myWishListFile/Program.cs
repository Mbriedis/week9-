
class program
{
    static void Main(string[] args)
    {
        string filepath = @"C:\Users\marti\samples\wishlist";
        string filename = @"\\mywishlist.txt";
        string[] arrayFromFile = File.ReadAllLines($"{filepath}{filename}");

        List<string> myWishList = arrayFromFile.ToList <string>();

        bool loopactive = true;
        while (loopactive)
        {
            Console.WriteLine("Would you like to add a wish? Y/N");
            char userInput = Convert.ToChar(Console.ReadLine().ToLower());

            if (userInput == 'y')
            {
                Console.WriteLine("Enter a wish");
                string userWish = Console.ReadLine();
                myWishList.Add(userWish);

            }
            else
            {
                loopactive = false;
                Console.WriteLine("Are u sure? O.o");
                
            }
        }
        Console.Clear();
        foreach (string item in myWishList)
        {
            Console.WriteLine($"your wish : {item}");
        }
        File.WriteAllLines($"{filepath}{filename}", myWishList);
      
      




    }
}