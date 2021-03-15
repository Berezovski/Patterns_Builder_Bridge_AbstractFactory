using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    /// <summary>
    /// Строитель посуды, над которым будет стоять директор,
    /// тут можно создать свою посуду со своими характеристиками.
    /// Реализован паттерн "мост" через переменную _dishData.
    /// Реализован паттерн "строитель".
    /// </summary>
    class DishBuilder : IDishBuilder
    {
        private DishCharacteristics _dishData;

        /// <summary>
        /// Задаёт начальные характеристики (по нулям)
        /// </summary>
        public DishBuilder()
        {
            _dishData = new DishCharacteristics();
        }

        /// <summary>
        /// Строитель создаёт вместимость
        /// </summary>
        /// <param name="capacity"> вместимость </param>
        public void setCapacity(int capacity)
        {
            _dishData.capacity = capacity;
        }

        /// <summary>
        /// Строитель создаёт цвет
        /// </summary>
        /// <param name="color"> цвет </param>
        public void setColor(string color)
        {
            _dishData.color = color;
        }

        /// <summary>
        /// Строитель создаёт материал
        /// </summary>
        /// <param name="material"> материал </param>
        public void setMaterial(string material)
        {
            _dishData.material = material;
        }

        /// <summary>
        /// Строитель задаёт цену
        /// </summary>
        /// <param name="price"> цена </param>
        public void setPrice(int price)
        {
            _dishData.price = price;
        }

        /// <summary>
        /// Возвращаёт заданные характеристики
        /// </summary>
        /// <returns> заданные характеристики </returns>
        public DishCharacteristics GetDishCharacteristics()
        {
            return _dishData;
        }

    }
}
