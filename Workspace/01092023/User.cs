public class User 
{
    private string name;
    private int age;
    private double accountBalance;
    private List<Application> listApp;

    public string getName()
    {
        return name;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    public int getAge()
    {
        return age;
    }
    public void  setAge(int age)
    {
        this.age = age;
    }

    public double getAccountBalance()
    {
        return accountBalance;
    }
    public void  setAccountBalance(double accountBalance)
    {
        this.accountBalance = accountBalance;
    }
    public List<Application> getListApp()
    {
        return listApp;
    }
    public void setListApp(List<Application> listApp)
    {
        this.listApp = listApp;
    }

    public User(string name, int age, double accountBalance, List<Application> listApp)
    {
        this.name = name;
        this.age = age;
        this.accountBalance = accountBalance;
        this.listApp = listApp;
    }
}