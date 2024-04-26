namespace StrategyClassLib
{
    public class WebImageDisplayStrategy : IImageDisplayStrategy
    {
        public string Display(string href)
        {
            return "Searching for the image at: " + href + "\nLoading image";
        }
    }
}