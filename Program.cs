using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conv2
{
    class Program
    {
        static void Main(string[] args)
        {
            string binnum = bin(-2147483648);
            Console.WriteLine(binnum);
            Console.ReadLine();
        }
        static string bin(int decIn)
        {
            int dec = decIn;
            int decotr = ~decIn;
            char[] bin2 = new char[32];            
            for (int i = bin2.Length - 1; i >= 0; i--)
            {                
                if (decIn < 0)
                {                    
                    int ost = Math.Abs(decotr % 2);
                    decotr /= 2;
                    bin2[i] = (char)((char)(ost ^ 1) + '0');
                }
                else
                {
                    int ost = Math.Abs(dec % 2);
                    dec /= 2;
                    bin2[i] = (char)((char)ost + '0');
                }
            }           
            string aa = new string(bin2);
            return aa;
        }
    }
}
