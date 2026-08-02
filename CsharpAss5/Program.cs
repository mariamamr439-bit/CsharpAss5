using System;

namespace CsharpAss5
{
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    class Book
    {
        // Q1
        private string password = "secret";

        // Q2
        internal int copiesInStock = 5;

        // Q3
        public string Title;

        // Q4
        public Genre Genre;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            #region Q1 - Private

            // Console.WriteLine(book.password);
            // Compile Error:
            // 'Book.password' is inaccessible due to its protection level.

            #endregion

            #region Q2 - Internal

            Console.WriteLine(book.copiesInStock);

            #endregion

            #region Q3 - Public

            book.Title = "Clean Code";
            Console.WriteLine(book.Title);

            #endregion

            #region Q4 - Enum Property

            book.Genre = Genre.Science;
            Console.WriteLine(book.Genre);

            #endregion

            #region Q5 - Enum to int

            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);

            #endregion

            #region Q6 - int to Enum

            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;

            Console.WriteLine(genre);

            #endregion

            #region Q7 - Enum ToString()

            Genre g = Genre.Fiction;

            string genreText = g.ToString();

            Console.WriteLine(genreText);

            #endregion

            #region Q8 - Enum.Parse()

            string text = "Science";

            Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), text);

            Console.WriteLine(parsedGenre);

            #endregion

            #region Q9 - Enum.TryParse()

            string invalidText = "Mystery";

            bool success = Enum.TryParse(invalidText, out Genre result);

            if (success)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }

            #endregion
        }
    }
}