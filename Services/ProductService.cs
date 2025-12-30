using System.Collections.Generic;
using MiInventario.Modelos;

namespace MiInventario.Services
{
    public class ProductService
    {
        // Lista de productos de ejemplo
        private List<Product> ListaProductos { get; set; } = new List<Product>
        {
        };

        // Método para obtener todos los productos
        public List<Product> GetAllProducts()
        {
            ListaProductos.Count();
            return ListaProductos;
        }

        //metodo para contar todos los productos
        public int CountAllProducts()
        {
            return ListaProductos.Count;
        }
        //Metodo para agregar un nuevo producto
        public void AddProduct(Product nuevoProducto)
        {
            ListaProductos.Add(nuevoProducto);
        }
        public void CrearProducto(string nombre, string categoria, decimal precio, 
        int cantidad)
        {
             // Creamos un objeto Producto (producto real)
             Product NuevoProducto = new Product
            {
                Name = nombre,
                Category = categoria,
                Price = precio,
                Quantity = cantidad,
            };
            // Llamamos al servicio para guardar el producto en la lista
            AddProduct(NuevoProducto);
        }

        //Metodo para obtener el precio total de todos los productos
        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var producto in ListaProductos)
            {
                total += producto.Price ?? 0;
            }
            return total;
        }
        public decimal GetAveragePrice()
        {
            if (ListaProductos.Count == 0)
                return 0;

            int total = Convert.ToInt32(GetTotalPrice());
            return total / ListaProductos.Count;

        }
        public int GetOutStockCount()
        {
            int outOfStock = 0;
            foreach (var producto in ListaProductos)
            {
                if (producto.Quantity == 0)
                {
                    outOfStock++;
                }
            }
            return outOfStock;
        }
    }
}