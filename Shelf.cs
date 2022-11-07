using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA221027
{
    //internal class Shelf : List<Book>
    //{
    //    public new void Add(Book book)
    //    {
    //        if (book is null) throw new Exception("");
    //        if (this.Contains(book)) throw new Exception("");
    //        base.Add(book);
    //    }
    //}

    internal class Shelf
    {
        private List<Book> _books = new();
        public int Count => _books.Count;
        public float TotalPrice => _books.Sum(x => x.Price);

        public void Add(Book book)
        {
            if (book is null) throw new Exception("the instance of book can not be null");
            if (_books.Contains(book)) throw new Exception("the instance is already on the shelf");
            _books.Add(book);
        }

        public List<Book> SearchByAuthor(string author)
            => _books.Where(x => x.Author == author).ToList();

        private static Random rnd = new();
        public static Shelf InitRandomShelf(int noBooks)
        {
            List<string> titles = Book.GetRandomTitles();
            Shelf shelf = new();
            for (int i = 0; i < noBooks; i++)
            {
                shelf.Add(new Book(
                    author: Book.RandomNames[rnd.Next(Book.RandomNames.Length)],
                    title: titles[rnd.Next(titles.Count)],
                    yearOfPublication: rnd.Next(1910, DateTime.Today.Year + 1),
                    price: rnd.Next(500, 3000) * 5,
                    genre: (Genre)rnd.Next(10)));
            }
            return shelf;
        }

    }
}
