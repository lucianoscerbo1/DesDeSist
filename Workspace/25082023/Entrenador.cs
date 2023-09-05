public class Entrenador : Persona
{
    private Tactica tactica;


public Tactica getTactica()
{
    return tactica;
}
public void setTactica(Tactica tactica)
{
    this.tactica = tactica;
}
public Entrenador (string nombre, string apellido, Tactica tactica) : base (nombre, apellido) // base se utiliza para se usa para acceder a los miembros de la clase base desde una clase derivada.
	{
        this.tactica = tactica;    
	}

public override void presentar()
    {
        Console.WriteLine($"Mi nombre es {getNombre()} {getApellido()} y mi tactica es {getTactica()}");
    }
}