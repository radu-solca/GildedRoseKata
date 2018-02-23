using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in _items)
            {
                ShelveItem shelveItem;

                switch (item.Name)
                {
                    case "Aged Brie":
                        shelveItem = new AgingItem(item);
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        shelveItem = new LegendaryItem(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        shelveItem = new TicketItem(item);
                        break;
                    case "Conjured Mana Cake":
                        shelveItem = new ConjuredItem(item);
                        break;
                    default:
                        shelveItem = new ShelveItem(item);
                        break;
                }

                shelveItem.UpdateItemQuality();
            }
        }
    }
}