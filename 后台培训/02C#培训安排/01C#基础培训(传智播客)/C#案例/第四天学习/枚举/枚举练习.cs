using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    //季节
    public enum Sesons
    {
        春,
        夏,
        秋,
        冬
    }

    //QQ状态
    public enum QQState
    { 
        Online,
        Offline,
        Leave,
        Busy,
        QMe
    }
    class 枚举练习
    {
        Sesons s = Sesons.春;
        QQState qq = QQState.Online;
    }
}
