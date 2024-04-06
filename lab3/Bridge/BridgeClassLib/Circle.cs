namespace BridgeClassLib
{
    public class Circle : Shape
    {
        public override void RenderAsPixels()
        {
            System.Console.WriteLine("Drawing circle as pixels");
        }

        public override void RenderAsVector()
        {
            System.Console.WriteLine("Drawing circle as vector");
        }
    }
}