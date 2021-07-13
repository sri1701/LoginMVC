using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginMVC.Repositories.Models
{
    public partial class LoginContext : DbContext
    {

        public LoginContext()
        {

        }

        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {

        }

        public DbSet<LoginDataModel> LoginInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Lating1_General_CP1_CI_AS");
            modelBuilder.Entity<LoginDataModel>(
                entity =>
                {
                    entity.HasKey(s => s.Id);
                    entity.Property(e => e.UserName)
                    .IsUnicode(false);
                });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
