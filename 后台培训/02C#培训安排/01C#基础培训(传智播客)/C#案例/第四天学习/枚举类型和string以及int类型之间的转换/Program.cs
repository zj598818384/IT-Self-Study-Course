using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举类型和string以及int类型之间的转换
{
    //QQ状态
    public enum QQState
    {
        Online=1,
        Offline,
        Leave,
        Busy,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {
            //将枚举类型强转成int类型
            QQState state = QQState.Online;
            //枚举类型默认可以跟int类型互相装换，枚举类型跟int类型是兼容的
            int n = (int)state;
            Console.WriteLine(n);
            Console.WriteLine((int)QQState.Offline);
            Console.WriteLine((int)QQState.Busy);
            Console.WriteLine((int)QQState.Leave);
            Console.WriteLine((int)QQState.QMe);
            Console.ReadKey();

            //将int类型强转成枚举类型
            int n1 = 3;
            QQState state1 = (QQState)n1;
            Console.WriteLine(state1);

            //所有的类型都能够转换成string类型，调用ToString进行转换
            int n2 = 10;
            string s = n1.ToString();
            Console.WriteLine(s);

            //将枚举类型转换为字符串类型
            QQState state2 = QQState.Online;
            string ss = state2.ToString();
            Console.WriteLine(ss);

            //将字符串类型转换为枚举类型
            string sss = "3";
            //三种转换：convert.toint32、int.parse()、int.tryparse()
            //调用parse()方法的目的就是为了让他帮助我们将一个字符串转换成对应的枚举类型
            QQState state3=(QQState)Enum.Parse(typeof(QQState),sss);
            //(QQState)强调转换的类型
            //typeof(QQState)获得枚举类型
            //sss要转换的字符串
            Console.WriteLine(state3);

            //枚举练习
            //枚举默认从0开始
            //提示用户选择一个在线状态，我们接受，并将用户的输入转换成枚举类型。
            //再次打印在控制台
            Console.WriteLine("请你选择你的QQ在线状态1-OnLine 2-OffLine 3-Leave 4-Busy 5-QMe");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("你选择的在线状态是{0}",s1);
                    break;
                case "2":
                    QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("你选择的在线状态是{0}", s2);
                    break;
                case "3":
                    QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("你选择的在线状态是{0}", s3); 
                    break;
                case "4":
                    QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("你选择的在线状态是{0}", s4);
                    break;
                case "5":
                    QQState s5 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("你选择的在线状态是{0}", s5);
                    break;
            }

        }
    }
}
