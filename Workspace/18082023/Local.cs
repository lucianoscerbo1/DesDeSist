public class Local
{
    private Direccion direccion;
    private list <Cliente> listaClientes;
    private list <Prestamo> listaPrestamo;
    private list <Pelicula> listaPeliculas;

    public Local(Direccion direccion, list<Cliente> listaClientes, list<Prestamo> listaPrestamo, list<Pelicula> listaPeliculas)
    {
        this.direccion = direccion;
        this.listaClientes = listaClientes;
        this.listaPrestamo = listaPrestamo;
        this.listaPeliculas = listaPeliculas;
    }
}