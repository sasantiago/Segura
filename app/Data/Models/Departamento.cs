
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SEGURA_ASSETMENTS.Models
{
    public class Departamento
    {
        [Key]
        public int ID_Departamento { get; set; }
        public string? NombreDepartamento { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }

}