public abstract class Persona
{
    private string nombre;
    private string apellido;

    public string getNombre()
    {
        return nombre;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public string getApellido()
    {
        return apellido;
    }
    public void setApellido(string apellido)
    {
        this.apellido = apellido;
    }
    public Persona(string nombre, string apellido) 
    {
        this.nombre = nombre;   
        this.apellido = apellido;
    }

    public abstract void presentar();
}