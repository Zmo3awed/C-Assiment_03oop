using System.Text;

namespace tasks
{

    internal class Program

    {
        static void Main(string[] args) { 
   

        //Q1
        //We can not access it because it is private and no one can see this variable outside the class
        //Q2
         book book = new book();
         Console.WriteLine(book.copiesInStock);
            //compiled normly because internall allow to access at the same project 
        //Q3
         book.title = "clean code";
         Console.WriteLine(book.title);
        //Q4
         book.genre = Genre.Science;
         Console.WriteLine(book.genre);
        //Q5
         int genreNumber = 1;
         book.genre =(Genre) genreNumber;
        //Q6
         Genre genre = Genre.Fiction;
         Console.WriteLine(genre.ToString());
        //Q7
         string genreText = "Science";
         Genre genre2 =(Genre) Enum.Parse(typeof(Genre),genreText);
         Console.WriteLine(genre2);
         //Q8
         string genreText2 = "Mystery";
         bool isparsed = Enum.TryParse(genreText2, true,out Genre genre3);
            if (isparsed)
            {
                Console.WriteLine("Parsed sucsess");

            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
         









        }
    }
}
   
    
