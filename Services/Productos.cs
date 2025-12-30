using System.ComponentModel.DataAnnotations;

namespace MiInventario.Modelos;
        // Clase Producto
        public class Product
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "El nombre es obligatorio")]
            public string Name { get; set; } = "";
            
            [Required(ErrorMessage = "La categoría es obligatoria")]
            public string Category { get; set; } = "";

            [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
            [Required(ErrorMessage = "El precio es obligatorio")]
            public decimal? Price { get; set; }

            [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser negativa")]
            public int Quantity { get; set; }
            public int MinStock { get; set; }
        }
