
using BridgeClassLib;

IRenderer renderer = new PixelRenderer();
Circle circle = new Circle(renderer);
Square square = new Square(renderer);
Triangle triangle = new Triangle(renderer);

circle.Render();
square.Render();
triangle.Render();

IRenderer vectorRenderer = new VectorRenderer();

circle.SetRenderer(vectorRenderer);
square.SetRenderer(vectorRenderer);
triangle.SetRenderer(vectorRenderer);

circle.Render();
square.Render();
triangle.Render();
