using Domain.Entities;

namespace Application.Interfaces.RangoEtarioInterfaces
{
    public interface IRangoEtarioService
    {
        RangoEtario ObtenerRangoEtario(int edad);
    }
}
