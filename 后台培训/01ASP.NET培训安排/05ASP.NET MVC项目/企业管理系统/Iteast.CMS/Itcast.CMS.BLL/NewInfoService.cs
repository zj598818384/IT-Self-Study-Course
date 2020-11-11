using Itcast.CMS.DAL;
using Itcast.CMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itcast.CMS.BLL
{
    public class NewInfoService
    {
        NewInfoDal NewInfoDal = new NewInfoDal();

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pageIndex">当前页码值</param>
        /// <param name="pageSize">每页显示的记录数</param>
        /// <returns></returns>
        public List<NewInfo> GetPageList(int pageIndex,int pageSize)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageIndex * pageSize;
            List<NewInfo> list = NewInfoDal.GetPageList(start, end);
            return list;
        }

        /// <summary>
        /// 获取总的页数
        /// </summary>
        /// <returns></returns>
        public int GetPageCount(int pageSize)
        {
            int recordCount = NewInfoDal.GetRecordCount();
            int pageCount= Convert.ToInt32( Math.Ceiling((double)recordCount / pageSize));
            return pageCount;
        }

        public NewInfo GetModel(int id)
        {
            return NewInfoDal.GetModel(id);
        }

        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteInfo(int id)
        {
            return NewInfoDal.DeleteInfo(id)>0;
        }

        //添加一条记录
        public bool AddInfo(NewInfo newInfo)
        {
            return NewInfoDal.AddInfo(newInfo) > 0;
        }
    }
}
