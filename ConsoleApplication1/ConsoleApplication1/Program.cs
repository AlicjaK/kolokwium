using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }



        public static int PairofCars(int p, int q)
        {
            int x = 0;
            int y = 0;



            if (p == 0 && q == 1) x = p; y = q;

            

            return PairofCars(x,y);
          
        }

        public static int TravelingEast()
        {
            return 0;
        }
    }


}
