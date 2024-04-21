using Application.Interfaces.AnioVehiculosInterfaces;
using Application.Interfaces.GNCInterfaces;
using Application.Interfaces.LocalidadInterfaces;
using Application.Interfaces.MarcaInterfaces;
using Application.Interfaces.ModeloInterfaces;
using Application.Interfaces.ObjetoInformacionParametrizadaInterfaces;
using Application.Interfaces.RangoEtarioInterfaces;
using Application.Interfaces.VersionVehiculoInterfaces;
using Application.Models;

namespace Application.Util
{
    public class ObtenerInformacionParametrizada : IObtenerInformacionParametrizada
    {

        private readonly IAnioVehiculoService _anioVehiculoService;
        private readonly IGNCService _gncService;
        private readonly ILocalidadService _localidadService;
        private readonly IRangoEtarioService _rangoEtarioService;
        private readonly IVersionVehiculoService _versionVehiculoService;
        private readonly IMarcaService _marcaService;
        private readonly IModeloService _modeloService;

        public ObtenerInformacionParametrizada(IAnioVehiculoService anioVehiculoService, IGNCService gncService, 
            ILocalidadService localidadService, IRangoEtarioService rangoEtarioService,
            IVersionVehiculoService versionVehiculoService, IMarcaService marcaService, IModeloService modeloService)
        {
            _marcaService = marcaService;
            _modeloService = modeloService;
            _anioVehiculoService = anioVehiculoService;
            _gncService = gncService;
            _localidadService = localidadService;
            _rangoEtarioService = rangoEtarioService;
            _versionVehiculoService = versionVehiculoService;
        }

        public ObjetoParametrizado ObtenerInformacion(CrearVehiculoRequest request, ObjetoParametrizado objetoParametrizado) 
        {
            objetoParametrizado.anioVehiculo = _anioVehiculoService.ObtenerValoresAnioVehiculo(request.Automovil.AnioVehiculo);
            objetoParametrizado.gnc = _gncService.ObtenerObjetoGNC(request.Automovil.GNC);
            objetoParametrizado.localidad = _localidadService.ObtenerLocalidad(request.Localidad);
            objetoParametrizado.rangoEtario = _rangoEtarioService.ObtenerRangoEtario(request.Edad);
            objetoParametrizado.marca = _marcaService.ObtenerValoresMarca(request.Automovil.MarcaId);
            objetoParametrizado.modelo = _modeloService.ObtenerValoresModelos(request.Automovil.ModeloId, request.Automovil.MarcaId);
            objetoParametrizado.version = _versionVehiculoService.ObtenerVersion(request.Automovil.VersionId, request.Automovil.ModeloId);

            return objetoParametrizado;
        }
        
    }
}
