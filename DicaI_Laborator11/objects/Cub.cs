using System;
using OpenTK.Graphics.OpenGL;

namespace OpenTK3_StandardTemplate_WinForms.objects
{
    public class Cub
    {

        private void SetTransparency(bool isTransparent)
        {
            if (isTransparent)
            {
                GL.Enable(EnableCap.Blend);  
                GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha); // Setează funcția de blending
            }
            else
            {
                GL.Disable(EnableCap.Blend); 
            }
        }

        public void Draw(bool isTransparent)
        {
            SetTransparency(isTransparent);  
            GL.Begin(PrimitiveType.Triangles);

            GL.Color4(1.0f, 0.0f, 0.0f, isTransparent ? 0.5f : 1.0f);
            GL.Vertex3(0.0f, 5.0f, 0.0f); 
            GL.Vertex3(1.0f, 5.0f, 0.0f); 
            GL.Vertex3(1.0f, 6.0f, 0.0f); 

            GL.Vertex3(0.0f, 5.0f, 0.0f); 
            GL.Vertex3(1.0f, 6.0f, 0.0f); 
            GL.Vertex3(0.0f, 6.0f, 0.0f); 

            // Fața 2 (Fața din spate)
            GL.Color4(0.0f, 1.0f, 0.0f, isTransparent ? 0.5f : 1.0f); 
            GL.Vertex3(0.0f, 5.0f, 1.0f); 
            GL.Vertex3(0.0f, 6.0f, 1.0f); 
            GL.Vertex3(1.0f, 6.0f, 1.0f); 

            GL.Vertex3(0.0f, 5.0f, 1.0f);
            GL.Vertex3(1.0f, 6.0f, 1.0f); 
            GL.Vertex3(1.0f, 5.0f, 1.0f);

            // Fața 3 (Fața din stânga)
            GL.Color4(0.0f, 0.0f, 1.0f, isTransparent ? 0.5f : 1.0f); 
            GL.Vertex3(0.0f, 5.0f, 1.0f); 
            GL.Vertex3(0.0f, 5.0f, 0.0f); 
            GL.Vertex3(0.0f, 6.0f, 0.0f); 

            GL.Vertex3(0.0f, 5.0f, 1.0f); 
            GL.Vertex3(0.0f, 6.0f, 0.0f); 
            GL.Vertex3(0.0f, 6.0f, 1.0f); 

            // Fața 4 (Fața din dreapta)
            GL.Color4(1.0f, 1.0f, 0.0f, isTransparent ? 0.5f : 1.0f); 
            GL.Vertex3(1.0f, 5.0f, 1.0f); 
            GL.Vertex3(1.0f, 6.0f, 1.0f); 
            GL.Vertex3(1.0f, 6.0f, 0.0f); 

            GL.Vertex3(1.0f, 5.0f, 1.0f);
            GL.Vertex3(1.0f, 6.0f, 0.0f); 
            GL.Vertex3(1.0f, 5.0f, 0.0f); 

            // Fața 5 (Fața de sus)
            GL.Color4(1.0f, 0.0f, 1.0f, isTransparent ? 0.5f : 1.0f); 
            GL.Vertex3(0.0f, 6.0f, 0.0f); 
            GL.Vertex3(1.0f, 6.0f, 0.0f); 
            GL.Vertex3(1.0f, 6.0f, 1.0f); 

            GL.Vertex3(0.0f, 6.0f, 0.0f); 
            GL.Vertex3(1.0f, 6.0f, 1.0f); 
            GL.Vertex3(0.0f, 6.0f, 1.0f); 

            // Fața 6 (Fața de jos)
            GL.Color4(0.0f, 1.0f, 1.0f, isTransparent ? 0.5f : 1.0f); 
            GL.Vertex3(0.0f, 5.0f, 0.0f); 
            GL.Vertex3(0.0f, 5.0f, 1.0f);
            GL.Vertex3(1.0f, 5.0f, 1.0f); 

            GL.Vertex3(0.0f, 5.0f, 0.0f); 
            GL.Vertex3(1.0f, 5.0f, 1.0f); 
            GL.Vertex3(1.0f, 5.0f, 0.0f); 

            GL.End();
        }
    }
}
