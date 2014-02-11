using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an ArrayList and add two ints
            ArrayList list = new ArrayList();
            list.Add("bird");
            list.Add("rock");
            list.Add("jacket");
            list.Add("shoe");

            // Get Last two elements in ArrayList
            ArrayList range = list.GetRange(2, 2);
            //Display Elements
            foreach (string value in range)
            {
                Console.WriteLine(value); // jacket, shoe
                
            }

        }
    }
}
