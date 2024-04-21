using Application.Interfaces.AnioVehiculosInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infraestructure.Queries
{
    public class AnioVehiculoQuery : IAnioVehiculoQuery
    {
        private readonly AppDbContext _context;

        public AnioVehiculoQuery(AppDbContext context)
        {
            _context = context;
        }

        public AnioVehiculo ObtenerVehiculo(int anioVehiculo)
        {
            return _context.AnioVehiculo.FirstOrDefault(av => av.AnioVehiculoDesde <= anioVehiculo && av.AnioVehiculoHasta >= anioVehiculo);
        }
    }
}
