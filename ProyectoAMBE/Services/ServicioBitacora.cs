using ProyectoAMBE.Data;

namespace ProyectoAMBE.Services
{
    public class ServicioBitacora : IServicioBitacora
    {
        private readonly AmbedbContext _context;

        public ServicioBitacora(AmbedbContext context)
        {
            _context = context;
        }

        public async Task<Bitacora> AgregarRegistro(int idUsuario, int idInstituto, string tipoAccion, string tabla)
        {
            Bitacora bitacora = new()
            {
                IdInstituto = idInstituto,
                TipoAccion = tipoAccion,
                Tabla = tabla,
                IdUsuario = idUsuario,
                Fecha = DateTime.Now,
            };
            _context.Bitacora.Add(bitacora);
            await _context.SaveChangesAsync();
            return bitacora;
        }
    }
}
