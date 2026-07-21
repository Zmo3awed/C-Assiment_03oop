using System.Text;

namespace tasks
{
   
    internal class Program
    {
        static void print(string message)
        {

            Console.WriteLine(message);

        }
        //Q18 the function 
        static void printfirest(string[] arr) {

            if (arr == null || arr.Length == 0)
            {
                return;
            }
            else
                print(arr[0]);
            }
                static void Main(string[] args)
                {

            /* 


                     * NOOTE I Declared a print function just to make print easy instade of write console..... every time               */



            //Q1
            //string title = "Clean Code";
            //string uppertitle = title.ToUpper();
            //print(uppertitle);
            //print(title);
            /**************************************************************/
            //Q2
            //string s1 = "zyad";
            //string s2 = "zyad";
            //Console.WriteLine(object.ReferenceEquals(s1,s2));
            /****************************************************************/
            //Q3
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book Liest");
            //print(sb.ToString());
            //sb.Append(" - Updated");
            //print(sb.ToString());
            /*****************************************************************/
            //Q4
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book Liest");
            //sb.Replace("Book Liest","Library");
            //print(sb.ToString());
            //Q5/6/7
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("Book : " + title + "  Pages : " + pages);
            //Console.WriteLine($"Book : {title}  Pages : {pages}");
            //string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);
            /**********************************************************************/
            //Q8/9
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300)
            //    print("Loong Book");
            //else
            //    print("Short Book");
            //if (pages > 300 && isAvailable)
            //    print("You Can Borrow it");
            //else
            //    print("not available to borrow");
            /****************************************************************************/
            //Q10 ---------------------------------------->>>> you need to keep ot deafult value is missd
            //string title = "Refactoring";

            //string result = title switch
            //{
            //    "Clean Code" => "Great choice!",
            //    "Refactoring" => "Nice pick!",
            //    _ => "Never heard of it"
            //};

            //Console.WriteLine(result);
            /*****************************************************************************/
            //Q11 
            //int pages = 464;
            //string result = pages > 300 ? "Loong Book" : "Short Book";
            //print(result);
            /*****************************************************************************/
            //Q12 / 13
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{


            //    print($"{i} : {books[i]} \n");

            //}
            //int j = 0;
            //while (j < books.Length)
            //{
            //    print($"{j} : {books[j]} \n");
            //    j++;
            //}
            /*******************************************************************************/
            //Q14 
            //int j = 0;
            //do
            //{
            //    print("Checking book... \n");
            //    j++;
            //} while (j<=2);
            /*****************************************************************************/
            //Q15 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books ) {
            //    print($"{book}\n");

            //}
            /*******************************************************************************/
            //Q16  /17 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "Refactoring")
            //        break;
            //    print(books[i]);
            //}
            ////17
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "The Pragmatic Programmer")
            //        continue;
            //    print(books[i]);
            //}
            //Q18
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //printfirest(books);
            //string[] b=null;
            //printfirest(b);
            //string[] c = { "" };
            //printfirest(c);



        }
    }
}
