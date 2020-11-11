using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Model
{
    public class StudentContext:DbContext
    {
        //构造函数
        public StudentContext() : base(nameOrConnectionString: "con")
        {
            //代表不采用初始化方式
            Database.SetInitializer<StudentContext>(strategy:null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassTeacherHasClass> ClassTeacherHasClass { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentGraduateInfo> StudentGraduateInfoes { get; set; }
        public DbSet<StudentDoc> StudentDocs { get; set; }
        public DbSet<StudentJob> StudentJobs { get; set; }
        public DbSet<StudentLabComplete> StudentLabCompletes { get; set; }
        public DbSet<StudentRelative> StudentRelatives { get; set; }
        public DbSet<StudentSigned> StudentSigns { get; set; }
        public DbSet<StudentTalked> StudentTalks { get; set; }
        public DbSet<SysSetting> SysSettings { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
