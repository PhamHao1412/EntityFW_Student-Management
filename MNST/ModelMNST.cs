using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MNST
{
    public partial class ModelMNST : DbContext
    {
        public ModelMNST()
            : base("name=ModelMNST")
        {
        }

       public virtual DbSet<FACULTY> FACULTY { get; set; }
        public virtual DbSet<STUDENT> STUDENT { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FACULTY>()
                .HasMany(e => e.STUDENT)
                .WithRequired(e => e.FACULTY)
                .WillCascadeOnDelete(false);
        }
    }
}
