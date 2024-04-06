namespace BridgeClassLib
{
    public class Shape
    {
        public virtual void RenderAsPixels()
        {
            System.Console.WriteLine("Rendering shape as pixels");
        }

        public virtual void RenderAsVector()
        {
            System.Console.WriteLine("Rendering shape as vector");
        }
    }
}