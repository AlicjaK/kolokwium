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
            //List<Cars> carslist = new List<Cars>();
            //carslist[0] = 0;
            //carslist[1] = 1;
            //carslist[2] = 0;
            //carslist[3] = 1;
            //carslist[4] = 1;
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

        public static bool IsPair(int p, int q)
        {
            if (p == 0 && q == 1) return true;
            else return false;
        }
    }

    //internal class Cars
    //{
    //    public static implicit operator Cars(int v)
    //    {
    //        //throw new NotImplementedException();
           
    //    }
    //}
}
