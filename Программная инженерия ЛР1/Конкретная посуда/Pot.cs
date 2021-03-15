using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    /// <summary>
    /// Кастрюля, унаследована от Посуды.
    /// Может быть антипригарным покрытием или нет.
    /// </summary>
    class Pot : Dish
    {
        /// <summary>
        /// С антипригарным покрытием ли
        /// </summary>
        public bool HaveNonStickCoating{ get; set; }

        /// <summary>
        /// Конструктор взятый с базового класса.
        /// По умолчанию кастрюля с антиприкарным покрытием
        /// </summary>
        /// <param name="dishData"> Характеристики посуды </param>
        /// <param name="id"> Айди выпуска </param>
        /// <param name="count"> Количество посуды </param>
        public Pot(DishCharacteristics dishData, int id, int count) : base(dishData, id, count)
        {
            HaveNonStickCoating = true;
        }
    }
}
