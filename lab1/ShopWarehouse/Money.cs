namespace ShopWarehouse;

public class Money
{
    public int Whole
    {
        get
        {
            return this.Whole;
        }
        set
        {
            if (value >= 0)
            {
                this.Whole = value;
            }
        }
    }
    public int Fraction
    {
        get
        {
            return this.Fraction;
        }
        set
        {
            if (value >= 0)
            {
                this.Fraction = value;
            }
        }
    }

    public Money(int whole, int fraction)
    {
        this.Whole = whole;
        this.Fraction = fraction;
    }

    public void Print()
    {
        Console.WriteLine(this.Whole + "." + this.Fraction);
    }

    public void SetNewSum(int whole, int fraction)
    {
        this.Whole = whole;
        this.Fraction = fraction;
    }
}
