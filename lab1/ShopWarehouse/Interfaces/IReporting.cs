namespace ShopWarehouse.Interfaces
{
    public interface IReporting
    {
        void ReportImport(IEnumerable<IReportable> itemsImported, IImporter to, IExporter from);
        void ReportExport(IEnumerable<IReportable> itemsExported, IExporter from, IImporter to);
    }
}