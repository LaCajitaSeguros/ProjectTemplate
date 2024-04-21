using Application.Interfaces.MarcaInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Queries
{
    public class MarcaQuery : IMarcaQuery
    {
        private readonly AppDbContext _context;

        public MarcaQuery(AppDbContext context)
        {
            _context = context;
        }

        public Marca ObtenerMarca(int marcaId)
        {
            return _context.Marca.FirstOrDefault(m => m.MarcaId == marcaId);
        }
    }
}
