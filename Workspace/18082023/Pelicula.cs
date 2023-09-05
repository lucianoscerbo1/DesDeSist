public class Pelicula 
{
    private string titulo;
    private int duracion;
    private Genero genero;
    public Pelicula(string titulo, int duracion, Genero genero)
    {
        this.titulo = titulo;
        this.duracion = duracion;
        this.genero = genero;
    }
}