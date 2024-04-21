using Application.Interfaces.LocalidadInterfaces;
using Domain.Entities;

namespace Application.UseCase.Localidades
{
    public class LocalidadService : ILocalidadService
    {
        private readonly ILocalidadQuery _query;

        public LocalidadService(ILocalidadQuery query)
        {
            _query = query;
        }

        public Localidad ObtenerLocalidad(string nombre)
        {
            return _query.ObtenerLocalidadPorNombre(nombre);
        }
    }
}
