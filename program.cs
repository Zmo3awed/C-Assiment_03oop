using System.Text;

namespace tasks
{
   
    internal class Program
    {
        static void Print(string message)
        {

            Console.WriteLine(message);

        }
        static void PrintTitle(string title)
        {
            Console.WriteLine($"Book Title : {title}");
        }
        static int AddBounce(int pages)
        {
            return pages += 50;
        }
        static void Welcome() {
            Console.WriteLine("Welcome to the Library!");
        }
        static double ApplyDiscount(double[] prices)
        {
            return prices[0] -= 5;
        }
        static int AddBounceByRef( ref int pages)
        {
            return pages += 50;
        }
        static void ReplaceArray(ref double[] prices)
        {
             prices =new  double[] { 10.0, 12.5, 15.0 };
            
            
        }
        static bool TryGetPrice(string title, out double price)
        {
            if(title == null || title != "Clean Code")
            {
                price = 0;
                return false;
            }
            price = 25.5;
            return true;
                



        }
        static void PrintInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book Title :  {title} numper of pages : {pages}");
        }
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles) {

                Console.WriteLine(title);

            }
        }

        static void Main(string[] args)
                {
           
            ////Q1
            //double[] prices = { 25.5,40,45.25};
            //Console.WriteLine(prices[1]);
            ///***********************************************************/
            ////Q2
            //int[,] selfCopies = {

            //    {3,5 },
            //    {1,4 }

            //     };
            //Console.WriteLine(selfCopies[1,0]);
            /************************************************************/
            //Q3 
            //Welcome();

            //Q4

            //PrintTitle("Clean Code");
            /******************************************************/
            //Q5

            //int pages = 400;

            //Console.WriteLine($"pages Befor call : {pages}");
            //AddBounce(pages); // I expect to see the same value because it is value type and i passed prameter by value 
            //Console.WriteLine($"pages After call : {pages}");
            /*******************************************************************************************/
            //Q6
            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine($"prices befor : {prices[0]}");
            //ApplyDiscount(prices);
            //Console.WriteLine($"prices after : {prices[0]}");
            /****************************************************************************************/
            //Q7 

            //int pages = 400;

            //Console.WriteLine($"pages Befor call : {pages}");
            //AddBounceByRef(ref pages); // I expect to see deffrent value because we paased by ref so the variable it self will be passed 
            //Console.WriteLine($"pages After call : {pages}");
            /*****************************************************************************************/
            //Q8 
            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine($"Arr befor calling : ");
            //foreach (double pr in prices) { 
            //Console.Write($"{pr} ");

            //}
            //ReplaceArray(ref prices);
            //Console.WriteLine($"\nArr after calling : ");
            //foreach (double pr in prices)
            //{
            //    Console.Write($"{pr} ");

            //}
            /****************************************************************************************/
            //Q9
            //bool thereprice = TryGetPrice("Clean Code", out double price);
            //if (thereprice)
            //{
            //    Console.WriteLine($"Price is : {price}");

            //}
            //else
            //{
            //    Console.WriteLine("There is no price");
            //}
            /******************************************************************************************/
            //Q10/11
            //PrintInfo("Clean Code ");
            //PrintInfo("Clean Code ", 400);
            //PrintInfo(pages:400,title:"Clean Code");
            /******************************************************************************************/
            //Q12
            //PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Design Patterns");
           







        }
    }
}
