public class Direccion
{
    private string calle;
    private int altura;
    private int codigoPostal;

    public string getCalle()
    {
        return calle;
    }
    public void setCalle(string calle)
    {
        this.calle = calle;
    }

    public int getAltura ()
    {
        return altura;
    }

    public void setAltura (int altura)
    {
        this.altura = altura;
    }

    public Direccion(string calle, int altura , int codigoPostal)
    {
        this.calle=calle;
        this.altura=altura;
        this.codigoPostal=codigoPostal;
    }
}