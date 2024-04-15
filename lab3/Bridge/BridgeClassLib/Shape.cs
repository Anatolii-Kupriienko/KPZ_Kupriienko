namespace BridgeClassLib
{
    public class Shape
    {
        public IRenderer Renderer { get; protected set; }
        public Shape(IRenderer renderer)
        {
            Renderer = renderer;
        }
        public virtual void Render()
        {
            Console.WriteLine("Rendering shape");
            Renderer.Render();
        }
    }
}