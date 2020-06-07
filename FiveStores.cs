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
            DisplayAsterisks(120);  // Displays 100 Astrisks as the end of the table. THIS IS THE SOLUTION FOR PROBLEM 1

            int storeNum = 1;
            int [] storeSales = new int [5]; // Last number of times the loop will run in this Array
            while (storeNum <= 5)                                                           // <--- Reconizing that this is O(n) Algorithm Computation 
            {
                Console.WriteLine($"Enter Today's sales for store {storeNum}: "); // {storeNum} Changes the store number label
                int asterisks = (Convert.ToInt32(Console.ReadLine())) / 100;  // Divide the store sales by 100
                storeSales[storeNum - 1] = asterisks;
                storeNum++;
                
            
            }
            storeNum = 1;
            Console.WriteLine("Store Sales \n(Each *= $100)"); // Displays 
            Console.WriteLine();
            while (storeNum <= 5)                                                           // <--- Another O(n) Algorithm Computation. Variable n condition to loop 5 times
            {
                Console.Write($"Store {storeNum}: "); // again {storeNum} Changes the store number label While (storeNum <=5) it will display only 5 stores
                int x = storeSales[storeNum - 1];
                DisplayAsterisks(x);
                storeNum++;
            }
           DisplayAsterisks(120);  // Displays 100 Astrisks as the end of the table. THIS IS THE SOLUTION FOR PROBLEM 1

        }
        public static void DisplayAsterisks(int num)
        {

            while(num > 0)                                           // <--- Last O(n) Algorithm Computation
            {                                                        //   
                Console.Write("*");                                  //
                num--;                                               //   
                                                                     //     
            }                                                        //   
            Console.WriteLine(); // displays the code
            return;   // returns
        
        }
    }
}
