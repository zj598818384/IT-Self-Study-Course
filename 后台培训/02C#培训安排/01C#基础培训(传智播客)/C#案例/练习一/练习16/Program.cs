using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习16
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习十六：有如下字符串【患者:"大夫，我咳嗽得很严重"，大夫："你多大年纪？"，
            //患者:"七十五岁",大夫："二十岁咳嗽吗?",患者："不咳嗽"，大夫："四十岁时咳嗽吗?"，
            //患者:"不咳嗽"，大夫："那现在不咳嗽，还要等到什么时候咳嗽"】。
            //需求：请冲击出现该字符咳嗽二字的出现次数，以及每次咳嗽出现的索引位置。
            string str = "患者:“大夫，我咳嗽得很严重”，大夫：“你多大年纪？”，患者:“七十五岁”,大夫：“二十岁咳嗽吗 ? ”,患者：“不咳嗽”，大夫：“四十岁时咳嗽吗 ? ”，患者:”不咳嗽“，大夫：“那现在不咳嗽，还要等到什么时候咳嗽”";
            int index = str.IndexOf("咳嗽");
            int i = 1;
            Console.WriteLine("第一次咳嗽出现的位置{0}",index);
            while (index!=-1)
            {
                i++;
                index=str.IndexOf("咳嗽",index+1);
                if (index==-1)
                {
                    break;
                }
                Console.WriteLine("第{0}次找到咳嗽的位置是{1}",i,index);
            }
        }
    }
}
