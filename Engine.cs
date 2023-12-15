/// <summary>
/// Класс двигателя
/// </summary>
class Engine
{
    /// <summary>
    /// Модель двигателя
    /// </summary>
    public string Model { get; set; }
    /// <summary>
    /// Конструктор двигателя
    /// </summary>
    /// <param name="model">Модель</param>
    public Engine(string model = "EJ200")
    {
        Model = model;
    }
}

