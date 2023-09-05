public class Cliente
{
    private string nombre;
    private string apellido;
    private string idCliente;
    private Direccion direccion;

    public Cliente(string nombre, string apellido, string idCliente, Direccion direccion)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.idCliente = idCliente;
        this.direccion = direccion;
    }
}