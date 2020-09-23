using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class GildedRoseRefactoring
    {
        IList<ItemRose> Items;
        public GildedRoseRefactoring(IList<ItemRose> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (ItemRose item in Items)
            {
                switch (item.AgingType)
                {
                    case ItemRose.Aging.Bad:
                        item.Quality = item.Quality - item.AgingSpeed;
                        break;
                    case ItemRose.Aging.Well:
                        item.Quality = item.Quality + item.AgingSpeed;
                        break;
                }
            }
        }
    }
}
