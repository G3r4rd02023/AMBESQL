using ProyectoAMBE.Data;

namespace ProyectoAMBE.Services
{
    public interface IServicioBitacora
    {
        Task<Bitacora> AgregarRegistro(string tipoAccion, string tabla);
    }
}
