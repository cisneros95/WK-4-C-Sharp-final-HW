using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WK_4_C_Sharp_final_hW
{
    class Program
    {
        static void Main(string[] args)
        {

            int storeNum = 1;
            int [] storeSales = new int [5]; // Last number of times the loop will run
            while (storeNum <= 5)                                                           // <--- Reconizing that this is O(n) Algorithm Computation 
            {
                Console.WriteLine($"Enter Today's sales for store {storeNum}: ");
                int asterisks = (Convert.ToInt32(Console.ReadLine())) / 100;  // Divide the store sales by 100
                storeSales[storeNum - 1] = asterisks;
                storeNum++;
                
            
            }
            storeNum = 1;
            Console.WriteLine("Store Sales \n(Each *= $100)"); // Displays 
            Console.WriteLine();
            while (storeNum <= 5)                                                           // <--- Another O(n) Algorithm Computation. Variable n condition to loop 5 times
            {
                Console.Write($"Store {storeNum}: ");
                int x = storeSales[storeNum - 1];
                DisplayAsterisks(x);
                storeNum++;
            }
            DisplayAsterisks(100);  // Displays 100 Astrisks as the end of the table

        }
        public static void DisplayAsterisks(int num)
        {

            while(num > 0)                                                                  // <--- Last O(n) Algorithm Computation
            {
                Console.Write("*");
                num--;
                            
            }
            Console.WriteLine();
            return;
        
        }
    }
}
