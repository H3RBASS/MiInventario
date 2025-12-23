namespace MiInventario.Pages;
public partial class Home
{
    public bool MostrarModal { get; set; }
    public string NombreProducto { get; set; } = string.Empty;
    public string PrecioProducto { get; set; } = string.Empty;
    public string CantidadProducto { get; set; } = string.Empty;
    private bool AlertaVentana {get; set;} = false;

    private void ejecutar ()
    {
        Guardar();
    }

    private void AbrirModal()
    {
        MostrarModal = true;
    }

    private void CerrarModal()
    {
        MostrarModal = false;
        NombreProducto = string.Empty;
        PrecioProducto = string.Empty;
        CantidadProducto = string.Empty;
    }

    private void Guardar()
    {
        if (string.IsNullOrWhiteSpace(NombreProducto) ||
            string.IsNullOrWhiteSpace(PrecioProducto) ||
            string.IsNullOrWhiteSpace(CantidadProducto))
        {
            AlertaVentana = true;
            // Manejar validación aquí (por ejemplo, mostrar un mensaje de error
            return;
        }
        // Guardar lógica aquí
        CerrarModal();
    }

}   

