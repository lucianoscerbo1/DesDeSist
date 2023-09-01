public class Club 
{
    private string nombre;
    private int anioFundacion;
    private Direccion direccion;
   // private Equipo equipo;
    private list <Empleado> listaEmpleados;
    private list <Equipo> listaEquipos;

    public Club(string nombre, int anioFundacion, Direccion direccion)
    {
        this.nombre = nombre;
        this.anioFundacion = anioFundacion;
        this.direccion = direccion; 
    }
}