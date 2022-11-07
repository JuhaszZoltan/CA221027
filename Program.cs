namespace CA221027
{
    internal class Program
    {
        static void Main()
        {
            Shelf shelf = Shelf.InitRandomShelf(40);
            Console.WriteLine($"SoP: {shelf.TotalPrice}");

            Book b = new Book(
                author: "Zolikaaa",
                title: "Az élet szar!",
                yearOfPublication: 2022,
                price: 1500f,
                genre: Genre.Horror);
        }
    }
}