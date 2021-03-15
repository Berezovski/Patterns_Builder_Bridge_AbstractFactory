using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    /// <summary>
    /// Структура посудных характеристик
    /// </summary>
    public struct DishCharacteristics : IDishCharacteristics
    {
        public string color { get; set; }
        public string material { get; set; }
        public int capacity { get; set; }
        public int price { get; set; }
    }
}
