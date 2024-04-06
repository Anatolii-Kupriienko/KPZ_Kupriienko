using System.Text;

namespace CompositeClassLib
{
    public class LightElementNode : LightNode
    {
        protected List<LightNode> children = new List<LightNode>();

        public string TagName { get; private set; }
        public TagTypes TagType { get; private set; }
        public bool IsSelfClosing { get; private set; }
        public List<string> ClassList { get; private set; }

        public LightElementNode(string tagName, TagTypes tagType, bool isSelfClosing, List<string> classList)
        {
            TagName = tagName;
            TagType = tagType;
            IsSelfClosing = isSelfClosing;
            ClassList = classList;
        }

        public override void Add(LightNode node)
        {
            children.Add(node);
        }

        public override void Remove(LightNode node)
        {
            children.Remove(node);
        }

        public void AddClass(string className)
        {
            if (!ClassList.Contains(className))
            {
                ClassList.Add(className);
            }
        }

        public string InnerHtml()
        {
            StringBuilder sb = new StringBuilder();
            foreach (LightNode node in children)
            {
                if (node.GetType() == typeof(LightTextNode))
                {
                    sb.Append((node as LightTextNode).content);
                }
                else
                {
                    sb.Append((node as LightElementNode).OuterHtml());
                }
            }
            return sb.ToString();
        }

        public string OuterHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<").Append(TagName);
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
            return sb.ToString();
        }

        public override void Display()
        {
            Console.WriteLine(OuterHtml());
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