using System.Runtime.CompilerServices;

public class Game : Application 
{
    private int minimumAge;
    private GameCategory gameCategory;

    public int getMinimunAge()
    {
        return minimumAge;
    }
    public void setMinimunAge(int minimumAge)
    {
        this.minimumAge = minimumAge;
    }
    public GameCategory getGameCategory ()
    {
        return gameCategory;
    }
    public void setGameCategory (GameCategory gameCategory)
    {
        this.gameCategory = gameCategory;
    } 
    public Game (string name, double price, bool earlyAcces, double rating, List<Review> listReview, int minimumAge,GameCategory gameCategory) : base (name, price,earlyAcces, rating, listReview)
    {
        this.minimumAge = minimumAge;
        this.gameCategory = gameCategory;
    }


}