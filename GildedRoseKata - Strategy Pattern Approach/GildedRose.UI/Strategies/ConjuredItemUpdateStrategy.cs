namespace GildedRose
{
    /// <summary>
    /// Quality decreases twice as fast.
    /// </summary>
    public class ConjuredItemUpdateStrategy : IUpdateStrategy
    {
        public void UpdateItemQuality(Item item)
        {
            item.SellIn--;

            item.Quality -= 2;

            if (item.SellIn <= 0)
            {
                item.Quality -= 2;
            }

            if (item.Quality <= 0)
            {
                item.Quality = 0;
            }
        }
    }
}