// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        List<string> myWishlist = new List<string>();
        Console.WriteLine(myWishlist.Count);

        myWishlist.Add("kohvimasin");
        myWishlist.Add("Õlu");
        myWishlist.Add("big beard");
        myWishlist.Add("new pillow");


        Console.WriteLine(myWishlist.Count);
        
        foreach(string wish in myWishlist)
        { Console.WriteLine(wish); }





    }











}