using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {

        private static int numerOfPairs = 0;

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

        public static int TravelingWest()
        {
            return 1;
        }

        public static int PairsPassingCars()
        {
            numerOfPairs++;


            if (numerOfPairs == 1000000) return -1;
            else return numerOfPairs;
        }
    }


}
