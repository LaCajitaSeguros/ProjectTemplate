using Application.Interfaces.GNCInterfaces;
using Domain.Entities;

namespace Application.UseCase.GNCs
{
    public class GNCService : IGNCService
    {
        private readonly IGNCQuery _query;

        public GNCService(IGNCQuery query)
        {
            _query = query;
        }

        public GNC ObtenerObjetoGNC(bool tieneGnc)
        {
            return _query.ObtenerGNCPorBooleano(tieneGnc);
        }
    }
}
