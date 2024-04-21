using Domain.Entities;

namespace Application.Interfaces.AnioVehiculosInterfaces
{
    public interface IAnioVehiculoQuery
    {
        AnioVehiculo ObtenerVehiculo(int anioVehiculo);
    }
}
