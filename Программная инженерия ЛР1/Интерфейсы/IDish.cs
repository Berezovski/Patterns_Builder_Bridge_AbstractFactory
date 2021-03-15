using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    interface IDish
    {
        public DishCharacteristics GetDishCharacteristics();
        public int GetDishCount();
        public int GetDishId();

    }
}
