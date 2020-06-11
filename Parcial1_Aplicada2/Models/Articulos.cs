using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Aplicada2.Models
{
    public class Articulos
    {
        [Key]
        [Required(ErrorMessage = "No debe de estar Vacío el campo 'ArticuloId'")]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Descripción'")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Existencia'")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Costo'")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Valor de Inventario'")]
        public decimal ValorInventario { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            ValorInventario = 0;
        }

        public Articulos(int articuloId, string descripcion, int existencia, decimal costo, decimal valorInventario)
        {
            ArticuloId = articuloId;
            Descripcion = descripcion;
            Existencia = existencia;
            Costo = costo;
            ValorInventario = valorInventario;
        }
    }
}
