using System;
using System.Collections.Generic;
using System.Text;

namespace Программная_инженерия_ЛР1
{
    interface IDishCharacteristics
    {
        string color { get; set; }
        string material { get; set; }
        int capacity { get; set; }
        int price { get; set; }
    }
}
