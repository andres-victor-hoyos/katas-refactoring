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
        DecrementQuantityIfSellInMayorZero();
    }

    protected virtual void DecrementQuantityIfSellInMayorZero()
    {
        if (this.SellIn >= 0)
            return;
        DecrementQuantity();
    }


    protected bool isBackstagePasses()
    {
        return this.Name == "Backstage passes to a TAFKAL80ETC concert";
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
        IncrementOrDecrementQuality();
    }

    protected virtual void IncrementOrDecrementQuality()
    {
        DecrementQuantity();
    }
    protected virtual void DeterminateIncrementQuality()
    {
        IncrementQuality();
    }

    protected virtual void DecrementQualityOfItem()
    {
        DecrementQuantity();
    }

    protected bool isMaxQuality()
    {
        return this.Quality >= MAX_ITEM_QUALITY;
    }
}

class SulfurasHandOfRagnaros : Item
{
    protected override void DecrementSellIn()
    {
        ;
    }

    protected override void DecrementQuantity()
    {
        ;
    }
}

class BackstagePasses : Item
{
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

    protected override void IncrementOrDecrementQuality()
    {
        IncrementQuality();
    }

}

public class AgedBrie : Item
{
    protected override void DecrementQuantity()
    {
        IncrementQuality();
    }

    protected override void DeterminateIncrementQuality()
    {
        DecrementQuantity();
    } 

    protected override void IncrementOrDecrementQuality()
    {
        IncrementQuality();
    }   
}


