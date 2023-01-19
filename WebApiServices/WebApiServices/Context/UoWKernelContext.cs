using Domain.Entities.AppServices;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace WebApiServices.Context
{
    public partial class UoWKernelContext : DbContext, IUoWKernelContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public UoWKernelContext(DbContextOptions<UoWKernelContext> options)
      : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
