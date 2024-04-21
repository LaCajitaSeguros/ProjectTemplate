using Application.Interfaces.ModeloInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Queries
{
    public class ModeloQuery : IModeloQuery
    {
        private readonly AppDbContext _context;

        public ModeloQuery(AppDbContext context)
        {
            _context = context;
        }

        public Modelo ObtenerModelo(int modeloId, int marcaId)
        {
            return _context.Modelo.FirstOrDefault(mod => mod.ModeloId == modeloId && mod.MarcaId == marcaId);
        }
    }
}
