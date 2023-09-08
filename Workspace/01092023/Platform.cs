public class Platform 
{
    private string name;
    private List <Application> listApp;
    private List <User> listUser;
    
    public string getName()
    {
        return name;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    public List <Application> getListApp()
    {
        return listApp;
    }
    public void setListApp(List <Application> listApp)
    {
        this.listApp = listApp;
    }
    public Platform(string name, List<Application> listApp, List<User> listUser)
    {
        this .name = name;
        this.listApp = listApp;
        this.listUser = listUser;
    }
}