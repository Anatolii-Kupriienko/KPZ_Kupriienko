namespace ShopWarehouse.Interfaces
{
    public interface IReportable
    {
        string Title { get; }
        uint Amount { get; }
        string Unit { get; }
        string ToReportString();
    }
}