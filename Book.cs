using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA221027
{
    internal class Book
    {
        private string author;
        private string title;
        private int yearOfPublication;
        private float price;

        public static readonly string[] RandomNames = {
            "Bognár Márk",
            "Kapolcs Flórián",
            "Fábián Marcell",
            "Kozma Zoltán",
            "Balázs Szilveszter",
            "Jakab Sándor",
            "Szűts István",
            "Mészáros Márton",
            "Szilágyi Tibor",
            "Dudás Alex"
        };
        public static List<string> GetRandomTitles()
        {
            List<string> titles = new();
            using StreamReader sr = new(@"..\..\..\res\titles.txt");
            while (!sr.EndOfStream) titles.Add(sr.ReadLine());
            return titles;
        }

        public string Author
        {
            get => author;
            set
            {
                if (value.Length < 3 || value.Length > 50)
                    throw new Exception("The name of the author must be [3; 50] char length");
                author = value;
            }
        }
        public string Title
        {
            get => title;
            set
            {
                if (value.Length < 3 || value.Length > 50)
                    throw new Exception("The title of the book must be [3; 50] char length");
                title = value;
            }
        }
        public int YearOfPublication
        {
            get => yearOfPublication;
            set
            {
                if (value < 1910 || value > DateTime.Now.Year)
                    throw new Exception($"The year of publication must be in [1910; {DateTime.Now.Year}]");
                yearOfPublication = value;
            }
        }
        public float Price
        {
            get => price;
            set
            {
                if (value > 15000)
                    throw new Exception("A book can't be more expensive than 15K");
                if (value % 5 != 0)
                    throw new Exception("A book's price must be divisible by five");
                price = value;
            }
        }
        public Genre Genre { get; set; }

        public Book(string author, string title, int yearOfPublication, float price, Genre genre)
        {
            Author = author;
            Title = title;
            YearOfPublication = yearOfPublication;
            Price = price;
            Genre = genre;
        }
    }

    public enum Genre
    {
        Dystopian,
        Fantasy,
        Fiction,
        Historical,
        Horror,
        Mystery,
        Romance,
        ScienceFiction,
        Thriller,
        Western,
    }
}
