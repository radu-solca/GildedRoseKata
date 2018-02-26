namespace GildedRose
{
    /// <summary>
    /// Quality increases faster and faster as its sellIn approaches 0. When the item expires, the quality is instantly reduced to 0.
    /// </summary>
    public class TicketItemUpdateStrategy : IUpdateStrategy
    {
        public void UpdateItemQuality(Item item)
        {
            item.SellIn--;

            item.Quality++;

            if (item.SellIn <= 10)
            {
                item.Quality++;
            }

            if (item.SellIn <= 5)
            {
                item.Quality++;
            }

            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }

            if (item.Quality > 50)
            {
                item.Quality = 50;
            }
        }
    }
}