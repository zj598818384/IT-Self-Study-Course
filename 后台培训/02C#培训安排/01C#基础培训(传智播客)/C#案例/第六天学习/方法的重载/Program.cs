using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void M(int n1, int n2)
        {
            int result = n1 + n2;
        }

        public static double M(double d1, double d2)
        {
            return d1 + d2;
        }

        public static void M(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
        }
         
        public static string M(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
