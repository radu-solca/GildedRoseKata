namespace GildedRose
{
    /// <summary>
    /// Quality increases as it gets older.
    /// </summary>
    public class AgingItemUpdateStrategy : IUpdateStrategy
    {
        public void UpdateItemQuality(Item item)
        {
            item.SellIn--;

            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }
    }
}