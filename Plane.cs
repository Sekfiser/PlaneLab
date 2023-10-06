internal class Plane
{
    List<Wing> wings;
    Сhassis chassis;
    public string Model;
    public List<string> Destinations { get; set; }
    public Plane(string model = "Boeing 737")
    {
        wings = new List<Wing>
            {
                new Wing(),
                new Wing()
            };
        chassis = new Сhassis();
        Destinations = new List<string> { };
    }

    public void NewDestination(string destination)
    {
        Destinations.Add(destination);
    }

    public void Fly()
    {
        Console.WriteLine($"Flying to: {Destinations.First()}");
        Destinations.Remove(Destinations.First());
    }

    public void CurrentDestination()
    {
        Console.WriteLine($"Current destination: {Destinations.First()}");
    }
}

