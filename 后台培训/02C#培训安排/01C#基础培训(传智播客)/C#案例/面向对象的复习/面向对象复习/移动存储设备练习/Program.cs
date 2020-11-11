using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 移动存储设备练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化对象
            MobileDisk md = new MobileDisk();
            MP3Disk mp3 = new MP3Disk();
            UDisk u = new UDisk();
            Computer cp = new Computer();
            cp.MS = md;//子类可赋值给父类
            cp.CPURead();
            cp.CPUWrite();
            
        }
    }
    /// <summary>
    /// 抽象的移动存储设备父类
    /// </summary>
    public abstract class MobileStrage
    {
        public abstract void Read();
        public abstract void Write();
    }
    //移动硬盘
    public class MobileDisk : MobileStrage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }

    //U盘
    public class UDisk : MobileStrage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }

    //Mp3
    public class MP3Disk : MobileStrage
    {
        public void PlayMusic()
        {
            Console.WriteLine("MP3自己可以播放音乐");
        }
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("MP3在写入数据");
        }
    }

    //电脑
    public class Computer
    {
        public MobileStrage MS
        {
            get;
            set;
        }
        public void CPURead()
        {
            this.MS.Read();
        }
        public void CPUWrite()
        {
            this.MS.Write();
        }
    }
}
