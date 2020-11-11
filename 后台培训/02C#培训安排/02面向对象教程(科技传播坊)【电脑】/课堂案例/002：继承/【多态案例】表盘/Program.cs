using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _多态案例_表盘
{
    class 雇佣兵的HP
    {
        public int HP { get; set; }
        public void Render()
        {
            Console.WriteLine("雇佣兵的HP为{0}",this.HP);
        }
    }

    class 主角的HP
    {
        public int HP { get; set; }
        public void Render()
        {
            Console.WriteLine("主角的HP为{0}", this.HP);
        }
    }

    class 主角
    {
        public 主角的HP HP = new 主角的HP();//has-a
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
