namespace ShopWarehouse;

public class Money : IMoney
{
    private static readonly string InvalidFractionExceptionMessage = "Fraction must be <= 100";
    private static readonly string InvalidSubtractionOperandsExceptioMessage = "Minuend must be >= subtrahend";

    public uint Whole { get; private set; }
    public uint Fraction { get; private set; }

    public Money() { }

    public Money(uint whole, uint fraction)
    {
        this.Whole = whole;
        this.Fraction = fraction;
    }

    // I needed to do this because a function call inside a setter, calls it like 5 gazillion times 
    // and causes a stack overflow
    public void SetWhole(uint value)
    {
        this.Whole = value;
    }

    public void SetFraction(uint value)
    {
        ValidateFraction(value);
        this.Fraction = value;
    }

    public void Print()
    {
        Console.WriteLine(this.Whole + "." + this.Fraction);
    }

    public void SetNewSum(uint whole, uint fraction)
    {
        ValidateFraction(fraction);
        this.Whole = whole;
        this.Fraction = fraction;
    }

    public static Money operator -(Money item1, Money item2)
    {
        ValidateMoneySubtraction(item1, item2);
        Money result = new Money
        {
            Whole = item1.Whole - item2.Whole
        };
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

    public static Money operator +(Money item1, Money item2)
    {
        Money result = new Money();
        uint fraction = item1.Fraction + item2.Fraction;
        result.Whole = item1.Whole + item2.Whole;
        if (fraction > 100)
        {
            fraction -= 100;
            result.Whole++;
        }
        result.Fraction = fraction;
        return result;
    }

    private static void ValidateMoneySubtraction(Money item1, Money item2)
    {
        ValidateFractions([item1.Fraction, item2.Fraction]);
        if (item1.Whole < item2.Whole || (item1.Whole == item2.Whole && item1.Fraction < item2.Fraction))
        {
            throw new InvalidOperationException(InvalidSubtractionOperandsExceptioMessage);
        }
    }

    private static void ValidateFraction(uint fraction)
    {
        if (fraction > 100)
        {
            throw new InvalidDataException(InvalidFractionExceptionMessage);
        }
    }

    private static void ValidateFractions(uint[] money)
    {
        foreach (var item in money)
        {
            ValidateFraction(item);
        }
    }
}
