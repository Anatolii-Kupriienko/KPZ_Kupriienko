using ObserverClassLib.LightHTML;
using System.Text;
using System.Text.RegularExpressions;

namespace StrategyClassLib
{
    public class Image : LightElementNode
    {
        public string href { get; set; }

        public Image(string href, List<string> classList) : base("img", TagTypes.Block, true, classList)
        {
            this.href = href;
        }

        public void LoadImage(IImageDisplayStrategy strategy)
        {
            Console.WriteLine(strategy.Display(href));
        }

        public override void Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<").Append(TagName).Append(" href=\"").Append(href).Append("\" ");
            if (ClassList.Count > 0)
            {
                sb.Append(GetClassList());
            }

            if (IsSelfClosing)
            {
                sb.Append(" />");
            }
            else
            {
                sb.Append(">");
                sb.Append(InnerHtml());
                sb.Append("</").Append(TagName).Append(">");
            }
            Console.WriteLine(sb.ToString());
         
            Regex regex = new Regex(@"^http(s)?://");
            Match match = regex.Match(href);
            if (match.Success)
            {
                LoadImage(new WebImageDisplayStrategy());
            }
            else
            {
                LoadImage(new FileSystemImageLoadingStrategy());
            }
        }

        private string GetClassList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" class=\"");
            foreach (string className in ClassList)
            {
                sb.Append(className).Append(" ");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("\"");
            return sb.ToString();
        }
    }
}