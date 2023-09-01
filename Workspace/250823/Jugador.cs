public class Jugador : Persona
{
    public int dorsal;

    public Jugador (string nombre, string apellido, int dorsal) : base (nombre, apellido) // base se utiliza para se usa para acceder a los miembros de la clase base desde una clase derivada.
	{ 
        this.dorsal = dorsal; 
	}

    public override presentar()
    {
        Console.WriteLine ("Hola soy: "+nombre+" "+ apellido+ " y mi dorsal es "+dorsal);
    }
}