
using BridgeClassLib;

Circle circle = new Circle();
Square square = new Square();
Triangle triangle = new Triangle();

Renderer renderer = new Renderer(RenderTypes.Pixels);

renderer.Render(circle);
renderer.Render(square);
renderer.Render(triangle);

renderer = new Renderer(RenderTypes.Vector);

renderer.Render(circle);
renderer.Render(square);
renderer.Render(triangle);

//I don't quite understand how this works, maybe this is not the best example to show the bridge pattern
//or maybe I am just dumb.