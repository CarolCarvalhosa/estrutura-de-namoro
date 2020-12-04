namespace EstruturasDeNamoro
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<User> User { get; set; }

        public virtual DbSet<UserMatch> UserMatch { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PhotoURL)
                .IsUnicode(false);

            modelBuilder.Entity<UserMatch>()
                .Property(e => e.UserId);

            modelBuilder.Entity<UserMatch>()
                .Property(e => e.User2Id);
        }
    }
}
