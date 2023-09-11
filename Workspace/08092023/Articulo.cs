public class Articulo
{
    private string nombre;
    private double precio;
    private bool enVenta;
    private Categoria categoria;
    private Condicion condicion;

    public string getNombre()
    {
        return nombre;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
     public double getPrecio()
    {
        return precio;
    }
    public void setPrecio(double  precio)
    {
        this.precio = precio;
    }
    public bool getEnVenta()
    {
        return enVenta;
    }
    public void setEnVenta(bool enVenta)
    {
        this.enVenta = enVenta;
    }
    public Categoria getCategoria()
    {
        return categoria;
    }
    public void setCategoria(Categoria categoria)
    {
        this.categoria = categoria;
    }
    public Condicion getCondicion ()
    {
        return condicion;
    }
    public void setCondicion (Condicion condicion)
    {
        this.condicion = condicion;
    }

    public Articulo (string nombre, double precio, bool enVenta, Categoria categoria, Condicion condicion)
    {
        this.nombre = nombre;
        this.precio=precio;
        this.enVenta= enVenta;
        this.categoria = categoria;
        this.condicion=condicion;
    }
}