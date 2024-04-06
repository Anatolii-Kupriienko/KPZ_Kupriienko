using System.Text;
using CompositeClassLib;

namespace FlyweightClassLib
{
    public class FlyweightLightElementNode
    {
        public string TagName { get; private set; }
        public TagTypes TagType { get; private set; }
        public bool IsSelfClosing { get; private set; }
        public List<string> ClassList { get; private set; }

        public FlyweightLightElementNode(string tagName, TagTypes tagType, bool isSelfClosing, List<string> classList)
        {
            TagName = tagName;
            TagType = tagType;
            IsSelfClosing = isSelfClosing;
            ClassList = classList;
        }

    }
}