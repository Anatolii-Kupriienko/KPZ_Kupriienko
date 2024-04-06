namespace BridgeClassLib
{
    public class Square : Shape
    {
        public override void RenderAsPixels()
        {
            System.Console.WriteLine("Drawing square as pixels");
        }

        public override void RenderAsVector()
        {
            System.Console.WriteLine("Drawing square as vector");
        }
    }
}