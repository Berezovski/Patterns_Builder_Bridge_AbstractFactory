using System;
using System.Threading;

namespace Программная_инженерия_ЛР1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запускаем производство:");

            RussianDish rfDish = new RussianDish();
            int countBatchOfProducts = 0;
            Random rd = new Random();

            while (countBatchOfProducts != 10)
            {
                Thread.Sleep(5000);
                Dish createdDish;

                switch (rd.Next(0, 4))
                {
                    case 0:
                        createdDish = rfDish.createCups(5, 0);
                        printCup((Cup)createdDish);
                        break;
                    case 1:
                        createdDish = rfDish.createGlasses(5, 0);
                        printGlass((Glass)createdDish);
                        break;
                    case 2:
                        createdDish = rfDish.createPans(5, 0);
                        printPan((Pan)createdDish);
                        break;
                    case 3:
                        createdDish = rfDish.createPlates(5, 0);
                        printPlate((Plate)createdDish);
                        break;
                    case 4:
                        createdDish = rfDish.createPots(5, 0);
                        printPot((Pot)createdDish);
                        break;
                    default:
                        createdDish = rfDish.createCups(5, 0);
                        printCup((Cup)createdDish);
                        break;
                }

                Console.WriteLine();
                countBatchOfProducts++;
            }

            
        }

        static void printCup(Cup thisCup)
        {
            if (thisCup.HaveHandle == true)
            {
                Console.WriteLine("Чашки с ручкой:"); 
            }
            else
            {
                Console.WriteLine("Чашки без ручки:");
            }
            Console.WriteLine("В количестве - " + thisCup.GetDishCount());
            Console.WriteLine("Айди выпуска - " + thisCup.GetDishId());
            Console.WriteLine("Материал - " + thisCup.GetDishCharacteristics().material);
            Console.WriteLine("Вместимость - " + thisCup.GetDishCharacteristics().capacity);
            Console.WriteLine("Цвет - " + thisCup.GetDishCharacteristics().color);
            Console.WriteLine("Цена - " + thisCup.GetDishCharacteristics().price);
        }

        static void printPot(Pot thisPot)
        {
            if (thisPot.HaveNonStickCoating == true)
            {
                Console.WriteLine("Кастрюля с антипригарным покрытием:");
            }
            else
            {
                Console.WriteLine("Кастрюля без антипригарного покрытия:");
            }
            Console.WriteLine("В количестве - " + thisPot.GetDishCount());
            Console.WriteLine("Айди выпуска - " + thisPot.GetDishId());
            Console.WriteLine("Материал - " + thisPot.GetDishCharacteristics().material);
            Console.WriteLine("Вместимость - " + thisPot.GetDishCharacteristics().capacity);
            Console.WriteLine("Цвет - " + thisPot.GetDishCharacteristics().color);
            Console.WriteLine("Цена - " + thisPot.GetDishCharacteristics().price);
        }

        static void printGlass(Glass thisGlass)
        {
            if (thisGlass.HaveStem == true)
            {
                Console.WriteLine("Бокал с ножкой:");
            }
            else
            {
                Console.WriteLine("Бокал без ножки:");
            }
            Console.WriteLine("В количестве - " + thisGlass.GetDishCount());
            Console.WriteLine("Айди выпуска - " + thisGlass.GetDishId());
            Console.WriteLine("Материал - " + thisGlass.GetDishCharacteristics().material);
            Console.WriteLine("Вместимость - " + thisGlass.GetDishCharacteristics().capacity);
            Console.WriteLine("Цвет - " + thisGlass.GetDishCharacteristics().color);
            Console.WriteLine("Цена - " + thisGlass.GetDishCharacteristics().price);
        }

        static void printPan(Pan thisPan)
        {
            if (thisPan.IsInduction == true)
            {
                Console.WriteLine("Индукционная сковородка:");
            }
            else
            {
                Console.WriteLine("Неиндукционная сковородка:");
            }
            Console.WriteLine("В количестве - " + thisPan.GetDishCount());
            Console.WriteLine("Айди выпуска - " + thisPan.GetDishId());
            Console.WriteLine("Материал - " + thisPan.GetDishCharacteristics().material);
            Console.WriteLine("Вместимость - " + thisPan.GetDishCharacteristics().capacity);
            Console.WriteLine("Цвет - " + thisPan.GetDishCharacteristics().color);
            Console.WriteLine("Цена - " + thisPan.GetDishCharacteristics().price);
        }

        static void printPlate(Plate thisPlate)
        {
            if (thisPlate.IsSingleUse == true)
            {
                Console.WriteLine("Одноразовая тарелка:");
            }
            else
            {
                Console.WriteLine("Многоразовая тарелка:");
            }
            Console.WriteLine("В количестве - " + thisPlate.GetDishCount());
            Console.WriteLine("Айди выпуска - " + thisPlate.GetDishId());
            Console.WriteLine("Материал - " + thisPlate.GetDishCharacteristics().material);
            Console.WriteLine("Вместимость - " + thisPlate.GetDishCharacteristics().capacity);
            Console.WriteLine("Цвет - " + thisPlate.GetDishCharacteristics().color);
            Console.WriteLine("Цена - " + thisPlate.GetDishCharacteristics().price);
        }

    }
}
