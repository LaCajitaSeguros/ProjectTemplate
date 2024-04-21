using Domain.Entities;

namespace Application.Interfaces.GNCInterfaces
{
    public interface IGNCService
    {
        GNC ObtenerObjetoGNC(bool tieneGnc);
    }
}
