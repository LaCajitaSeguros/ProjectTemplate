using Application.Interfaces.ModeloInterfaces;
using Domain.Entities;

namespace Application.UseCase.Modelo
{
    public class ModeloService : IModeloService
    {
        private readonly IModeloQuery _query;

        public ModeloService(IModeloQuery query)
        {
            _query = query;
        }

        public Domain.Entities.Modelo ObtenerValoresModelos(int modeloId, int marcaId)
        {
            return _query.ObtenerModelo(modeloId, marcaId);
        }
    }
}
