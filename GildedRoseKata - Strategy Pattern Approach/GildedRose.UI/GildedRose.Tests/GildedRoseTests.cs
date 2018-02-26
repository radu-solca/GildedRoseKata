using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace GildedRose
{
    [TestFixture]
    public class GildedRoseTests
    {
        private Item _simpleItem;
        private Item _agingitem;
        private Item _legendaryItem;
        private Item _ticketItem;
        private IList<Item> _items;

        private GildedRose _sut;

        [SetUp]
        public void SetUp()
        {
            _simpleItem = new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20};
            _agingitem = new Item {Name = "Aged Brie", SellIn = 2, Quality = 0};
            _legendaryItem = new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80};
            _ticketItem = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 4,
                Quality = 20
            };

            _items = new List<Item> {_simpleItem, _agingitem, _legendaryItem, _ticketItem};

            _sut = new GildedRose(_items);
        }

        [TearDown]
        public void TearDown()
        {
            _simpleItem = null;
            _agingitem = null;
            _legendaryItem = null;
            _ticketItem = null;
            _items = null;

            _sut = null;
        }

        [Test]
        public void When_UpdateIsCalled_Then_SimpleItemsShouldUpdateCorrectly()
        {
            // Arrange
            var initialSellIn = _simpleItem.SellIn;
            var initialQuality = _simpleItem.Quality;

            // Act
            _sut.UpdateQuality();

            // Assert
            _simpleItem.SellIn.Should().Be(initialSellIn - 1);
            _simpleItem.Quality.Should().Be(initialQuality - 1);
        }

        [Test]
        public void When_UpdateIsCalled_Then_AgingItemsShouldUpdateCorrectly()
        {
            // Arrange
            var initialSellIn = _agingitem.SellIn;
            var initialQuality = _agingitem.Quality;

            // Act
            _sut.UpdateQuality();

            // Assert
            _agingitem.SellIn.Should().Be(initialSellIn - 1);
            _agingitem.Quality.Should().Be(initialQuality + 1);
        }

        [Test]
        public void When_UpdateIsCalled_Then_LegendaryItemsShouldUpdateCorrectly()
        {
            // Arrange
            var initialSellIn = _legendaryItem.SellIn;
            var initialQuality = _legendaryItem.Quality;

            // Act
            _sut.UpdateQuality();

            // Assert
            _legendaryItem.SellIn.Should().Be(initialSellIn);
            _legendaryItem.Quality.Should().Be(initialQuality);
        }

        [Test]
        public void When_UpdateIsCalled_Then_TicketItemsShouldUpdateCorrectly()
        {
            // Arrange
            var initialSellIn = _ticketItem.SellIn;
            var initialQuality = _ticketItem.Quality;

            // Act
            _sut.UpdateQuality();

            // Assert
            _ticketItem.SellIn.Should().Be(initialSellIn - 1);
            _ticketItem.Quality.Should().Be(initialQuality + 3);
        }
    }
}