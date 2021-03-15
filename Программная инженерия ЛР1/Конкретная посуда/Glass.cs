using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    /// <summary>
    /// Бокал, унаследован от Посуды.
    /// Может быть с ножкой или без.
    /// </summary>
    class Glass : Dish
    {
        /// <summary>
        /// С ножкой ли бокал?
        /// </summary>
        public bool HaveStem {get;set;}

        /// <summary>
        /// Конструктор взятый с базового класса.
        /// По умолчанию бокал с ножкой
        /// </summary>
        /// <param name="dishData"> Характеристики посуды </param>
        /// <param name="id"> Айди выпуска </param>
        /// <param name="count"> Количество посуды </param>
        public Glass(DishCharacteristics dishData, int id, int count) : base(dishData, id, count)
        {
            HaveStem = true;
        }
    }
}
