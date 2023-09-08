public class Review 
{
    private User author;
    private string title;
    private string text;
    private bool isPositive;
    private Date date;

    public User getUser()
    {
        return author;
    }
    public void setUser(User author)
    {
        this.author = author;
    }

    public string getTitle()
    {
        return title;
    }
    public void setTitle(string title) 
    {
        this.title = title;
    }
    public string getText()
    {
        return text;
    }
    public void setText(string text)
    {
        this.text = text;
    }
    public bool getPositive()
    {
        return isPositive;
    }
    public void setPositive(bool isPositive)
    {
        this.isPositive = isPositive;
    }
    
    public Date getDate()
    {
        return date;
    }
    public void setDate(Date date)
    {
        this.date = date;
    }

    public Review(User author, string title, string text, bool isPositive, Date date)
    {
        this.author = author;
        this.title=title;
        this.text=text;
        this.isPositive=isPositive;
        this.date=date;
    }
}