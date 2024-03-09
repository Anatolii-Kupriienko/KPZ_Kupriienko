namespace ShopWarehouse;

public class Money
{
    public uint Whole { get; set; }
    public uint Fraction { get; set; }

    public Money() { }

    public Money(uint whole, uint fraction)
    {
        this.Whole = whole;
        this.Fraction = fraction;
    }

    public void Print()
    {
        Console.WriteLine(this.Whole + "." + this.Fraction);
    }

    public void SetNewSum(uint whole, uint fraction)
    {
        this.Whole = whole;
        this.Fraction = fraction;
    }

    public static Money operator -(Money item1, Money item2)
    {
        Money result = new Money();
        if (item1.Whole < item2.Whole || (item1.Whole == item2.Whole && item1.Fraction < item2.Fraction))
        {
            throw new InvalidOperationException("Minuend must be >= subtrahend");
        }
        result.Whole = item1.Whole - item2.Whole;
        if (item1.Fraction < item2.Fraction)
        {
            result.Fraction = 100 - (item2.Fraction - item1.Fraction);
            result.Whole--;
        }
        else
        {
            result.Fraction = item1.Fraction - item2.Fraction;
        }
        return result;
    }
}
