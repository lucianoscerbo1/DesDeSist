public abstract class Persona
{
    private string nombre;
    private string apellido;

    public Persona(string nombre, string apellido) 
    {
        this.nombre = nombre;   
        this.apellido = apellido;
    }

    public string presentar()
    {
        Console.WriteLine("Hola soy" + nombre + " "+ apellido);
    }
}