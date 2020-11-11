namespace _008_增删改查操作_crud_.Models
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
        public virtual DbSet<flower_detail> flower_detail { get; set; }
        public virtual DbSet<flower_type> flower_type { get; set; }
        public virtual DbSet<ft_type> ft_type { get; set; }
        public virtual DbSet<getmoney> getmoney { get; set; }
        public virtual DbSet<leavemessage> leavemessage { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<order_detail> order_detail { get; set; }
        public virtual DbSet<ordersheet> ordersheet { get; set; }
        public virtual DbSet<shoppingcar> shoppingcar { get; set; }
        public virtual DbSet<user_register> user_register { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<flower_detail>()
                .Property(e => e.bh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<flower_detail>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<flower_detail>()
                .Property(e => e.material)
                .IsUnicode(false);

            modelBuilder.Entity<flower_detail>()
                .Property(e => e.package)
                .IsUnicode(false);

            modelBuilder.Entity<flower_detail>()
                .Property(e => e.flower_language)
                .IsUnicode(false);

            modelBuilder.Entity<flower_detail>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<flower_detail>()
                .Property(e => e.zp)
                .IsUnicode(false);

            modelBuilder.Entity<flower_type>()
                .Property(e => e.type_name)
                .IsUnicode(false);

            modelBuilder.Entity<flower_type>()
                .HasMany(e => e.flower_detail)
                .WithOptional(e => e.flower_type)
                .WillCascadeOnDelete();

            modelBuilder.Entity<flower_type>()
                .HasMany(e => e.ft_type)
                .WithOptional(e => e.flower_type)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ft_type>()
                .Property(e => e.ft_name)
                .IsUnicode(false);

            modelBuilder.Entity<getmoney>()
                .Property(e => e.bank_deposit)
                .IsUnicode(false);

            modelBuilder.Entity<getmoney>()
                .Property(e => e.bank_account)
                .IsUnicode(false);

            modelBuilder.Entity<getmoney>()
                .Property(e => e.payee)
                .IsUnicode(false);

            modelBuilder.Entity<leavemessage>()
                .Property(e => e.Mtype)
                .IsUnicode(false);

            modelBuilder.Entity<leavemessage>()
                .Property(e => e.Mname)
                .IsUnicode(false);

            modelBuilder.Entity<leavemessage>()
                .Property(e => e.Mphone)
                .IsUnicode(false);

            modelBuilder.Entity<leavemessage>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<leavemessage>()
                .Property(e => e.Mtitle)
                .IsUnicode(false);

            modelBuilder.Entity<leavemessage>()
                .Property(e => e.Mtext)
                .IsUnicode(false);

            modelBuilder.Entity<news>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<news>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<news>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<order_detail>()
                .Property(e => e.order_id)
                .IsUnicode(false);

            modelBuilder.Entity<order_detail>()
                .Property(e => e.bh)
                .IsUnicode(false);

            modelBuilder.Entity<ordersheet>()
                .Property(e => e.order_id)
                .IsUnicode(false);

            modelBuilder.Entity<ordersheet>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<ordersheet>()
                .Property(e => e.orderstate)
                .IsUnicode(false);

            modelBuilder.Entity<ordersheet>()
                .Property(e => e.receivername)
                .IsUnicode(false);

            modelBuilder.Entity<ordersheet>()
                .Property(e => e.receivertel)
                .IsUnicode(false);

            modelBuilder.Entity<ordersheet>()
                .Property(e => e.receiveraddr)
                .IsUnicode(false);

            modelBuilder.Entity<ordersheet>()
                .HasMany(e => e.order_detail)
                .WithOptional(e => e.ordersheet)
                .WillCascadeOnDelete();

            modelBuilder.Entity<shoppingcar>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<shoppingcar>()
                .Property(e => e.bh)
                .IsUnicode(false);

            modelBuilder.Entity<shoppingcar>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<shoppingcar>()
                .Property(e => e.zp)
                .IsUnicode(false);

            modelBuilder.Entity<user_register>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user_register>()
                .Property(e => e.truename)
                .IsUnicode(false);

            modelBuilder.Entity<user_register>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user_register>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<user_register>()
                .Property(e => e.guding)
                .IsUnicode(false);

            modelBuilder.Entity<user_register>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<user_register>()
                .Property(e => e.qq)
                .IsUnicode(false);

            modelBuilder.Entity<user_register>()
                .HasMany(e => e.ordersheet)
                .WithOptional(e => e.user_register)
                .WillCascadeOnDelete();

            modelBuilder.Entity<user_register>()
                .HasMany(e => e.shoppingcar)
                .WithOptional(e => e.user_register)
                .WillCascadeOnDelete();
        }
    }
}
