namespace CA221027
{
    internal class Program
    {
        static void Main()
        {
            Shelf shelf = new();
            Book book = new()
            {
                Author = "Juhász Zoltán"
            };
            shelf.Add(book);
        }
    }
}