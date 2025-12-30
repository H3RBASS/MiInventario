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
    public bool MostrarModal { get; set; }
    private bool AlertaVentana {get; set;} = false;

    private Product ProductosForm = new Product();

    //metodos
    protected void Guardar()
    {
           servicioProductos.CrearProducto(
            ProductosForm.Name,
            ProductosForm.Category,
            ProductosForm.Price!.Value,
            ProductosForm.Quantity
        );

        // Limpiamos el formulario
        LimpiarFormulario();
        CerrarModal();
    }

    private void AbrirModal()
    {
        LimpiarFormulario();
        MostrarModal = true;
    }

    private void CerrarModal()
    {
        LimpiarFormulario();
        MostrarModal = false;
    }

    private void LimpiarFormulario()
    {
        ProductosForm = new Product();
    }
}   
    


