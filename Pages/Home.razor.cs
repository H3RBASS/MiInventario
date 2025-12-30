namespace MiInventario.Pages;
using System.Collections.Generic;
using MiInventario.Modelos;
using MiInventario.Services;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;

public partial class Home
{
    // Inyectamos el servicio de productos
    [Inject]
    private ProductService servicioProductos { get; set; } = default!;

    //variable para controlar la visibilidad del modal
    private string NombreProducto = "";
    private decimal? PrecioProducto;
    private int? CantidadProducto;
    private string CategoriaProducto = "";
    private int? StockProducto;
    public bool MostrarModal { get; set; }
    private bool AlertaVentana {get; set;} = false;
    private bool ValueNull = false;

    private Product ProductosForm = new Product();

    //metodos
    private void CrearProducto()
    {
       servicioProductos.CrearProducto(
       NombreProducto, 
       CategoriaProducto, 
       PrecioProducto.Value, 
       CantidadProducto.Value, 
       StockProducto.Value);

    }
    protected void Guardar()
        {
            if (PrecioProducto == null || CantidadProducto == null || StockProducto == null)
                {
                    AlertaVentana = true;
                    return;
                }
                    CrearProducto();
                    CerrarModal();
                    limpiarCampos();
                    Console.WriteLine(NombreProducto + PrecioProducto);              
        }
    private void limpiarCampos()
    {
        NombreProducto = "";
        CategoriaProducto = "";
        PrecioProducto = null;
        CantidadProducto = null;
        StockProducto = null;
    }
    private void AbrirModal()
        {
            MostrarModal = true;
        }

    private void CerrarModal()
        {
            limpiarCampos();
            MostrarModal = false;
            AlertaVentana = false;
        }

        
}   
    


