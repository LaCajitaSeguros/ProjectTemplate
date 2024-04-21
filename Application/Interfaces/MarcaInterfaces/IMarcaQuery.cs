using Domain.Entities;

namespace Application.Interfaces.MarcaInterfaces
{
    public interface IMarcaQuery
    {
        Marca ObtenerMarca(int marcaId);
    }
}
