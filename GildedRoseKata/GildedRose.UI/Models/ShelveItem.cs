namespace GildedRose
{
    /// <summary>
    /// Contains standard item behaviour.
    /// </summary>
    public class ShelveItem
    {
        protected readonly Item Item;

        public ShelveItem(Item item)
        {
            Item = item;
        }

        public virtual void UpdateItemQuality()
        {
            Item.SellIn--;

            Item.Quality--;

            if (Item.SellIn <= 0)
            {
                Item.Quality--;
            }

            if (Item.Quality <= 0)
            {
                Item.Quality = 0;
            }
        }

        public int GetSellIn()
        {
            return Item.SellIn;
        }

        public int GetQuality()
        {
            return Item.Quality;
        }
    }
}