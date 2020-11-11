using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习12
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习十二：用方法来实现：有一个字符串数组:
            //{ "马龙","迈克尔乔丹","蒂姆邓肯","科比布莱恩特"},
            //请输出最长的字符串
            string[] names = { "马龙", "迈克尔乔丹", "蒂姆邓肯", "科比布莱恩特" };
            string max = GetLongest(names);
            Console.WriteLine(max);
        }
        public static string GetLongest(string[] names)
        {
            string max = names[0];
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length>max.Length)
                {
                    max = names[i];
                }
            }
            return max;
        }
    }
}
