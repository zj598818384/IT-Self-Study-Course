using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 10;
            ////number++;//自加一
            ////++number;//number=number+1;
            ////number--;//自减一
            //--number;
            //Console.WriteLine(number);
            //Console.ReadKey();

            //加加
            int number = 10;
            //int result = 10 + number++;
            //int result = 10 + number;
            number++;
            //在一个表达式中如果是后加那么就是先运算在加一
            int result = 10+ ++number;
            number++;
            //int result = 10 + number;
            //在一个表达式中如果是前加那么就是先加一在运算
            Console.WriteLine(number);
            Console.WriteLine(result);

            //减减
            int a = 10;
            //int b = 10 + a--;
            int b = 10 + a;
            a--;

            //int b = 10 + --a;
            a--;
            //int b = 10 + a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
