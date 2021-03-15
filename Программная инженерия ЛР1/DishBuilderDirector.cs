using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    /// <summary>
    /// Директор строителя, тут уже готовые продукты
    /// последовательно построенные через паттерн "строитель".
    /// Директор также следит за id выпуска продуктов.
    /// </summary>
    class DishBuilderDirector
    {
        private int _lastId;
        
        /// <summary>
        /// Задаём начальный айди для партии продуктов
        /// </summary>
        public DishBuilderDirector()
        {
            _lastId = 0;
        }

        /// <summary>
        /// Создаёт маленькие керамические чашки
        /// </summary>
        /// <param name="count"> Количество посуды </param>
        /// <returns> Посуду </returns>
        public Dish CreateWhiteSmallCeramicCup(int count)
        {
            Dish answer;

            DishBuilder dishBuilder = new DishBuilder();
            dishBuilder.setCapacity(3);
            dishBuilder.setColor("white");
            dishBuilder.setMaterial("ceramic");
            dishBuilder.setPrice(40);

            answer = new Cup(dishBuilder.GetDishCharacteristics(), _lastId, count);
            _lastId++;
            return answer;
        }

        /// <summary>
        /// Создаёт алюминивые кастрюли
        /// </summary>
        /// <param name="count"> Количество посуды </param>
        /// <returns> Посуду </returns>
        public Dish CreateWhiteBigAluminumPot(int count)
        {
            Dish answer;

            DishBuilder dishBuilder = new DishBuilder();
            dishBuilder.setCapacity(20);
            dishBuilder.setColor("white");
            dishBuilder.setMaterial("aluminum");
            dishBuilder.setPrice(100);

            answer = new Pot(dishBuilder.GetDishCharacteristics(), _lastId, count);
            _lastId++;

            return answer;
        }

        /// <summary>
        /// Создаёт железные сковородки
        /// </summary>
        /// <param name="count"> Количество посуды </param>
        /// <returns> Посуду </returns>
        public Dish CreateBlackBigIronPan(int count)
        {
            Dish answer;

            DishBuilder dishBuilder = new DishBuilder();
            dishBuilder.setCapacity(10);
            dishBuilder.setColor("black");
            dishBuilder.setMaterial("iron");
            dishBuilder.setPrice(70);

            answer = new Pan(dishBuilder.GetDishCharacteristics(), _lastId, count);
            _lastId++;

            return answer;
        }

        /// <summary>
        /// Создаёт стеклянные тарелки
        /// </summary>
        /// <param name="count"> Количество посуды </param>
        /// <returns> Посуду </returns>
        public Dish CreateBlackSmallGlassPlate(int count)
        {
            Dish answer;

            DishBuilder dishBuilder = new DishBuilder();
            dishBuilder.setCapacity(3);
            dishBuilder.setColor("black");
            dishBuilder.setMaterial("glass");
            dishBuilder.setPrice(60);

            answer = new Plate(dishBuilder.GetDishCharacteristics(), _lastId, count);
            _lastId++;

            return answer;
        }

        /// <summary>
        /// Создаёт пластиковые бокалы
        /// </summary>
        /// <param name="count"> Количество посуды </param>
        /// <returns> Посуду </returns>
        public Dish CreateGreenSmallPlasticGlass(int count)
        {
            Dish answer;

            DishBuilder dishBuilder = new DishBuilder();
            dishBuilder.setCapacity(2);
            dishBuilder.setColor("green");
            dishBuilder.setMaterial("plastic");
            dishBuilder.setPrice(60);

            answer = new Glass(dishBuilder.GetDishCharacteristics(), _lastId, count);
            _lastId++;

            return answer;
        }



    }
}
