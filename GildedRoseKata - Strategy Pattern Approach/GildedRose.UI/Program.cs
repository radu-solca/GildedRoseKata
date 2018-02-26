using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        private static readonly ShelveItemFactory Factory = new ShelveItemFactory();

        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<ShelveItem> Items = new List<ShelveItem>{
                Factory.GetSimpleItem(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}),
                Factory.GetAgingItem(new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}),
                Factory.GetSimpleItem(new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7}),
                Factory.GetLegendaryItem(new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}),
                Factory.GetLegendaryItem(new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80}),
                Factory.GetTicketItem(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }),
                Factory.GetTicketItem(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                }),
                Factory.GetTicketItem(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                }),
				// this conjured item does not work properly yet
                Factory.GetConjuredItem(new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6})
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].GetName() + ", " + Items[j].GetSellIn() + ", " + Items[j].GetQuality());
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
