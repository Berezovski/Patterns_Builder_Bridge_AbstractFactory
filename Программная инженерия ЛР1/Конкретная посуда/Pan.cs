using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    /// <summary>
    /// Сковородка, унаследована от Посуды.
    /// Может быть индукционной или нет.
    /// </summary>
    class Pan : Dish
    {
        /// <summary>
        /// Индукционная ли сковородка?
        /// </summary>
        public bool IsInduction { get; set; }

        /// <summary>
        /// Конструктор взятый с базового класса.
        /// По умолчанию не индукционная сковородка
        /// </summary>
        /// <param name="dishData"> Характеристики посуды </param>
        /// <param name="id"> Айди выпуска </param>
        /// <param name="count"> Количество посуды </param>
        public Pan(DishCharacteristics dishData, int id, int count) : base(dishData, id, count)
        {
            IsInduction = false;
        }
    }
}
