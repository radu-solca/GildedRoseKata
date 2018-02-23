namespace GildedRose
{
    /// <summary>
    /// Quality increases as it gets older.
    /// </summary>
    public class AgingItem : ShelveItem
    {
        public AgingItem(Item item) : base(item) { }

        public override void UpdateItemQuality()
        {
            Item.SellIn--;

            if (Item.Quality < 50)
            {
                Item.Quality++;
            }
        }
    }
}