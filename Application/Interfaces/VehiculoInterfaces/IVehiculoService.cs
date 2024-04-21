using Application.Models;
using Application.Response;
using Domain.Entities;

namespace Application.Interfaces.VehiculoInterfaces
{
    public interface IVehiculoService
    {
        public Task<VehiculoResponse> CrearVehiculo(CrearVehiculoRequest request);
    }
}
