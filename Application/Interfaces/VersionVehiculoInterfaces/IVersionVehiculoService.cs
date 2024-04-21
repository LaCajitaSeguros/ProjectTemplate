using Domain.Entities;

namespace Application.Interfaces.VersionVehiculoInterfaces
{
    public interface IVersionVehiculoService
    {
        VersionVehiculo ObtenerVersion(int versionId, int modeloId);
    }
}
