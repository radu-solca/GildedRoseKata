using FluentAssertions;
using NUnit.Framework;

namespace GildedRose
{
    [TestFixture]
    public class ShelveItemTests
    {
        // Simple items:

        [Test]
        public void When_UpdateIsCalledOnSimpleItem_Then_SellInShouldDecreaseBy1()
        {
            // Arrange
            var simpleItem = GetSimpleItem(10, 20);
            var initialSellIn = simpleItem.GetSellIn();

            // Act
            simpleItem.UpdateItemQuality();

            // Assert
            simpleItem.GetSellIn().Should().Be(initialSellIn - 1);
        }

        [Test]
        public void When_UpdateIsCalledOnSimpleItem_Then_QualityShouldDecreaseBy1()
        {
            // Arrange
            var simpleItem = GetSimpleItem(10, 20);
            var initialQuality = simpleItem.GetQuality();

            // Act
            simpleItem.UpdateItemQuality();

            // Assert
            simpleItem.GetQuality().Should().Be(initialQuality - 1);
        }

        [Test]
        public void When_UpdateIsCalledOnSimpleItem_And_SellInLessThan1_QualityShouldDecreaseBy2()
        {
            // Arrange
            var simpleItem = GetSimpleItem(0, 20);
            var initialQuality = simpleItem.GetQuality();

            // Act
            simpleItem.UpdateItemQuality();

            // Assert
            simpleItem.GetQuality().Should().Be(initialQuality - 2);
        }

        [Test]
        public void When_UpdateIsCalledOnSimpleItem_QualityShouldnotDecreasePast0()
        {
            // Arrange
            var simpleItem = GetSimpleItem(10, 0);

            // Act
            simpleItem.UpdateItemQuality();

            // Assert
            simpleItem.GetQuality().Should().Be(0);
        }

        private ShelveItem GetSimpleItem(int sellIn, int quality)
        {
            var item =new Item { Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality };
            return new ShelveItem(item);
        }
    }
}
