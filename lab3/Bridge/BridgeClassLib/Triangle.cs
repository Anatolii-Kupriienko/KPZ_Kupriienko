namespace BridgeClassLib
{
    public class Triangle : Shape
    {
        public override void RenderAsPixels()
        {
            System.Console.WriteLine("Drawing triangle as pixels");
        }

        public override void RenderAsVector()
        {
            System.Console.WriteLine("Drawing triangle as vector");
        }
    }
}