using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class LocalidadConfiguracion : IEntityTypeConfiguration<Localidad>
    {
        public void Configure(EntityTypeBuilder<Localidad> builder)
        {
            builder.HasData(
                new Localidad { LocalidadId = 1, Nombre = "Varela", Peso = "0.0005" },
                new Localidad { LocalidadId = 2, Nombre = "Berazategui", Peso = "0.0005" },
                new Localidad { LocalidadId = 3, Nombre = "Lanus", Peso = "0.0005" },
                new Localidad { LocalidadId = 4, Nombre = "Quilmes", Peso = "0.0006" },
                new Localidad { LocalidadId = 5, Nombre = "Avellaneda", Peso = "0.0003" },
                new Localidad { LocalidadId = 6, Nombre = "Lomas de Zamora", Peso = "0.0002" }
                );
        }
    }
}
