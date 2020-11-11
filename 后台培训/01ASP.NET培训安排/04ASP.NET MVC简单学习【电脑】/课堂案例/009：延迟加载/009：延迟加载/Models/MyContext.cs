namespace _009_延迟加载.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<admin> admin { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
