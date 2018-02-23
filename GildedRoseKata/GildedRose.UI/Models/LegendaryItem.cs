namespace GildedRose
{
    /// <summary>
    /// Quality and SellIn are immutable.
    /// </summary>
    public class LegendaryItem : ShelveItem
    {
        public LegendaryItem(Item item) : base(item) { }

        public override void UpdateItemQuality()
        {
        }
    }
}