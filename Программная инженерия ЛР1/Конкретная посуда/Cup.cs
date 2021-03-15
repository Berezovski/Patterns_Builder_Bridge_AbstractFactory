using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    /// <summary>
    /// Чашка, унаследована от Посуды.
    /// Может быть с ручкой или без.
    /// </summary>
    class Cup : Dish
    {
        /// <summary>
        /// Чашка с ручкой ли?
        /// </summary>
        public bool HaveHandle { get; set; }

        /// <summary>
        /// Конструктор взятый с базового класса.
        /// По умолчанию Чашка с ручкой.
        /// </summary>
        /// <param name="dishData"> Характеристики посуды </param>
        /// <param name="id"> Айди выпуска </param>
        /// <param name="count"> Количество посуды </param>
        public Cup(DishCharacteristics dishData, int id, int count) : base(dishData, id, count)
        {
            HaveHandle = true;
        }
    }
}
