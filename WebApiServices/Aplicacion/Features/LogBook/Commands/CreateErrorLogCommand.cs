using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Features.LogBook.Commands
{
    public class CreateErrorLogCommand
    {
        private readonly IUoWLogBookContext _uoWLogBook;
        public CreateErrorLogCommand(IUoWLogBookContext uoWLogBook)
        {
            _uoWLogBook = uoWLogBook;
        }


    }

}
