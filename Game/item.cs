public class Item
{
    protected string name;
    protected string description;

    public Item(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public void Use()
    {
        
    }
}