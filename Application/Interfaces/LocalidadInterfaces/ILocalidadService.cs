using Domain.Entities;

namespace Application.Interfaces.LocalidadInterfaces
{
    public interface ILocalidadService
    {
        Localidad ObtenerLocalidad(string nombre);
    }
}
