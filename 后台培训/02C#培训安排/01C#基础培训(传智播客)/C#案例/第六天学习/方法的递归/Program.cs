using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            TellStory();
        }

        public static int i = 0;//静态字段

        public static void TellStory()
        {
            Console.WriteLine("从前有做山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天，小和尚哭了，老和尚给小和尚讲了个故事");
            i++;
            if (i>=10)
            {
                return;
            }
            TellStory();
        }
    }
}
