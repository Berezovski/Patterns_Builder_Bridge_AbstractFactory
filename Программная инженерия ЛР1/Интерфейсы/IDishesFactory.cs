using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    interface IDishesFactory
    {
        Cup createCups(int count, int typeOfDishes);
        Glass createGlasses(int count, int typeOfDishes);
        Pan createPans(int count, int typeOfDishes);
        Plate createPlates(int count, int typeOfDishes);
        Pot createPots(int count, int typeOfDishes);
    }
}
