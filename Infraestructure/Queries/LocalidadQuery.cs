using Application.Interfaces.LocalidadInterfaces;
using Domain.Entities;
using Infraestructure.Persistence;
namespace Infraestructure.Queries
{
    public class LocalidadQuery : ILocalidadQuery
    {
        private readonly AppDbContext _context;

        public LocalidadQuery(AppDbContext context)
        {
            _context = context;
        }

        public Localidad ObtenerLocalidadPorNombre(string nombre)
        {
            return _context.Localidad.FirstOrDefault(n => n.Nombre == nombre);
        }
    }
}
