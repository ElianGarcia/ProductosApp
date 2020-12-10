using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosApp.Models
{
    public class Productos
    {
        [Key]
        [Range(0, 1000000, ErrorMessage = "El campo Id no puede ser menor que cero ni mayor a 1000000.")]
        [Required(ErrorMessage = "El campo Id debe ser un numero.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "La descripción no puede estar vacía.")]
        [MinLength(3, ErrorMessage = "La descripción es muy corta.")]
        [MaxLength(50, ErrorMessage = "La descripción es muy larga.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio debe ser un numero.")]
        [Range(1, 1000000000, ErrorMessage = "El precio debe ser mayor que cero.")]
        public decimal Precio { get; set; }
       
        [Required(ErrorMessage = "La cantidad en inventario debe ser un numero.")]
        [Range(0, 1000000, ErrorMessage = "La cantidad en inventario no puede ser menor que cero ni mayor a 1000000.")]
        public int Inventario { get; set; }

        public Productos()
        {
            Codigo = 0;
            Descripcion = string.Empty;
            Precio = 0;
            Inventario = 0;
        }

        public Productos(int codigo, string descripcion, decimal precio, int inventario)
        {
            Codigo = codigo;
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            Precio = precio;
            Inventario = inventario;
        }
    }
}
