using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUoWAppServicesContext
    {
        public DbSet<Entities.AppServices.Usuario> Usuarios { get; set; }

    }
}
