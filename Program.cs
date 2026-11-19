
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //            Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a
            //            variable of type object.Print it

            //Book book = new Book();
            //book.title = "mybook";
            //book.pages = 100;
            //object obj = book;
            //Console.WriteLine(book);
            #endregion

            #region  question2
            //            .Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            //              itself), GetHashCode(), and GetType() on book.
            //Book book = new Book();
            //book.title = "mybook";
            //book.pages = 100;
            //Console.WriteLine($"ToString(): {book.ToString()}");
            //Console.WriteLine($"Equals(book): {book.Equals(book)}");
            //Console.WriteLine($"GetHashCode(): {book.GetHashCode()}");
            //Console.WriteLine($"GetType(): {book.GetType()}");
            #endregion

            #region   question3
            //Q03.Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            // int pages = "464";
            // it is a compilation error (try to assign a string value to int value type to fix it we should remove ""
            //int pages = 464;

            #endregion

            #region question4

            //. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //  zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    int z = x / y;
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally {
            //    Console.WriteLine("Done");

            //}




            #endregion

            #region question5
            //. Declare an int pages = 300; then store it in a double variable without using a cast
            //int pages = 300;
            //double  papers = pages;
            #endregion

            #region  question6
            //Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int actualprice = (int)price;
            #endregion

            #region question7
            // Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            #endregion

            #region  question8
            //Given string yearText = "2023";, convert it using int.Parse().Then given string badText = "abc";,
            //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //string yearText = "2023";
            //int yearNumber =int.Parse(yearText);
            //string badText = "abc";
            //bool lapel = int.TryParse(badText , out int parsenumber );
            //if (lapel == false)
            //{
            //    Console.WriteLine("invalid number");
            //}


            #endregion

            #region  question9
            //Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            //to prove it's now a string.
            //int pages = 464;
            //string Stringpages= pages.ToString();
            //Console.WriteLine(Stringpages.GetType());
            #endregion

            #region  question10
            //. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            //    variable, and print both.
            //int copies = 100;
            //object objcopies = copies;
            //int newcopies = (int)copies;
            //Console.WriteLine($" Boxed : {objcopies}");
            //Console.WriteLine($" UnBoxed : {newcopies}");
            #endregion
        }
    }
}
