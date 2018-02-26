namespace GildedRose
{
    public class SimpleItemUpdateStrategy : IUpdateStrategy
    {
        public void UpdateItemQuality(Item item)
        {
            item.Quality--;
            item.SellIn--;

            if (item.SellIn <= 0)
            {
                item.Quality--;
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}