namespace BridgeClassLib
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer)
        {
        }
        public void SetRenderer(IRenderer renderer)
        {
            Renderer = renderer;
        }
        public override void Render()
        {
            Console.Write("Drawing circle ");
            Renderer.Render();
        }
    }
}