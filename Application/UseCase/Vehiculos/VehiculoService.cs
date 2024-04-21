using Application.Interfaces.ObjetoInformacionParametrizadaInterfaces;
using Application.Interfaces.VehiculoInterfaces;
using Application.Models;
using Application.Response;
using Application.Util;
using Domain.Entities;

namespace Application.UseCase.Vehiculos
{
    public class VehiculoService : IVehiculoService
    {
        private readonly IVehiculosCommand _command;
        private readonly IObtenerInformacionParametrizada _informacionParametrizada;

        public VehiculoService(IVehiculosCommand command, IObtenerInformacionParametrizada informacionParametrizada)
        {
            _command = command;
            _informacionParametrizada = informacionParametrizada;
        }

        public async Task<VehiculoResponse> CrearVehiculo(CrearVehiculoRequest request)
        {
            var objetoParametrizado = _informacionParametrizada.ObtenerInformacion(request, new ObjetoParametrizado());
            
            if (objetoParametrizado.anioVehiculo == null || objetoParametrizado.rangoEtario == null 
                || objetoParametrizado.localidad == null || objetoParametrizado.version == null
                || objetoParametrizado.marca == null || objetoParametrizado.modelo == null) 
            {
                throw new BadRequestException("No se pudo cotizar el vehiculo. Por favor, revise los datos proporcionados.");
            }

            var vehiculo = new Vehiculo()
            {
                AnioVehiculo = request.Automovil.AnioVehiculo,
                MarcaId = request.Automovil.MarcaId,
                ModeloId = request.Automovil.ModeloId,
                VersionId = request.Automovil.VersionId        
            };

            await _command.InsertarVehiculo(vehiculo);

            return new VehiculoResponse
            { 
                cotizacion = CalculoCotizacion.CalcularCotizacion(objetoParametrizado)
            };
        }
    }
}
