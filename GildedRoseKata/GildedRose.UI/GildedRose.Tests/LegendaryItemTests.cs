using FluentAssertions;
using NUnit.Framework;

namespace GildedRose
{
    [TestFixture]
    public class LegendaryItemTests
    {
        [Test]
        public void When_UpdateIsCalledOnLegendaryItem_Then_SellInShouldNotChange()
        {
            // Arrange
            var legendaryItem = GetLegendaryItem(10, 80);
            var initialSellIn = legendaryItem.GetSellIn();

            // Act
            legendaryItem.UpdateItemQuality();

            // Assert
            legendaryItem.GetSellIn().Should().Be(initialSellIn);
        }

        [Test]
        public void When_UpdateIsCalledOnLegendaryItem_Then_QualityShouldNotChange()
        {
            // Arrange
            var legendaryItem = GetLegendaryItem(10, 80);
            var initialQuality = legendaryItem.GetQuality();

            // Act
            legendaryItem.UpdateItemQuality();

            // Assert
            legendaryItem.GetQuality().Should().Be(initialQuality);
        }

        private LegendaryItem GetLegendaryItem(int sellIn, int quality)
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellIn, Quality = quality };
            return new LegendaryItem(item);
        }
    }
}