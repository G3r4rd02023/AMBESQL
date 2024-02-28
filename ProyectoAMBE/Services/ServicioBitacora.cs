using ProyectoAMBE.Data;

namespace ProyectoAMBE.Services
{
    public class ServicioBitacora : IServicioBitacora
    {
        private readonly TransportedbContext _context;

        public ServicioBitacora(TransportedbContext context)
        {
            _context = context;
        }

        public async Task<Bitacora> AgregarRegistro(int idUsuario, int idInstituto,string tipoAccion, string tabla)
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
