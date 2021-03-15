using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    interface IDishBuilder
    {
        void setColor(string color);
        void setMaterial(string material);
        void setCapacity(int capacity);
        void setPrice(int price);
        public DishCharacteristics GetDishCharacteristics();
    }
}
