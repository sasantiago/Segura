
namespace SEGURA_ASSETMENTS.Models
{
    public class Departamento
    {
        public int ID_Departamento { get; set; }
        public string? NombreDepartamento { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }

}