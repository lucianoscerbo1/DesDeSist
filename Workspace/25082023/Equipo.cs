public class Equipo 
{
    public Categoria categoria;
    private Entrenador entrenador;
    private List<Jugador> listaJugadores;

    public Categoria getCategoria()
    {
        return categoria;
    }
    public void setCategoria(Categoria categoria)
    {
        this.categoria = categoria;
    }

    public Entrenador getEntrenador()
    {
        return entrenador;
    }
    public void setEntrenador(Entrenador entrenador)
    {
        this.entrenador = entrenador;
    }
    public List<Jugador> getListaJugadores()
    {
        return listaJugadores;
    }
    public void setListaJugadores(List<Jugador> listaJugadores)
    {
        this.listaJugadores = listaJugadores;
    }

    public Equipo(Categoria categoria, Entrenador entrenador, List<Jugador> listaJugadores)
    {
        this.categoria = categoria;
        this.entrenador = entrenador;
        this.listaJugadores = listaJugadores;
    }
    public void RemoverJugador(Jugador jugador)
    {
        listaJugadores.Remove(jugador);
    }
    public void AgregarJugador(Jugador jugador)
    {
        listaJugadores.Add(jugador);
    }
}