using Application.Interfaces.GNCInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Queries
{
    public class GNCQuery : IGNCQuery
    {
        private readonly AppDbContext _context;

        public GNCQuery(AppDbContext context)
        {
            _context = context;
        }

        public GNC ObtenerGNCPorBooleano(bool tieneGnc)
        {
            return _context.GNC.FirstOrDefault(tg => tg.HasGNC == tieneGnc);
        }
    }
}
