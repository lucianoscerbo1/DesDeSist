public abstract class Persona
{
    private string nombre;
    private string apellido;

    public string presentar()
    {
        return "Hola soy " + nombre + apellido ;
    }
}