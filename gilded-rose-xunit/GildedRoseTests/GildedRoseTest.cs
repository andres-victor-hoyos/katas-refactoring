using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void foo()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal("foo", Items[0].Name);  // El nombre no cambia
        Assert.Equal(-1, Items[0].SellIn);   // SellIn decremented by 1
        Assert.Equal(0, Items[0].Quality);   // Quality stays 0 (can't go below 0)
    }
}