using System.Text;
using ObserverClassLibrary;

namespace ObserverClassLib.LightHTML
{
    public class LightElementNode : LightNode
    {
        protected List<LightNode> children = new List<LightNode>();

        public string TagName { get; private set; }
        public TagTypes TagType { get; private set; }
        public bool IsSelfClosing { get; private set; }
        public List<string> ClassList { get; private set; }

        private List<IEventListener> eventListeners = new List<IEventListener>();

        public LightElementNode(string tagName, TagTypes tagType, bool isSelfClosing, List<string> classList)
        {
            TagName = tagName;
            TagType = tagType;
            IsSelfClosing = isSelfClosing;
            ClassList = classList;
        }

        public void AddEvent(IEventListener listener)
        {
            eventListeners.Add(listener);
        }

        public void RemoveEvent(IEventListener listener)
        {
            eventListeners.Remove(listener);
        }

        public void TriggerEvent(string eventName)
        {
            foreach (IEventListener listener in eventListeners)
            {
                if (listener.eventName == eventName)
                {
                    listener.Action(this);
                }
            }
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