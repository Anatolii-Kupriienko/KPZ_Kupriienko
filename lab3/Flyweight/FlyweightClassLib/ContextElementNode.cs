using System.Text;
using CompositeClassLib;

namespace FlyweightClassLib
{
    public class ContextElementNode
    {
        //I think this is more correct to use a list of LightNode here
        //but for a book would be better to use just a LightTextNode instead
        // public LightTextNode Children { get; set; }
        public List<LightNode> Children { get; set; }
        public FlyweightLightElementNode Node { get; set; }

        public ContextElementNode(FlyweightLightElementNode node)
        {
            Node = node;
            Children = new List<LightNode>();
        }

        public void Add(LightNode node)
        {
            // Children.content = text;
            Children.Add(node);
        }

        public void Remove(LightNode node)
        {
            Children.Remove(node);
        }

        public string InnerHtml()
        {
            StringBuilder sb = new StringBuilder();
            foreach (LightNode node in Children)
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
            // return Children.content;
        }

        public string OuterHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<").Append(Node.TagName);
            if (Node.ClassList.Count > 0)
            {
                sb.Append(GetClassList());
            }

            if (Node.IsSelfClosing)
            {
                sb.Append(" />");
            }
            else
            {
                sb.Append(">");
                sb.Append(InnerHtml());
                sb.Append("</").Append(Node.TagName).Append(">");
            }
            return sb.ToString();
        }


        public void Display()
        {
            Console.WriteLine(OuterHtml());
        }
        private string GetClassList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" class=\"");
            foreach (string className in Node.ClassList)
            {
                sb.Append(className).Append(" ");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("\"");
            return sb.ToString();
        }

    }
}