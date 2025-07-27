using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private const int MAX_ITEM_QUALITY = 50;
    private const int MIN_ITEM_QUALITY = 0;
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
            UpdateQualityItemByIndex(this.Items[i]);
    
    }

    private void UpdateQualityItemByIndex(Item item)
    {
        NewMethod1(item);
        DecrementSellInForNotSulfurasHandOfRagnaros(item);
        NewMethod3(item);
    }

    private void NewMethod3(Item item)
    {
        if (item.SellIn >= 0)
            return;        
        if (item.Name != "Aged Brie")
        {
            if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                DecrementQualityForNotSulfurasHandOfRagnaros(item);            
            else
               item.Quality = MIN_ITEM_QUALITY;            
        }
        else        
            IncrementQuality(item);
        
    }

    private void IncrementQuality(Item item)
    {
        if (isMaxQuality(item))
            return;
        item.Quality++;
    }

    private void DecrementQualityForNotSulfurasHandOfRagnaros(Item item)
    {
        if (item.Quality <= MIN_ITEM_QUALITY)
            return;
        if (item.Name == "Sulfuras, Hand of Ragnaros")
            return;

        item.Quality--;
    }

    private void DecrementSellInForNotSulfurasHandOfRagnaros(Item item)
    {
        if (item.Name == "Sulfuras, Hand of Ragnaros")
            return;
        item.SellIn--;
    }

    private void NewMethod1(Item item)
    {
        if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
            DecrementQualityForNotSulfurasHandOfRagnaros(item);        
        else
            NewMethod(item);        
    }

    private void NewMethod(Item item)
    {
        IncrementQuality(item);
        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
            return;        
        if (item.SellIn < 11)
            IncrementQuality(item);        
        if (item.SellIn < 6)
            IncrementQuality(item);
        
    }

    private bool isMaxQuality(Item item)
    {
        return item.Quality >= MAX_ITEM_QUALITY;
    }
} 