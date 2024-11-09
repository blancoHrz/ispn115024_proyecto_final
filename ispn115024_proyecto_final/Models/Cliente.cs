using System.ComponentModel.DataAnnotations;

namespace ispn115024_proyecto_final.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }

        public string nombre { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public string documento { get; set; }
    }
}
