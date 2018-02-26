using NUnit.Framework;

namespace GildedRose
{
    [TestFixture]
    public abstract class ShelveItemTestBase
    {
        protected readonly ShelveItemFactory Factory = new ShelveItemFactory();
    }
}