using System;

namespace csharp
{
    class ItemRose : Item
    {
        public enum Aging
        {
            Bad,
            Well,
            None
        }

        public Aging AgingType { get; set; }
        public int AgingSpeed { get; set; }

    }
}
