using Muni.Almacen.Data;
using Muni.Almacen.IRepository;
using Microsoft.EntityFrameworkCore;
using Muni.Almacen.Entity.Inventario;
using Azure.Core;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Muni.Almacen.Repository
{
    //public class RegistroSalidaRepository(Minem_Db_Context Minem_Db_Context) : IRegistroSalidaRepository
    //{
    //    private readonly Minem_Db_Context _minemDbContext = Minem_Db_Context;
    //    private readonly string _connection = Minem_Db_Context.Database.GetConnectionString() ?? string.Empty;

    //    public async Task<IEnumerable<USP_SELECT_LISTAR_INVENTARIO_Response>> ListarRegistroSalida(long codMaeSolicitud)
    //    {
    //        var _db = new GenericRepository(_connection);

    //        return await _db.ExecuteProcedureToList<USP_SELECT_LISTAR_INVENTARIO_Response>("USP_SELECT_LISTAR_REGISTRO_SALIDA", null);
    //    }
    //}    
}
