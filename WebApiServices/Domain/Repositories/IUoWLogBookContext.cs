using Domain.Entities.LogBook;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUoWLogBookContext
    {
        public DbSet<Errorlog> Errorlogs { get; set; }
        //public DbSet<SesionLog> SesionLogs { get; set; }
        //public DbSet<Archivo> Archivo { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        //public List<GetLogBookArchivosResponse> ObtenerLogArchivosCargados(ParametrosConsultaArchivosLogbook parametro);
    }
}
