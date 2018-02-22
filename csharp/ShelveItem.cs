namespace GildedRose
{
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

    public class LegendaryItem : ShelveItem
    {
        public LegendaryItem(Item item) : base(item) { }

        public override void UpdateItemQuality()
        {
        }
    }

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