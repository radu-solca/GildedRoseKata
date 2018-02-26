using FluentAssertions;
using NUnit.Framework;

namespace GildedRose
{
    [TestFixture]
    public class ConjuredItemTestsBase : ShelveItemTestBase
    {
        [Test]
        public void When_UpdateIsCalledOnConjuredItem_Then_SellInShouldDecreaseBy1()
        {
            // Arrange
            var conjuredItem = GetConjuredItem(10, 20);
            var initialSellIn = conjuredItem.GetSellIn();

            // Act
            conjuredItem.UpdateItemQuality();

            // Assert
            conjuredItem.GetSellIn().Should().Be(initialSellIn - 1);
        }

        [Test]
        public void When_UpdateIsCalledOnConjuredItem_Then_QualityShouldDecreaseBy2()
        {
            // Arrange
            var conjuredItem = GetConjuredItem(10, 20);
            var initialQuality = conjuredItem.GetQuality();

            // Act
            conjuredItem.UpdateItemQuality();

            // Assert
            conjuredItem.GetQuality().Should().Be(initialQuality - 2);
        }

        [Test]
        public void When_UpdateIsCalledOnConjuredItem_And_SellInLessThan1_QualityShouldDecreaseBy4()
        {
            // Arrange
            var conjuredItem = GetConjuredItem(0, 20);
            var initialQuality = conjuredItem.GetQuality();

            // Act
            conjuredItem.UpdateItemQuality();

            // Assert
            conjuredItem.GetQuality().Should().Be(initialQuality - 4);
        }

        [Test]
        public void When_UpdateIsCalledOnConjuredItem_QualityShouldnotDecreasePast0()
        {
            // Arrange
            var conjuredItem = GetConjuredItem(10, 0);

            // Act
            conjuredItem.UpdateItemQuality();

            // Assert
            conjuredItem.GetQuality().Should().Be(0);
        }

        private ShelveItem GetConjuredItem(int sellIn, int quality)
        {
            var item = new Item { Name = "Conjured Mana Cake", SellIn = sellIn, Quality = quality };
            return Factory.GetConjuredItem(item);
        }
    }
}