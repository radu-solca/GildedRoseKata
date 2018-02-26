using System.Collections.Generic;
using System.Data;

namespace GildedRose
{
    public class GildedRose
    {
        private readonly IList<ShelveItem> _items;

        public GildedRose(IList<ShelveItem> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                item.UpdateItemQuality();
            }
        }
    }
}