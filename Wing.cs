
internal class Wing
{
    public string Type { get; set; }
    public Engine Engine { get; set; }

    public Wing(string type = "Swept wing")
    {
        Engine = new Engine();
        Type = type;
    }
}

