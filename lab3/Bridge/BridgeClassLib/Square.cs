namespace BridgeClassLib
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
        }
        public void SetRenderer(IRenderer renderer)
        {
            Renderer = renderer;
        }
        public override void Render()
        {
            Console.Write("Drawing square ");
            Renderer.Render();
        }
    }
}