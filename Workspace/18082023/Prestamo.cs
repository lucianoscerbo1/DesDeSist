public class Prestamo
{
    private int cantDias;
    private Cliente cliente;
    private Fecha fecha;
    private Pelicula pelicula;

    public Prestamo(int cantDias, Cliente cliente, Fecha fecha, Pelicula pelicula)
    {
        this.cantDias = cantDias;
        this.cliente = cliente;
        this.fecha = fecha;
        this.pelicula = pelicula;
    }
}