
namespace SEGURA_ASSETMENTS.Models
{
    public class Sede
{
    public int ID_Sedes { get; set; }
    public string Tipo { get; set; }
    public string NombreSede { get; set; }
    public string Ciudad { get; set; }
    public int CapacidadSede { get; set; }
    public int NumHabitaciones { get; set; }
    public int ID_Habitacion { get; set; }
    public string ServiciosSede { get; set; }

    // Relaciones
    public Habitacion Habitacion { get; set; }
    public ICollection<Reserva> Reservas { get; set; }
}

}