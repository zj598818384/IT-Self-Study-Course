﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //李四的年终奖工作评定，如果定为A级，则工资涨500元，如果定为B级
            //则工资涨200元，如果定为C级，工资不变，如果定为D级工资降200元，
            //如果定为E级工资降500元
            //设李四的原工资为5000，请用户输入李四的评级，然后显示李四来年的工资
            bool b = true;
            double salary = 5000;
            Console.WriteLine("请输入对李四的年终级评定：");
            string level = Console.ReadLine();
            switch (level)
            {
                case "A":
                    Console.WriteLine(salary += 500);
                    break;
                case "B":
                    Console.WriteLine(salary += 200);
                    break;
                case "C":
                    break;
                case "D":
                    Console.WriteLine(salary -= 200);
                    break;
                case "E":
                    Console.WriteLine(salary -= 500);
                    break;
                default:
                    Console.WriteLine("输入有误，程序退出");
                    b = false;
                    break;
            }
            if (b)
            {
                Console.WriteLine("李四你来年的工资是{0}", salary);
            }

            //if(level=="A")
            //{
            //    salary += 500;
            //}
            //else if(level=="B")
            //{
            //    salary += 200;
            //}
            //else if(level=="C")
            //{

            //}
            //else if (level == "D")
            //{
            //    salary -= 200;
            //}
            //else if (level == "E")
            //{
            //    salary -= 500;
            //}
            //else
            //{
            //    Console.WriteLine("你所输入有误，请重新输入");
            //    b = false;
            //}
            //if(b)
            //{
            //    Console.WriteLine("李四你来年的工资是{0}",salary);
            //}

        }
    }
}
