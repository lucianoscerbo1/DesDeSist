public class Direccion
{
  private string calle;
  private int altura;
  private string ciudad;

  public string getCalle()
    {
      return calle;
    }
  public void setCalle(string calle)
  {
    this.calle = calle;
  }
   public int getAltura()
    {
      return altura;
    }
     public void setAltura(int altura)
    {
      this.altura = altura;
    }
    public string getCiudad()
    {
      return ciudad;
    }
    public void setCiudad(string ciudad)
    {
      this.ciudad= ciudad;
    }
    
    public Direccion(string calle, int altura, string ciudad)
    {
        this.calle = calle;
        this.altura = altura;
        this.ciudad = ciudad;

    }
}