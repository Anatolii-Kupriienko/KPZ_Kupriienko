namespace BridgeClassLib
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
        }
        public void SetRenderer(IRenderer renderer)
        {
            Renderer = renderer;
        }
        public override void Render()
        {
            Console.Write("Drawing triangle ");
            Renderer.Render();
        }
    }
}