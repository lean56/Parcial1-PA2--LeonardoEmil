using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_PA2.Entidad
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        [Range(minimum:1,maximum:10000)]
        public float Costo { get; set; }
        public float Ganancia { get; set; }
        [Required]
        public float Precio { get; set; }

        public Producto()
        {
            ProductoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            Ganancia = 0;
            Precio = 0;
        }
    }
}
