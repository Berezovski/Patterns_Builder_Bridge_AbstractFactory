using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    /// <summary>
    /// Тарелка, унаследована от Посуды.
    /// Может быть одноразовой или нет.
    /// </summary>
    class Plate : Dish
    {
        /// <summary>
        /// Одноразовая ли тарелка?
        /// </summary>
        public bool IsSingleUse { get; set; }

        /// <summary>
        /// Конструктор взятый с базового класса.
        /// По умолчанию тарелка не одноразовая
        /// </summary>
        /// <param name="dishData"> Характеристики посуды </param>
        /// <param name="id"> Айди выпуска </param>
        /// <param name="count"> Количество посуды </param> 
        public Plate(DishCharacteristics dishData, int id, int count) : base(dishData, id, count)
        {
            IsSingleUse = false;
        }
    }
}
