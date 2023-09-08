public class Application
{
    private string name;
    private double price;
    private bool earlyAcces;
    private double rating;
    private List <Review> listReview;

    public string getName()
    {
        return name;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public double Price()
    {
        return price;
    }
    public void  setPrice(double price)
    {
        this.price = price;
    }
    public bool geatEarlyAcces()
    {
        return earlyAcces;
    }
    public void setEarlyAcess(bool earlyAcces)
    {
        this.earlyAcces = earlyAcces;
    }
    public double getRating()
    {
        return rating;
    }
    public void  setRating(double rating)
    {
        this.rating = rating;
    }
    public List <Review> getListReview()
    {
        return listReview;
    }
   public void  setListReview(List<Review> listReview)
    {
       this.listReview = listReview;
    }

    public Application (string name, double price, bool earlyAcces, double rating, List<Review> listReview)
    {
        this.name = name;
        this.price =price;
        this.earlyAcces = earlyAcces;
        this.rating =rating;
        this.listReview =listReview;
    }

}

