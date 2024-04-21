using Application.Interfaces.RangoEtarioInterfaces;
using Domain.Entities;

namespace Application.UseCase.RangosEtarios
{
    public class RangoEtarioService : IRangoEtarioService
    {
        private readonly IRangoEtarioQuery _query;

        public RangoEtarioService(IRangoEtarioQuery query)
        {
            _query = query;
        }

        public RangoEtario ObtenerRangoEtario(int edad)
        {
            return _query.ObtenerListaDeRangoEtario(edad);
        }
    }
}
