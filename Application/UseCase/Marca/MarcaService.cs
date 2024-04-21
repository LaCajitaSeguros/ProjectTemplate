using Application.Interfaces.MarcaInterfaces;
using Domain.Entities;

namespace Application.UseCase.Marca
{
    public class MarcaService : IMarcaService
    {
        private readonly IMarcaQuery _query;

        public MarcaService(IMarcaQuery query)
        {
            _query = query;
        }

        public Domain.Entities.Marca ObtenerValoresMarca(int marcaId)
        {
            return _query.ObtenerMarca(marcaId);
        }
    }
}
