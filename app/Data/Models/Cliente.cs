using SEGURA_ASSETMENTS.Models;
namespace SEGURA_ASSETMENTS.Models
{
    
public class Cliente
{
    public int ID_Clientes { get; set; }
    public string NombreCompleto { get; set; }
    public string Roll { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Celular { get; set; }
    public string Correo { get; set; }
    public int ID_Departamento { get; set; }
    public string Municipio { get; set; }
    public string Barrio { get; set; }
    public string Direccion { get; set; }
    public string PreguntaSecreta { get; set; }
    public string RespuestaSecreta { get; set; }
    public string AuthCorreo { get; set; }
    public string AuthCelular { get; set; }
    public string Contrasena { get; set; }

    // Relaciones
    public Departamento Departamento { get; set; }
}
}
