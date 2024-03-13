using ProyectoAMBE.Data;

namespace ProyectoAMBE.Services
{
    public interface IServicioBitacora
    {
        Task<Bitacora> AgregarRegistro(int idUsuario, int idInstituto, string tipoAccion, string tabla);
    }
}
