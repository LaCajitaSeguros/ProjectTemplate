using Application.Interfaces.RangoEtarioInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Queries
{
    public class RangoEtarioQuery : IRangoEtarioQuery
    {
        private readonly AppDbContext _context;

        public RangoEtarioQuery(AppDbContext context)
        {
            _context = context;
        }

        public RangoEtario ObtenerListaDeRangoEtario(int edad)
        {
            return _context.RangoEtario.FirstOrDefault(re => re.EdadDesde <= edad && re.EdadHasta >= edad);
        }
    }
}
