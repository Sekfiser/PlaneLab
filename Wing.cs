/// <summary>
/// Класс крыла для самолёта
/// </summary>
class Wing
{
    /// <summary>
    /// Тип крыла
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Тип двигателя
    /// </summary>
    public Engine Engine { get; set; }
    /// <summary>
    /// Конструктор крыла
    /// </summary>
    /// <param name="type">Тип крыла</param>
    public Wing(string type = "Swept wing")
    {
        Engine = new Engine();
        Type = type;
    }
}

