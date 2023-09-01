public class Empleado : Persona
{
    private string funcion;

    public Empleado (string nombre, string apellido, string funcion) : base (nombre, apellido) // base se utiliza para se usa para acceder a los miembros de la clase base desde una clase derivada.
	{
        
        this.funcion = funcion;
        
	}

    public override presentar()
    {
        Console.WriteLine ("Hola soy: "+nombre+" "+ apellido+ " y mi funcion es "+funcion);
    }
}