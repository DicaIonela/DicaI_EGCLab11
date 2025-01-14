using System;
using System.Drawing;
using System.Windows.Forms;

using OpenTK.Graphics.OpenGL;

using OpenTK3_StandardTemplate_WinForms.helpers;
using OpenTK3_StandardTemplate_WinForms.objects;

namespace OpenTK3_StandardTemplate_WinForms
{
    public partial class MainForm : Form
    {
        private Axes mainAxis;
        private Rectangles re;

        private Camera cam;
        private Scene scene;
        private Cub cub;
        private Color lightColor;
        private float lightX,lightY,lightZ;
        private float lightX0, lightY0, lightZ0;
        private Point mousePosition;
        private bool isLightOn = false;
        private bool transparency = false;
        private bool enableLightMovement = false; 

        public MainForm()
        {   
            // general init
            InitializeComponent();
            this.Text = "Dica Ionela - 3133b";
            // init VIEWPORT
            scene = new Scene();

            scene.GetViewport().Load += new EventHandler(this.mainViewport_Load);
            scene.GetViewport().Paint += new PaintEventHandler(this.mainViewport_Paint);
            scene.GetViewport().MouseMove += new MouseEventHandler(this.mainViewport_MouseMove);

            this.Controls.Add(scene.GetViewport());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // init RNG
            Randomizer.Init();

            // init CAMERA/EYE
            cam = new Camera(scene.GetViewport());

            // init AXES
            mainAxis = new Axes(showAxes.Checked);
            re = new Rectangles();
            cub = new Cub();


            ///////////* LUMINA */////////////
            // Initializare culoare și pozitie aleatoare pentru lumina
            
            lightX0 = Randomizer.GetNtoM(0, 10); 
            lightY0 = Randomizer.GetNtoM(0, 10); 
            lightZ0 = Randomizer.GetNtoM(0, 10);
            lightX = lightX0;
            lightY = lightY0;
            lightZ = lightZ0;
        }

        private void showAxes_CheckedChanged(object sender, EventArgs e)
        {
            mainAxis.SetVisibility(showAxes.Checked);

            scene.Invalidate();
        }

        private void changeBackground_Click(object sender, EventArgs e)
        {
            GL.ClearColor(Randomizer.GetRandomColor());

            scene.Invalidate();
        }

        private void resetScene_Click(object sender, EventArgs e)
        {
            showAxes.Checked = true;
            mainAxis.SetVisibility(showAxes.Checked);
            scene.Reset();
            cam.Reset();
            lightX= lightX0;
            lightY= lightY0;
            lightZ= lightZ0;
            scene.Invalidate();
        }

        private void mainViewport_Load(object sender, EventArgs e)
        {
            scene.Reset();
        }

       
        private void rbLightOn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLightOn.Checked)
            {
                isLightOn = true; 
                scene.Invalidate(); 
            }
        }

        private void ckTransparency_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTransparency.Checked)
            {
               
                transparency = true;
            }
            else
            {
                
                transparency = false;
            }
            scene.Invalidate();
        }

        private void rbLightOff_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLightOFF.Checked)
            {
                isLightOn = false; 
                scene.Invalidate(); 
            }
        }

        private void ckLightMove_CheckedChanged(object sender, EventArgs e)
        {
            enableLightMovement = ckLightMove.Checked;
        }

        private void mainViewport_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X, e.Y);
            if (enableLightMovement)
            {
                // Normalizează poziția mouse-ului pentru coordonatele scenei
                float normalizedY = (scene.GetViewport().Height / 2 - e.Y) / (float)(scene.GetViewport().Height / 2);
                float normalizedZ = (e.X - scene.GetViewport().Width / 2) / (float)(scene.GetViewport().Width / 2);

                // Actualizează coordonatele luminii
                lightY = normalizedY * 5; // Scalează pentru axa Y
                lightZ = normalizedZ * 5; // Scalează pentru axa Z

                // Actualizează scena pentru a reflecta modificările
                scene.Invalidate();
            }
        }


        private void mainViewport_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);
            
            cam.SetView();
            ///////////lumina////////////
            if (isLightOn)
            {
                // Configurare lumina
                float[] lightPosition = { lightX, lightY, lightZ, 1.0f };
                float[] lightAmbient = { lightColor.R / 255.0f, lightColor.G / 255.0f, lightColor.B / 255.0f, 1.0f };

                GL.Enable(EnableCap.Lighting);
                GL.Enable(EnableCap.Light0);

                GL.Light(LightName.Light0, LightParameter.Position, lightPosition);
                GL.Light(LightName.Light0, LightParameter.Ambient, Color.Beige);
            }
            else
            {
                // Dezactiveaza iluminarea
                GL.Disable(EnableCap.Lighting);
            }
            if (enableRotation.Checked == true)
            {
                // Doar dupa axa Ox.
                GL.Rotate(Math.Max(mousePosition.X, mousePosition.Y), 1, 1, 1);
            }

            // GRAPHICS PAYLOAD
            mainAxis.Draw();
            
            if (enableObjectRotation.Checked == true)
            {
                // Rotatie a obiectului
                GL.PushMatrix();
                GL.Rotate(Math.Max(mousePosition.X, mousePosition.Y), 1, 1, 1);
                re.Draw();
                GL.PopMatrix();
            } else
            {
                re.Draw();
            }
                GL.PushMatrix();
                GL.Scale(8.0, 8.0, 8.0); 
                cub.Draw(transparency);
                GL.PopMatrix();
            
            scene.GetViewport().SwapBuffers();
        }


    }
}
