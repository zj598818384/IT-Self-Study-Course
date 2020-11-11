using StudentSys.Dal;
using StudentSys.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Bll
{
    public class SystemManager
    {
        //创建员工类型
        public static async Task CreateEmployeeType(string name)
        {
            using (var empTypeSvc=new EmployeeTypeService())
            {
                await empTypeSvc.CreateAsync(new EmployeeType()
                {
                    Name = name
                });
            }
        }

        //创建年级
        public static async Task CreateGrade(string name)
        {
            using (var gradeSvc=new GradeService())
            {
                var maxOrder = await gradeSvc.GetAll().MaxAsync(selector: m => m.Order);
                await gradeSvc.CreateAsync(new Grade() { Name = name,Order=maxOrder+1});
            }
        }

        //往上调一个，减一个班级编号
        public static async Task GradeUp(Guid gradeid)
        {
            using (var gradeSvc=new GradeService())
            {
                var grade = await gradeSvc.GetOne(gradeid);
                var beforeGrade = await gradeSvc.GetAll(predicate: m => m.Order < grade.Order).FirstOrDefaultAsync();
                if (beforeGrade == null) return;
                await gradeSvc.ChangeOrder(gradeid, beforeGrade.Order, false);
                await gradeSvc.ChangeOrder(beforeGrade.Id, grade.Order);
            }
        }

        //下移班级
        public static async Task GradeDown(Guid gradeid)
        {
            using (var gradeSvc=new GradeService())
            {
                var grade = await gradeSvc.GetOne(gradeid);
                var beforeGrade = await gradeSvc.GetAll(m => m.Order > grade.Order).FirstOrDefaultAsync();
                if (beforeGrade == null) return;
                await gradeSvc.ChangeOrder(gradeid, beforeGrade.Order, false);
                await gradeSvc.ChangeOrder(beforeGrade.Id, grade.Order);
            }
        }

        //修改名称
        public static async Task ChangeName(Guid id,string name)
        {
            using (var gradeSvc=new GradeService())
            {
                await gradeSvc.ChangeName(id, name);
            }
        }

        //创建科目
        public static async Task CreateSubject(string name,Guid gradeId)
        {
            using (var subSvc=new SubjectService())
            {
                await subSvc.CreateAsync(new Subject()
                {
                    Name = name,
                    GradeId = gradeId
                });
            }
        }

        //修改科目所属年级或名称，修改全部
        public static async Task EditSubject(Guid id,Guid gradeid,string name)
        {
            using (var subSvc=new SubjectService())
            {
                await subSvc.EditAsync(new Subject()
                {
                    Id = id,
                    Name = name,
                    GradeId = gradeid
                });
            }
        }

        //修改单个
        public static async Task EditSubjectName(Guid id,string name)
        {
            using (var subSvc=new SubjectService())
            {
                await subSvc.EditName(id, name);
            }
        }

    }
}
