namespace ObserverClassLib.LightHTML
{
    public class LightTextNode : LightNode
    {
        public string content;

        public LightTextNode(string content)
        {
            this.content = content;
        }

        public override void Display()
        {
            Console.WriteLine(content);
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}