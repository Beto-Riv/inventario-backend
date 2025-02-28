using AutoMapper;
using Muni.Almacen.Dto.Inventario;
using Muni.Almacen.IApplication;
using Muni.Almacen.Infraestructure;
using Muni.Almacen.IRepository;
using Muni.Almacen.Utils;

namespace Muni.Almacen.Application
{
    //public class RegistroSalidaApplication(IRegistroSalidaRepository repository, IMapper mapper) : IRegistroSalidaApplication
    //{
        //private readonly IMapper _mapper = mapper;
        //private readonly IRegistroSalidaRepository _repository = repository;

        //public async Task<StatusResponse<IEnumerable<ListarInventarioResponseDto>>> ListarRegistroSalida(long CodMaeSolicitud)
        //{
        //    try
        //    {
        //        var respuesta = _mapper.Map<IEnumerable<ListarInventarioResponseDto>>(await _repository.ListarRegistroSalida(CodMaeSolicitud));
        //        if (!respuesta.Any()) throw new Exception("No hay información");
        //        return Message.Successful(respuesta);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Message.Exception<IEnumerable<ListarInventarioResponseDto>>(ex);
        //    }

        //}



    //}
}
