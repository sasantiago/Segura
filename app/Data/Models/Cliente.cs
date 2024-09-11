using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using SEGURA_ASSETMENTS.Models;


namespace SEGURA_ASSETMENTS.Models
{
    
public class Cliente:IdentityUser
{
    [Key]
    public int clientes_id { get; set; }
    public string customer_NombreCompleto { get; set; }
    public string Roll { get; set; }
    public DateTime customer_fechaNacimiento { get; set; }
    public string Celular { get; set; }
    public string Correo { get; set; }
    public int Id_Departamento { get; set; }
    public string Municipio { get; set; }
    public string Barrio { get; set; }
    public string Direccion { get; set; }
    public string Pregunta_Secreta { get; set; }
    public string Respuesta_Secreta { get; set; }
    public string Auth_Correo { get; set; }
    public string Auth_Celular { get; set; }
    public string Contrasena { get; set; }

    // Relaciones
     public Departamento? Departamento { get; set; }
}
}
