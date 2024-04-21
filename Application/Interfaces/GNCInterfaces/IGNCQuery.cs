using Domain.Entities;

namespace Application.Interfaces.GNCInterfaces
{
    public interface IGNCQuery
    {
        GNC ObtenerGNCPorBooleano(bool tieneGnc);
    }
}
