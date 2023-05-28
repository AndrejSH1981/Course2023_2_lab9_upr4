using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Many_Books
{
    class Book : IComparable<Book>
    {
        private string author;
        private string title;
        private int year;
        private int pages;

        public Book(string author, string title, int year, int pages)
        {
            this.author = author;
            this.title = title;
            this.year = year;
            this.pages = pages;
        }


        public void Show()
        {
            Console.WriteLine($"Author: {author} \n Title: {title} \n Year: {year} \n Pages: {pages} \n ");
        }

        public int CompareTo(Book many_books)
        {
            if (this.year == many_books.year)
            {
                return 0;
            }
            else if (this.year < many_books.year)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[5];
            books[0] = new Book("Вася Пупкин", "Как я заработал миллиард", 2007, 15);
            books[1] = new Book("Министерство энергетики Российской Федерации", "ПТЭЭП", 2004, 300);
            books[2] = new Book("Под редакцией проф. Г.А.Рябинина", "Справочник физических Величин", 2001, 257);
            books[3] = new Book("Советская энциклопедия", "Космонавтика", 1968, 527);
            books[4] = new Book("В.В.Зайцев, В.ВРыжков, М.И.Сканави", "Элементарная математика", 1976, 586);

            Array.Sort(books);

            Console.WriteLine("Сортировка книг по году выпуска: \n");
            foreach (Book book in books)
            {
                book.Show();
            }
        }
    }
}
