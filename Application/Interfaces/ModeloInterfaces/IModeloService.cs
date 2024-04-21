using Domain.Entities;

namespace Application.Interfaces.ModeloInterfaces
{
    public interface IModeloService
    {
        Modelo ObtenerValoresModelos(int modeloId, int marcaId);
    }
}
