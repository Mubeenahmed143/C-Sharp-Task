using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_Task
{
    internal class Book
    {

        private string author;
        private string title;
        private int isbn;
        private int check_out;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public int Check_out
        {
            get { return check_out; }
            set { check_out = value; }
        }

        public void Checkedout()
        {
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("ISBN: {0}", ISBN);
            Console.WriteLine("Checked out: {0}", Check_out);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Author = "John Doe";
            book.Title = "Sample Book";
            book.ISBN = 1234567890;
            book.Check_out = 1;

            book.Checkedout();
        }
    }
}
