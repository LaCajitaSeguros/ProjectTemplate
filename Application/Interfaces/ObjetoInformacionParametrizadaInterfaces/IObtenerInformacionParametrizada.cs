using Application.Models;

namespace Application.Interfaces.ObjetoInformacionParametrizadaInterfaces
{
    public interface IObtenerInformacionParametrizada
    {
        ObjetoParametrizado ObtenerInformacion(CrearVehiculoRequest request, ObjetoParametrizado objetoParametrizado);
    }
}
