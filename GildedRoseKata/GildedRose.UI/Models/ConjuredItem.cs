namespace GildedRose
{
    /// <summary>
    /// Quality decreases twice as fast.
    /// </summary>
    public class ConjuredItem : ShelveItem
    {
        public ConjuredItem(Item item) : base(item) {}

        public override void UpdateItemQuality()
        {
            Item.SellIn--;

            Item.Quality -= 2;

            if (Item.SellIn <= 0)
            {
                Item.Quality -= 2;
            }

            if (Item.Quality <= 0)
            {
                Item.Quality = 0;
            }
        }
    }
}