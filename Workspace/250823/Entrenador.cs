public class Entrenador : Persona
{
    private Tactica tactica;


    public Entrenador (string nombre, string apellido, Tactica tactica) : base (nombre, apellido) // base se utiliza para se usa para acceder a los miembros de la clase base desde una clase derivada.
	{
        this.tactica = tactica;    
	}

   public override presentar()
    {
        Console.WriteLine ("Hola soy: "+nombre+" "+ apellido+ " y mi tactica es "+tactica);
    }
}