using System;

namespace dotnet_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opposites attract:
            public class LoveDetector
            {
                public static bool lovefunc(int flower1, int flower2)
                { 
                    //Moment of truth...
                  if (flower1 % 2 != flower2 % 2) {
                    return true;
                  } else {
                    return false;
                  }
                }
            }

            // It only takes one...
            public class Kata
            {
              public static bool Check(object[] a, object x)
              {
              
                foreach(var element in a) {
                  if (element.ToString() == x.ToString()) {
                    return true;
                  }
                }
                return false;

                }
              }

                // sum of positive
                using System;
                using System.Linq;

                public class Kata
                {
                  public static int PositiveSum(int[] arr)
                  {
                    var sum = 0;
                    foreach(var num in arr) {
                      if (num > 0) {
                        sum += num;
                      }
                    }
                    return sum;
                  }
                }

        }
    }
}
