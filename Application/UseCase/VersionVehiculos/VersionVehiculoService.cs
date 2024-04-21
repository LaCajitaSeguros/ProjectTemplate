using Application.Interfaces.VersionVehiculoInterfaces;
using Domain.Entities;

namespace Application.UseCase.VersionVehiculos
{
    public class VersionVehiculoService : IVersionVehiculoService
    {
        private readonly IVersionVehiculoQuery _query;

        public VersionVehiculoService(IVersionVehiculoQuery query)
        {
            _query = query;
        }

        public VersionVehiculo ObtenerVersion(int versionId, int modeloId)
        {
            return _query.ObtenerVersionPorId(versionId, modeloId);
        }
    }
}
