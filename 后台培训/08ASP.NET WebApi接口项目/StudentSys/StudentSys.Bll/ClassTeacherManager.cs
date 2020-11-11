using StudentSys.Dal;
using StudentSys.Dto;
using StudentSys.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Bll
{
    public class ClassTeacherManager
    {
        //创建班级
        public static async Task CreateClass(string clsName,Guid gradeid)
        {
            using (var clsSvc = new ClassService())
            {
                await clsSvc.CreateAsync(new Class()
                {
                    GradeId = gradeid,
                    Name = clsName
                });
            }
        }

        //修改班级
        public static async Task ChangeClassName(Guid clsId,string clsName)
        {
            using (var clsSvc=new ClassService())
            {
                await clsSvc.ChangeName(clsId, clsName);
            }
        }

        //升学
        public static async Task LevelUpClass(Guid clsId)
        {
            using (var clsSvc=new ClassService())
            {
                //获取当前年级id
                var cls = await clsSvc.GetOne(clsId);
                using (var gradeSvc=new GradeService())
                {
                    var grade=await gradeSvc.GetAll(predicate: m => m.Order > cls.Grade.Order).FirstOrDefaultAsync();
                    if (grade==null)
                    {
                        //直接毕业
                        await Graduation(clsId);
                        return;
                    }
                    Guid gradeId = grade.Id;
                    await clsSvc.ChangeGrade(clsId, gradeId);
                }
                
            }
        }

        //毕业
        public static async Task Graduation(Guid clsId)
        {
            using (var clsSvc=new ClassService())
            {
                await clsSvc.ClassGraduation(clsId);
            }
        }
        
        //创建考试信息
        public static async Task CreateExam(Guid clsId,Guid subjectId,DateTime examTime)
        {
            using (var examSvc=new ExamService())
            {
                await examSvc.CreateAsync(new Exam()
                {
                    ClassId = clsId,
                    SubjectId = subjectId,
                    ExamTime = examTime
                });
            }
        }

        //通过班级获取学生基本信息
        public static async Task<List<StudentExamDto>> GetStudentsByClassId(Guid clsId)
        {
            using (var stuSvc=new StudentService())
            {
                return await stuSvc.GetAll(m => m.ClassId == clsId)
                    .Include(m => m.Class)
                    .Select(m => new StudentExamDto()
                    {
                        ClassId = m.ClassId.Value,
                        ClassName = m.Class.Name,
                        StudentId = m.Id,
                        Name = m.Name,
                        ImagePath = m.ImagePath
                    }).ToListAsync();
            }
        }

        //批量添加考试成绩
        public static async Task CreateExamScores(Guid examId,Dictionary<Guid,int> stuExamScores)
        {
            using (var scoreSvc=new ScoreService())
            {
                foreach (var stuExamScore in stuExamScores)
                {
                    await scoreSvc.CreateAsync(new Score()
                    {
                        ExamId = examId,
                        ExamScore = stuExamScore.Value,
                        StudentId = stuExamScore.Key
                    }, false);
                }
                await scoreSvc.SaveAsync();
            }
        }

        //通过考试编号获取学生考试信息
        public static async Task<List<StudentScoreDto>> GetScoreByExamId(Guid examId)
        {
            using (var scoreSvc=new ScoreService())
            {
                return await scoreSvc.GetAll(m => m.ExamId == examId)
                    .Include(m => m.Student.Class)
                    .Include(m => m.Exam.Subject)
                    .Select(m => new StudentScoreDto()
                    {
                        StudentId = m.Student.Id,
                        Name = m.Student.Name,
                        ImagePath = m.Student.ImagePath,
                        ScoreId = m.Id,
                        Score = m.ExamScore,
                        ExamId = m.ExamId,
                        ExamTime = m.Exam.ExamTime,
                        ClassId = m.Student.ClassId.Value,
                        ClassName = m.Student.Class.Name,
                        SubjectId = m.Exam.SubjectId,
                        SubjectName = m.Exam.Subject.Name
                    }).ToListAsync();
            }
        }
        
        //修改其中一个
        public static async Task ChangeScore(Guid scoreId,int result)
        {
            using (var scoreSvc=new ScoreService())
            {
                await scoreSvc.ChangeScore(scoreId, result);
            }
        }

        //获取所有的签到学生信息
        public static async Task<List<StudentSignedDto>> GetStudentSigneds(Guid clsId)
        {
            using (var stuSignedSvc=new StudentSignedService())
            {
                return await stuSignedSvc.GetAll(m => m.ClassId == clsId)
                    .Include(m => m.Student.Class)
                    .Select(m => new StudentSignedDto
                    {
                        Id = m.Id,
                        ClassId = m.ClassId,
                        ClassName = m.Student.Class.Name,
                        ImagePath = m.Student.ImagePath,
                        StudentId = m.StudentId,
                        Name = m.Student.Name
                    }).ToListAsync();
            }
        }

        //创建签到
        public static async Task CreateSigned(Guid clsId,DateTime? inTime=null)
        {
            var stus = await GetStudentSigneds(clsId);
            using (var stuSignedSvc=new StudentSignedService())
            {
                foreach (var studentSignedDto in stus)
                {
                    await stuSignedSvc.CreateAsync(new StudentSigned()
                    {
                        ClassId = clsId,
                        InTime = inTime == null ? DateTime.Now : inTime.Value,
                        SignedType = "正常",
                        StudentId = studentSignedDto.StudentId
                    }, false);
                }

                await stuSignedSvc.SaveAsync(false);
            }
        }

        //修改签到状态
        public static async Task ChangeSigned(Guid signId,string stateName)
        {
            using (var stuSignSvc=new StudentSignedService())
            {
                await stuSignSvc.ChangeSignedType(signId, stateName);
            }
        }

        //签退
        public static async Task Signout(Guid[] signIds,DateTime? timeOut=null)
        {
            using (var stuSignSvc=new StudentSignedService())
            {
                await stuSignSvc.Signout(signIds, timeOut);
            }
        }
    }
}
