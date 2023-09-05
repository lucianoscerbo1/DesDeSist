public class Empleado : Persona
{
    private string funcion;

    public string getFuncion()
    {
        return funcion;
    }
    public void setFuncion(string funcion)
    {
        this.funcion = funcion;
    }
    public Empleado (string nombre, string apellido, string funcion) : base (nombre, apellido) // base se utiliza para se usa para acceder a los miembros de la clase base desde una clase derivada.
	{
        
        this.funcion = funcion;
        
	}

    public override void presentar()
    {
        Console.WriteLine($"Mi nombre es {getNombre()} {getApellido()} y mi funcion es {getFuncion()}");
    }
}