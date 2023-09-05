public class Club 
{
    private string nombre;
    private int anioFundacion;
    private Direccion direccion;
   // private Equipo equipo;
    private List <Empleado> listaEmpleados;
    private List <Equipo> listaEquipos;

    public string getNombre()
    {
        return nombre;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public int getAnioFund()
    {
        return anioFundacion;
    }
    public void setAnioFund(int anioFundacion)
    {
        this.anioFundacion = anioFundacion;
    }
    public Direccion getDireccion()
    {
        return direccion;
    }
    public void setDireccion( Direccion direccion)
    {
        this.direccion = direccion;
    }
    public List <Empleado> getListaEmpleados()
    {
        return listaEmpleados;
    }
    public void setListaEmpleados(List<Empleado> listaEmpleados)
    {
        this.listaEmpleados = listaEmpleados;
    }

    public void removerEquipo(Equipo equipo)
    {
        listaEquipos.Remove(equipo);
    }
    public void AgregarEquipo(Equipo equipo)
    {
        listaEquipos.Add(equipo);
    }

    public void removerEmpleado(Empleado empleado)
    {
        listaEmpleados.Remove(empleado);
    }
    public void AgregarEmpleado(Empleado empleado)
    {
        listaEmpleados.Add(empleado);
    }

    public Club(string nombre, int anioFundacion, Direccion direccion,List <Empleado> listaEmpleados,List <Equipo> listaEquipos )
    {
        this.nombre = nombre;
        this.anioFundacion = anioFundacion;
        this.direccion = direccion; 
        this.listaEmpleados = listaEmpleados;
        this.listaEquipos = listaEquipos;
    }
}