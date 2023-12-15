/// <summary>
/// Класс самоёта
/// </summary>
class Plane
{
    /// <summary>
    /// Крылья самолёта
    /// </summary>
    List<Wing> wings;
    /// <summary>
    /// Шасси самолёта
    /// </summary>
    Сhassis chassis;
    /// <summary>
    /// Модель самолёта
    /// </summary>
    public string Model;
    public List<string> Destinations { get; set; }
    /// <summary>
    /// Конструктор самолёта
    /// </summary>
    /// <param name="model">Модель самолёта, значение по умолчанию Boeing 737</param>
    public Plane(string model = "Boeing 737")
    {
        Model = model;
        wings = new List<Wing>
            {
                new Wing(),
                new Wing()
            };
        chassis = new Сhassis();
        Destinations = new List<string> { };
    }
    /// <summary>
    /// Новый пункт назначения
    /// </summary>
    /// <param name="destination">Пункт назначения</param>
    public void NewDestination(string destination)
    {
        Destinations.Add(destination);
    }
    /// <summary>
    /// Летим в следующий пункт назначения
    /// </summary>
    public void Fly()
    {
        Console.WriteLine($"Flying to: {Destinations.First()}");
        Destinations.Remove(Destinations.First());
    }
    /// <summary>
    /// Следующий пункт назначения
    /// </summary>
    public void CurrentDestination()
    {
        Console.WriteLine($"Current destination: {Destinations.First()}");
    }
    /// <summary>
    /// Все пункты назначения
    /// </summary>
    public void PrintDestinations()
    {
        Console.WriteLine("Destinations:");
        Destinations.ForEach((value) => Console.WriteLine(value));
    }
}

