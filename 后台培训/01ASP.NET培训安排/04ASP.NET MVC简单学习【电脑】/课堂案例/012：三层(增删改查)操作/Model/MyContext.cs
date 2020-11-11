namespace Model
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

        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<States>()
                .Property(e => e.StatesName)
                .IsUnicode(false);

            modelBuilder.Entity<States>()
                .HasMany(e => e.UserInfo)
                .WithRequired(e => e.States)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.CustomerPWD)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.CustomerType)
                .IsUnicode(false);
        }
    }
}
