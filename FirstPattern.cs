using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternShow
{
    public class PaternShow
    {
        public static void NumberPattern()
        {
            Console.WriteLine("Pleas enter the no of Rows...:");
            int noOfRows=Convert.ToInt32(Console.ReadLine());
            for(int row=1; row<=noOfRows; row++)
            {
                for(int colum=1;colum<=noOfRows; colum++)
                {
                    Console.WriteLine(row +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
