public class Jugador : Persona
{
    private int dorsal;

    public int getDorsal()
    {
        return dorsal;
    }
    public void setDorsal(int dorsal)
    {
        this.dorsal = dorsal;
    }
    public Jugador (string nombre, string apellido, int dorsal) : base (nombre, apellido) // base se utiliza para se usa para acceder a los miembros de la clase base desde una clase derivada.
	{ 
        this.dorsal = dorsal; 
	}

    public override void presentar()
    {
        Console.WriteLine($"Mi nombre es {getNombre()} {getApellido()} y mi dorsal es {getDorsal()}");
    }
}