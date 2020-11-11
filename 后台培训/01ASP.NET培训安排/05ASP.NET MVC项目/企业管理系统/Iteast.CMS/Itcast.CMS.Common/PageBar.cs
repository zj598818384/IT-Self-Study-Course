using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itcast.CMS.Common
{
    public class PageBar
    {
        /// <summary>
        /// 产生数字页码条
        /// </summary>
        /// <param name="pageIndex">当前页码值</param>
        /// <param name="pageCount">总数</param>
        /// <returns></returns>
        public static string GetPageBar(int pageIndex,int pageCount)
        {
            if (pageCount==1)
            {
                //如果为1则返回空
                return string.Empty;
            }
            //起始位置，要求页面上显示10个数字页面
            int start = pageIndex - 5;
            if (start<1)
            {
                start = 1;
            }
            //终止位置
            int end = start + 9;
            if (end>pageCount)
            {
                end = pageCount;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = start; i <=end; i++)
            {
                if (i==pageIndex)
                {
                    //当前页不需要添加链接
                    sb.Append(i);
                }else
                {
                    //给不是当前页添加链接
                    sb.Append(string.Format("<a href='?pageIndex={0}'>{0}</a>",i));
                }
            }
            return sb.ToString() ;
        }
    }
}
