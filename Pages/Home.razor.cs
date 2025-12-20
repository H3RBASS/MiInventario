namespace MiInventario.Pages;
public partial class Home
{
    public bool MostrarModal { get; set; }
    public string NombreProducto { get; set; } = string.Empty;
    public string PrecioProducto { get; set; } = string.Empty;
    public string CantidadProducto { get; set; } = string.Empty;

    private void AbrirModal()
    {
        MostrarModal = true;
    }

    private void CerrarModal()
    {
        MostrarModal = false;
        NombreProducto = string.Empty;
    }

    private void Guardar()
    {
        if (string.IsNullOrWhiteSpace(NombreProducto) ||
            string.IsNullOrWhiteSpace(PrecioProducto) ||
            string.IsNullOrWhiteSpace(CantidadProducto))
        {
            // Manejar validación aquí (por ejemplo, mostrar un mensaje de error)
            return;
        }
        // Guardar lógica aquí
        CerrarModal();
    }

}   

