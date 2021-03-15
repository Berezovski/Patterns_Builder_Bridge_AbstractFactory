using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    /// <summary>
    /// Российская фабрика посуд. Чтобы произвести посуду
    /// нужно указать количество и тип. Далее директор посуд
    /// самостоятельно, через паттерн "строитель", в котором
    /// реализован "мост", построит нужную нам модель.
    /// </summary>
    class RussianDish : IDishesFactory
    {
        private DishBuilderDirector _directorOfDish;

        /// <summary>
        /// Конструктор, создающий директора
        /// для строительства продукции
        /// </summary>
        public RussianDish()
        {
            _directorOfDish = new DishBuilderDirector();
        }

        /// <summary>
        /// Создаёт чашки
        /// </summary>
        /// <param name="count"> Количество штук </param>
        /// <param name="typeOfCup"> Вид чашек </param>
        /// <returns> Чашки </returns>
        public Cup createCups(int count, int typeOfCup)
        {
            if (typeOfCup == 0)
            {
                Cup answer = ((Cup)_directorOfDish.CreateWhiteSmallCeramicCup(count));
                answer.HaveHandle = false;
                return answer;
            }

            return null;
        }

        /// <summary>
        /// Создаёт бокалы
        /// </summary>
        /// <param name="count"> Количество штук </param>
        /// <param name="typeOfGlass"> Вид бокалов </param>
        /// <returns> Бокалы </returns>
        public Glass createGlasses(int count, int typeOfGlass)
        {
            if (typeOfGlass == 0)
            {
                return (Glass)_directorOfDish.CreateGreenSmallPlasticGlass(count);
            }

            return null;
        }

        /// <summary>
        /// Создаёт сковородки
        /// </summary>
        /// <param name="count"> Количество штук </param>
        /// <param name="typeOfPan"> Вид сковородок </param>
        /// <returns> Сковородки </returns>
        public Pan createPans(int count, int typeOfPan)
        {
            if (typeOfPan == 0)
            {
                return (Pan)_directorOfDish.CreateBlackBigIronPan(count);
            }

            return null;
        }

        /// <summary>
        /// Создаёт тарелки
        /// </summary>
        /// <param name="count"> Количество штук </param>
        /// <param name="typeOfPlates"> Вид тарелок </param>
        /// <returns> Тарелки </returns>
        public Plate createPlates(int count, int typeOfPlates)
        {
            if (typeOfPlates == 0)
            {
                return (Plate)_directorOfDish.CreateBlackSmallGlassPlate(count);
            }

            return null;
        }

        /// <summary>
        /// Создаёт кастрюли
        /// </summary>
        /// <param name="count"> Количество штук </param>
        /// <param name="typeOfPots"> Вид кастрюли </param>
        /// <returns> Кастрюли </returns>
        public Pot createPots(int count, int typeOfPots)
        {
            if (typeOfPots == 0)
            {
                return (Pot)_directorOfDish.CreateWhiteBigAluminumPot(count);
            }

            return null;
        }
    }
}
