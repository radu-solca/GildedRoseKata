namespace GildedRose
{
    public class ShelveItemFactory
    {
        public ShelveItem GetSimpleItem(Item item)
        {
            return new ShelveItem(item, new SimpleItemUpdateStrategy());
        }

        public ShelveItem GetAgingItem(Item item)
        {
            return new ShelveItem(item, new AgingItemUpdateStrategy());
        }

        public ShelveItem GetLegendaryItem(Item item)
        {
            return new ShelveItem(item, new LegendaryItemUpdateStrategy());
        }

        public ShelveItem GetTicketItem(Item item)
        {
            return new ShelveItem(item, new TicketItemUpdateStrategy());
        }

        public ShelveItem GetConjuredItem(Item item)
        {
            return new ShelveItem(item, new ConjuredItemUpdateStrategy());
        }
    }
}
