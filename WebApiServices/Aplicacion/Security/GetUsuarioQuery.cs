using Aplicacion.Features.LogBook.Commands;
using AutoMapper;
using Domain.Entities.AppServices;
using Domain.Repositories;
using Domain.Shared.Wrapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Security
{
    public class GetUsuarioQuery: IRequest<Result<List<GetUsuarioResponse>>>
    {
        public GetUsuarioQuery()
        {

        }
    }

    public class GetEmpresaQueryHandler : IRequestHandler<GetUsuarioQuery, Result<List<GetUsuarioResponse>>>
    {
        private readonly IMapper _mapper;
        private readonly IUoWAppServicesContext _uoWAppServicesContext;
        private CreateErrorLogCommand _logcommand;

        public GetEmpresaQueryHandler(IMapper mapper, IUoWAppServicesContext uowAppServicesContext,  IUoWLogBookContext uowlb)       
        {

            _mapper = mapper;
            _uoWAppServicesContext = uowAppServicesContext;
            _logcommand = new CreateErrorLogCommand(uowlb);
        }

        public async Task<Result<List<GetUsuarioResponse>>> Handle(GetUsuarioQuery request, CancellationToken cancellationToken)
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = _uoWAppServicesContext.Usuarios.ToList();
            var ListamapeoUsuarios = new List<GetUsuarioResponse>();

            try
            {
                ListamapeoUsuarios = _mapper.Map<List<GetUsuarioResponse>>(usuarios);
                return await Result <List<GetUsuarioResponse>>.SuccessAsync(ListamapeoUsuarios, "Se obtuvieron los registros correctamente");

            }
            catch (Exception ex)
            {
                //_logcommand.AddLog(MethodBase.GetCurrentMethod(), ex.Message);
                return await Result<List<GetUsuarioResponse>>.FailAsync(ex.Message);

            }

        }
    }
}
