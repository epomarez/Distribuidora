
namespace Distribuidora.Entidades
{
    public class Cajero : Persona
    {
        public DateTime FechaIngreso { get; private set; }

        public Cajero(int id, string identificacion, string nombreCompleto,
            DateTime fechaNacimiento, DateTime fechaIngreso) : base(id, identificacion, nombreCompleto, fechaNacimiento)
        {
            this.FechaIngreso = fechaIngreso;
        }

        // Polimorfismo
        public override string ObtenerRolDetallado()
        {
            return $"Cajero ingresado el {FechaIngreso.ToShortDateString()}";
        }
    }
}