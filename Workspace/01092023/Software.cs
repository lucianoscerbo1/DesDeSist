public class Software : Application
{
    private  SoftwareCategory softwareCategory;

    public SoftwareCategory getSoftwareCategory()
    {
        return softwareCategory;
    }
    public void setSoftwareCategory(SoftwareCategory softwareCategory)
    {
        this.softwareCategory = softwareCategory;
    }

    public Software (string name, double price, bool earlyAcces, double rating, List<Review> listReview, SoftwareCategory softwareCategory) : base (name, price,earlyAcces, rating, listReview)
    {
        this.softwareCategory = softwareCategory;
    }
}