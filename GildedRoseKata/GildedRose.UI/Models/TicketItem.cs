namespace GildedRose
{
    /// <summary>
    /// Quality increases faster and faster as its sellIn approaches 0. When the item expires, the quality is instantly reduced to 0.
    /// </summary>
    public class TicketItem : ShelveItem
    {
        public TicketItem(Item item) : base(item) { }

        public override void UpdateItemQuality()
        {
            Item.SellIn--;

            Item.Quality++;

            if (Item.SellIn <= 10)
            {
                Item.Quality++;
            }

            if (Item.SellIn <= 5)
            {
                Item.Quality++;
            }

            if (Item.SellIn <= 0)
            {
                Item.Quality = 0;
            }

            if (Item.Quality > 50)
            {
                Item.Quality = 50;
            }
        }
    }
}