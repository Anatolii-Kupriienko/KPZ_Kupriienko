using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeClassLib
{
    public class Renderer
    {
        private RenderTypes _renderType;

        public Renderer(RenderTypes renderType)
        {
            _renderType = renderType;
        }

        public void SetRenderType(RenderTypes renderType)
        {
            _renderType = renderType;
        }

        public void Render(Shape shape)
        {
            if (_renderType == RenderTypes.Pixels)
            {
                shape.RenderAsPixels();
            }
            else
            {
                shape.RenderAsVector();
            }
        }
    }
}