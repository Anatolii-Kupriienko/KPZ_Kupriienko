using CompositeClassLib;

namespace FlyweightClassLib
{
    public static class FlyweightLightElementNodeFactory
    {
        private static Dictionary<string, FlyweightLightElementNode> nodes = new Dictionary<string, FlyweightLightElementNode>();

        public static FlyweightLightElementNode GetNode(string tagName)
        {
            var node = nodes.GetValueOrDefault(tagName);
            if (node == null)
            {
                node = new FlyweightLightElementNode(tagName, TagTypes.Block, false, new List<string>());
                nodes.Add(tagName, node);
            }
            return node;
        }

        public static int GetCountOfNodes()
        {
            return nodes.Count;
        }
    }
}