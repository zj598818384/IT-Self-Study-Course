namespace _007_EF框架.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<NewsInfo> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewsInfo>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<NewsInfo>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
