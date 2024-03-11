using System.Text;
using ShopWarehouse.Interfaces;

namespace ShopWarehouse
{
    public class Reporting : IReporting
    {
        // RANT ABOUT MY CONCERNS OF THIS PART OF THE CODE STARTS
        // these 2 methods do looks kinda similar, BUT that is just how it is with composing string reports I believe
        // I could try to make this more flexible, like a builder, where you can choose options, or smth like that
        // but that is too much IMO. Instead you can just create another implementation of the IReporting interface
        // if you really want to do something like that, or just implement a report builder/reporter that you need
        // for specific needs, I doubt that there would be too many separate needs, just give it a title/header field
        // or smth. But I don't have any proper experience in actual working environment so I am probably wrong.
        // But I am willing to step on this rake in the future to learn how ignorant I am rn the hard way. RANT OVER
        public void ReportExport(IEnumerable<IReportable> itemsExported, IExporter from, IImporter to)
        {
            string startingMessage = $"Export Report for {DateTime.Today} for warehouse №{from.Id}:\n";
            StringBuilder finalReport = new StringBuilder(startingMessage);
            int counter = 1;
            foreach (var item in itemsExported)
            {
                finalReport.AppendLine($"{counter}. Exported: " + item.ToReportString());
                ++counter;
            }
            finalReport.Append($"In total exported {itemsExported.Count()} items from warehouse №{from.Id} to №{to.Id}.");
            Console.WriteLine(finalReport.ToString());
        }

        public void ReportImport(IEnumerable<IReportable> itemsImported, IImporter to, IExporter from)
        {
            string startingMessage = $"Import Report for {DateTime.Today} for warehouse №{to.Id}\n";
            StringBuilder finalReport = new StringBuilder(startingMessage);
            int counter = 1;
            foreach (var item in itemsImported)
            {
                finalReport.AppendLine($"{counter}. Imported: " + item.ToReportString());
                ++counter;
            }
            finalReport.Append($"In total imported {itemsImported.Count()} items to warehouse №{to.Id} from №{from.Id}");
        }
    }
}