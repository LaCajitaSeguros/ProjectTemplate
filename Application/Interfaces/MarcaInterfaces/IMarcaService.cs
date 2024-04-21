using Domain.Entities;

namespace Application.Interfaces.MarcaInterfaces
{
    public interface IMarcaService
    {
        public Marca ObtenerValoresMarca(int marcaId);
    }
}
