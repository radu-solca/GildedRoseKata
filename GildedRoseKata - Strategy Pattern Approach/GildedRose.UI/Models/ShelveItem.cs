namespace GildedRose
{
    /// <summary>
    /// Contains standard item behaviour.
    /// </summary>
    public class ShelveItem
    {
        private readonly Item _item;
        private readonly IUpdateStrategy _strategy;

        public ShelveItem(Item item, IUpdateStrategy strategy)
        {
            _item = item;
            _strategy = strategy;
        }

        public virtual void UpdateItemQuality()
        {
            _strategy.UpdateItemQuality(_item);
        }

        public string GetName()
        {
            return _item.Name;
        }

        public int GetSellIn()
        {
            return _item.SellIn;
        }

        public int GetQuality()
        {
            return _item.Quality;
        }
    }
}