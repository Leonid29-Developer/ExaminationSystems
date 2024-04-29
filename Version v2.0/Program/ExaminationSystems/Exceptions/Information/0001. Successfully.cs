using System;

namespace ExaminationSystems.Exceptions.Information
{
    /// <summary> Класс-сообщение «Успешно» </summary>
    public class Successfully : Exception
    {
        public Successfully() : base($"Успешно")
            => Data.Add("Say", "Результат");
    }
}