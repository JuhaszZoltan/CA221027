using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA221027
{
    //internal class Shelf<Book> : List<Book>
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
            if (book is null) throw new Exception("");
            if (_books.Contains(book)) throw new Exception("");
            _books.Add(book);
        }

        public List<Book> SearchByAuthor(string author)
            => _books.Where(x => x.Author == author).ToList();

    }
}
