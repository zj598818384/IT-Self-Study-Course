using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习01
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习01：编写一段程序，运行时向用户提问"你考了多少分？"，
            //接受输入后判断其等级并显示粗来。判断依据如下：等级=
            //(优(90~100分)；良(80~89分)；中(60~69分)；差(0~59分))
            Console.WriteLine("请输入你的考试成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
        }

        public static string GetLevel(int score)
        {
            string level = null;
            #region 方法一使用else-if语句
            //if (score>=90)
            //{
            //    level = "优秀";
            //}
            //else if (score>=80)
            //{
            //    level = "良";
            //}
            //else if (score>=70)
            //{
            //    level = "中";
            //}
            //else if (score>60)
            //{
            //    level = "差";
            //}
            //else
            //{
            //    level = "不及格";
            //}
            #endregion

            #region 方法二使用switch语句
            switch (score/10)
            {
                case 10:
                case 9:
                    level = "优秀";
                    break;
                case 8:
                    level = "良好";
                    break;
                case 7:
                    level = "中等";
                    break;
                case 6:
                    level = "差";
                    break;
                default:
                    level = "不及格";
                    break;
            }
            #endregion
            return level;
        }
    }
}
