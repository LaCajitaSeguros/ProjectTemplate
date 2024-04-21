using Domain.Entities;

namespace Application.Interfaces.RangoEtarioInterfaces
{
    public interface IRangoEtarioQuery
    {
        RangoEtario ObtenerListaDeRangoEtario(int edad);
    }
}
