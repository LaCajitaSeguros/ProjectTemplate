using Domain.Entities;

namespace Application.Interfaces.ModeloInterfaces
{
    public interface IModeloQuery
    {
        Modelo ObtenerModelo(int modeloId, int marcaId);
    }
}
