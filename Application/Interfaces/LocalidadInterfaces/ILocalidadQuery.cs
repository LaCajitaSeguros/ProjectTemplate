using Domain.Entities;

namespace Application.Interfaces.LocalidadInterfaces
{
    public interface ILocalidadQuery
    {
        Localidad ObtenerLocalidadPorNombre(string nombre);
    }
}
