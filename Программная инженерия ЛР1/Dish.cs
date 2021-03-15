using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    /// <summary>
    /// Класс всей посуды. Паттерн "мост" реализован
    /// переменную _dishdata со структурой DishCharacteristics
    /// </summary>
    public class Dish : IDish
    {
        protected int _id { get; set; }
        protected int _count { get; set; }
        protected DishCharacteristics _dishData { get; set; }

        /// <summary>
        /// Задаёт характеристики, айди выпуска, количество товара
        /// </summary>
        /// <param name="dishData"> характеристики </param>
        /// <param name="id"> айди выпуска </param>
        /// <param name="count"> количество товара </param>
        public Dish(DishCharacteristics dishData, int id, int count)
        {
            _dishData = dishData;
            _id = id;
            _count = count;
        }
        
        /// <summary>
        /// Посмотреть характеристики
        /// </summary>
        /// <returns> Характеристики </returns>
        public DishCharacteristics GetDishCharacteristics()
        {
            return _dishData;
        }

        /// <summary>
        /// Посмотреть количетсво товара
        /// </summary>
        /// <returns> количетсво товара </returns>
        public int GetDishCount()
        {
            return _count;
        }

        /// <summary>
        /// Посмотреть айди выпуска
        /// </summary>
        /// <returns> айди выпуска </returns>
        public int GetDishId()
        {
            return _id;
        }

    }
}
