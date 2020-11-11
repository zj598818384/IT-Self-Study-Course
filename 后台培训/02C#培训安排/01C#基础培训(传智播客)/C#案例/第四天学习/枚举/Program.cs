using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    //声明了一个枚举 Gender
    public enum Gender
    {
        男,
        女,//枚举最后一个值的逗号可加可不加
    }
    class Program
    {
        static void Main(string[] args)
        {
            //调用枚举
            //变量类型 变量名=值;
            int n = 10;
            Gender gender = Gender.男;
        }
    }
}
