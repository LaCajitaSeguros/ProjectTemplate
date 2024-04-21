using Application.Interfaces.AnioVehiculosInterfaces;
using Domain.Entities;

namespace Application.UseCase.AnioVehiculos
{
    public class AnioVehiculoService : IAnioVehiculoService
    {
        private readonly IAnioVehiculoQuery _query;

        public AnioVehiculoService(IAnioVehiculoQuery query)
        {
            _query = query;
        }

        public AnioVehiculo ObtenerValoresAnioVehiculo(int anioVehiculo)
        {
            return _query.ObtenerVehiculo(anioVehiculo);
        }
    }
}
