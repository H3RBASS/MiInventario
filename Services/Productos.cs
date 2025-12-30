using System.ComponentModel.DataAnnotations;

namespace MiInventario.Modelos;
        // Clase Producto
        public class Product
        {
            public int Id { get; set; }
            [Required(ErrorMessage = "El nombre es obligatorio")]
            public string Name { get; set; } = "";
            public string Category { get; set; } = "";
            [Required(ErrorMessage = "El precio es obligatorio")]
            public decimal Price { get; set; }
            [Required(ErrorMessage = "La cantidad es obligatoria")]
            public int Quantity { get; set; }
            public int MinStock { get; set; }
        }
