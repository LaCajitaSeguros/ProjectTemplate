using Domain.Entities;

namespace Application.Interfaces.VersionVehiculoInterfaces
{
    public interface IVersionVehiculoQuery
    {
        VersionVehiculo ObtenerVersionPorId(int versionId, int modeloId);
    }
}
