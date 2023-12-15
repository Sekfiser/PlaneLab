/// <summary>
/// Класс шасси
/// </summary>
class Сhassis
{
    /// <summary>
    /// Тип шасси
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Конструктор шасси
    /// </summary>
    /// <param name="type">Тип шасси</param>
    public Сhassis(string type = "Three-post chassis")
    {
        Type = type;
    }
}

