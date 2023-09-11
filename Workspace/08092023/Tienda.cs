public class Tienda 
{
    private string nombre;
    private Direccion direccion;
    private List<Articulo> listArticulos;

    public string getNombre()
    {
        return nombre;
    }
    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public Direccion getDireccion()
    {
        return direccion;
    }
    public void setDireccion(Direccion direccion)
    {
        this.direccion=direccion;
    }
    public List<Articulo> getListArticulos()
    {
        return listArticulos;
    }
    public void setListArticulos (List<Articulo> listArticulos)
    {
        this.listArticulos=listArticulos;
    }
    public Tienda (string nombre , Direccion direccion , List<Articulo> listArticulos)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.listArticulos = listArticulos;

    }
    public void AgregarArticulo(Articulo articulo)
    {
        listArticulos.Add(articulo);
        Console.WriteLine("Se agrego: " + articulo.getNombre());
    }

    public void RemoverArticulo(string nombre)
    {
        for (int i = 0; i < listArticulos.Count; i++) //primero recorro la lista
        {
            if (listArticulos.ElementAt(i).getNombre() == nombre) //realizo una condicion
        {
            Console.WriteLine("El articulo: "+ listArticulos.ElementAt(i).getNombre() + " ha sido eliminado");
            listArticulos.RemoveAt(i);
        }
    }
    }

    public Articulo? buscarArticulo(string nombre)
    {
        int i = 0; //variable de control para while
        while (i < listArticulos.Count)
        {
            Articulo articulo = listArticulos.ElementAt(i);
            
            if (articulo.getNombre() == nombre && articulo.getEnVenta() == true)
            {
                Console.WriteLine("El articulo fue encontrado: " +articulo.getNombre() +", $" + articulo.getPrecio() + ", " +articulo.getCategoria() + ", " +articulo.getCondicion());
                return articulo; //si se encuentra devuelve articulo
            }
            i++;
        }
        Console.WriteLine("El articulo "+ nombre + " no fue encontrado o no esta a la venta");
        return null; //si no se encuentra devuelve null  (Possible null reference return) 
    }
}