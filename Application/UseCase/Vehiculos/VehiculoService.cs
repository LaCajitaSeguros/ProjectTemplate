using Application.Interfaces.Http;
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
        private readonly IHttpService _httpService;

        public VehiculoService(IVehiculosCommand command, IObtenerInformacionParametrizada informacionParametrizada, IHttpService httpService)
        {
            _command = command;
            _informacionParametrizada = informacionParametrizada;
            _httpService = httpService;
        }

        public async Task<List<PlanesResponse>> CotizarVehiculo(CrearVehiculoRequest request)
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

            var cotizacion = Convert.ToInt32(CalculoCotizacion.CalcularCotizacion(objetoParametrizado));

            var response = await _httpService.GetAsync<List<PlanesResponse>>($"https://localhost:7272/api/Planes/ListaPlanesCotizados?Cotizacion={cotizacion}");

            return response;
        }
    }
}
