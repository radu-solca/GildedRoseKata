using FluentAssertions;
using NUnit.Framework;

namespace GildedRose
{
    [TestFixture]
    public class TicketItemTests
    {
        [Test]
        public void When_UpdateIsCalledOnTicketItem_SellInShouldDecreaseBy1()
        {
            // Arrange
            var ticketItem = GetTicketItem(20, 0);
            var initialSellIn = ticketItem.GetSellIn();

            // Act
            ticketItem.UpdateItemQuality();

            // Assert
            ticketItem.GetSellIn().Should().Be(initialSellIn - 1);
        }

        [Test]
        public void When_UpdateIsCalledOnTicketItem_QualityShouldIncreaseBy1()
        {
            // Arrange
            var ticketItem = GetTicketItem(20, 0);
            var initialQuality = ticketItem.GetQuality();

            // Act
            ticketItem.UpdateItemQuality();

            // Assert
            ticketItem.GetQuality().Should().Be(initialQuality + 1);
        }

        [Test]
        public void When_UpdateIsCalledOnTicketItem_AndSellInIsLesserOrEqualTo10_QualityShouldIncreaseBy2()
        {
            // Arrange
            var ticketItem = GetTicketItem(10, 0);
            var initialQuality = ticketItem.GetQuality();

            // Act
            ticketItem.UpdateItemQuality();

            // Assert
            ticketItem.GetQuality().Should().Be(initialQuality + 2);
        }

        [Test]
        public void When_UpdateIsCalledOnTicketItem_AndSellInIsLesserOrEqualTo5_QualityShouldIncreaseBy3()
        {
            // Arrange
            var ticketItem = GetTicketItem(5, 0);
            var initialQuality = ticketItem.GetQuality();

            // Act
            ticketItem.UpdateItemQuality();

            // Assert
            ticketItem.GetQuality().Should().Be(initialQuality + 3);
        }

        [Test]
        public void When_UpdateIsCalledOnTicketItem_AndSellInIsLesserOrEqualTo0_QualityShouldIncreaseBy3()
        {
            // Arrange
            var ticketItem = GetTicketItem(0, 0);

            // Act
            ticketItem.UpdateItemQuality();

            // Assert
            ticketItem.GetQuality().Should().Be(0);
        }

        [Test]
        public void When_UpdateIsCalledOnTicketItem_Then_QualityShouldNotIncreasePast50()
        {
            // Arrange
            var ticketItem = GetTicketItem(10, 50);

            // Act
            ticketItem.UpdateItemQuality();

            // Assert
            ticketItem.GetQuality().Should().Be(50);
        }

        private TicketItem GetTicketItem(int sellIn, int quality)
        {
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = sellIn,
                Quality = quality
            };

            return new TicketItem(item);
        }
    }
}