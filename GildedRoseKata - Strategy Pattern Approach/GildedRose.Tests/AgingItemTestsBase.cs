using FluentAssertions;
using NUnit.Framework;

namespace GildedRose
{
    [TestFixture]
    public class AgingItemTestsBase : ShelveItemTestBase
    {
        [Test]
        public void When_UpdateIsCalledOnAgingItem_QualityShouldIncreaseBy1()
        {
            // Arrange
            var agingItem = GetAgingItem(10, 0);
            var initialQuality = agingItem.GetQuality();

            // Act
            agingItem.UpdateItemQuality();

            // Assert
            agingItem.GetQuality().Should().Be(initialQuality + 1);
        }

        [Test]
        public void When_UpdateIsCalledOnAgingItem_SellInShouldDecreaseBy1()
        {
            // Arrange
            var agingItem = GetAgingItem(10, 0);
            var initialSellIn = agingItem.GetSellIn();

            // Act
            agingItem.UpdateItemQuality();

            // Assert
            agingItem.GetSellIn().Should().Be(initialSellIn - 1);
        }

        [Test]
        public void When_UpdateIsCalledOnAgingItem_QualityShouldNotIncreasePast50()
        {
            // Arrange
            var agingItem = GetAgingItem(10, 50);

            // Act
            agingItem.UpdateItemQuality();

            // Assert
            agingItem.GetQuality().Should().Be(50);
        }

        private ShelveItem GetAgingItem(int sellIn, int quality)
        {
            var item = new Item { Name = "Aged Brie", SellIn = sellIn, Quality = quality };
            return Factory.GetAgingItem(item);
        }
    }
}