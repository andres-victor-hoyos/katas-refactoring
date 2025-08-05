namespace GildedRoseKata;

public class Item
{
    private const int MAX_ITEM_QUALITY = 50;
    protected const int MIN_ITEM_QUALITY = 0;
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void Update()
    {
        UpdateQuality();
        DecrementSellIn();
        DegradeIfExpired();
    }

    protected virtual void DegradeIfExpired()
    {
        if (this.SellIn >= 0)
            return;
        DecrementQuantity();
    }
  
    protected virtual void IncrementQuality()
    {
        if (isMaxQuality())
            return;
        this.Quality++;
    }

    protected virtual void DecrementQuantity()
    {
        if (this.Quality <= MIN_ITEM_QUALITY)
            return;
        this.Quality--;
    }

    protected virtual void DecrementSellIn()
    {
        this.SellIn--;
    }    

    protected void UpdateQuality()
    {
        AdjustQualityForToday();
    }

    protected virtual void AdjustQualityForToday()
    {
        DecrementQuantity();
    }
    protected virtual void DeterminateIncrementQuality()
    {
        IncrementQuality();
    }  

    protected bool isMaxQuality()
    {
        return this.Quality >= MAX_ITEM_QUALITY;
    }
}

public class SulfurasHandOfRagnaros : Item
{
    public SulfurasHandOfRagnaros()
    {
        Name = "Sulfuras, Hand of Ragnaros";
    }
    protected override void DecrementSellIn()
    {
        ;
    }

    protected override void DecrementQuantity()
    {
        ;
    }
}

public class BackstagePasses : Item
{
    public BackstagePasses()
    {
        Name="Backstage passes to a TAFKAL80ETC concert";
    }
    protected override void IncrementQuality()
    {
        base.IncrementQuality();
        if (this.SellIn < 11)
            base.IncrementQuality();
        if (this.SellIn < 6)
            base.IncrementQuality();

    }

    protected override void DecrementQuantity()
    {
        this.Quality = MIN_ITEM_QUALITY;
    }

    protected override void DeterminateIncrementQuality()
    {
        IncrementQuality();
    }

    protected override void AdjustQualityForToday()
    {
        IncrementQuality();
    }

}

public class AgedBrie : Item
{
    public AgedBrie()
    {
        Name = "Aged Brie";
    }
    protected override void DecrementQuantity()
    {
        IncrementQuality();
    }

    protected override void DeterminateIncrementQuality()
    {
        DecrementQuantity();
    } 

    protected override void AdjustQualityForToday()
    {
        IncrementQuality();
    }   
}


