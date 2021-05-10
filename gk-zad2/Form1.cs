using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace gk_zad2
{
    public partial class Form1 : Form
    {
        public DirectBitmap originalPicture;
        public DirectBitmap picture;
        public DirectBitmap normalMap;
        public MyPoint[,] mesh;
        public IEnumerable<Triangle> triangles;
        public Point3D light= new Point3D(0, 0, 100); //trzecia współrzędna ustala wysokość źródła światła
        public bool animating=false;
        private readonly bool seperateLightSource =false; // zmiana na true uniezależnia ruch światła od prędkośći rysowania obrazu

        public MyPoint movedPoint=null;
        public Form1()
        {
            InitializeComponent();        
        }
        private Vector3D ConvertColorToNormalVector(Color col)
        {
            double X = col.R / 127.0 - 1.0; // [-1,1]
            double Y = col.G / 127.0 - 1.0; // [-1,1]
            double Z = col.B / 255.0; // [0,1]
            return new Vector3D(X, Y, Z);
        }

        private void DrawLightenedPicture()
        {
            double kd = (double)kdSlider.Value / kdSlider.Maximum;
            double ks = (double)ksSlider.Value / ksSlider.Maximum;
            int m = mSlider.Value;
            Color ILo = lightColorButton.BackColor;              
            bool pFromFile = pictureFromFileRadioButton.Checked;
            bool nFromFile = normalMapFromFileRadioButton.Checked;
            bool detailed = detailedFillingButton.Checked;
            Color IR = Color.DarkCyan;
            Point3D reflektorLoc = new Point3D(0, 0, 200);
            int a = 10;
            bool reflekt = reflektorCheckBox.Checked;
            (int, int, int) Calc(int x, int y, bool reflektor = false)
            {
                Vector3D N = new Vector3D(0, 0, 1);
                if (nFromFile)
                {
                    N = ConvertColorToNormalVector(normalMap.GetPixel(x, y));
                    N.Y *= -1;
                    N.Normalize();
                }
                Vector3D L = new Vector3D(0, 0, 1);
                Color IL = ILo;
                if (!reflektor)
                {
                    if (animating)
                    {
                        L = light - new Point3D(x, y, 0);
                        L.Normalize();
                    }
                }
                else if (reflektor)
                {
                    L = reflektorLoc - new Point3D(x, y, 0);
                    L.Normalize();
                    Vector3D K = reflektorLoc - new Point3D(picture.Width / 2, picture.Height / 2, 0);
                    K.Normalize();
                    double deg = Math.Pow(K.X * L.X + K.Y * L.Y + K.Z * L.Z, a);
                    IL = Color.FromArgb((int)(IR.R * deg), (int)(IR.G * deg), (int)(IR.B * deg));
                }
                Color IO = textureColorButton.BackColor;
                if (pFromFile)
                    IO = originalPicture.GetPixel(x, y);          
                double cos = N.X * L.X + N.Y * L.Y + N.Z * L.Z;
                double n = kd * cos + ks * Math.Pow(2 * cos * N.Z - L.Z, m);
                double r = n * IL.R / 255 * IO.R / 255;
                double g = n * IL.G / 255 * IO.G / 255;
                double b = n * IL.B / 255 * IO.B / 255;
                if (r > 1) r = 1;
                if (g > 1) g = 1;
                if (b > 1) b = 1;
                if (r < 0) r = 0;
                if (g < 0) g = 0;
                if (b < 0) b = 0;
                return ((int)(r*255), (int)(g * 255), (int)(b * 255));
            }

            picture.FillWithColor(Color.White);
            if (detailed)
                for(int x=0;x<picture.Width;x++)
                    Parallel.For(0, picture.Height, (y) =>
                    {
                        var tmp = Calc(x, y);
                        if (reflekt)
                        {
                            var tmp2 = Calc(x, y, true);
                            int r = tmp.Item1 + tmp2.Item1;
                            int g = tmp.Item2 + tmp2.Item2;
                            int b = tmp.Item3 + tmp2.Item3;
                            if (r > 255) r = 255;
                            if (g > 255) g = 255;
                            if (b > 255) b = 255;
                            picture.SetPixel(x, y, Color.FromArgb(r, g, b));
                        }
                        else                       
                            picture.SetPixel(x, y, Color.FromArgb(tmp.Item1, tmp.Item2, tmp.Item3));
                    });
            else
            {
                for (int x = 0; x < mesh.GetLength(0); x++)
                    for (int y = 0; y < mesh.GetLength(1); y++)
                    {
                        var tmp = Calc(mesh[x, y].X, mesh[x, y].Y);
                        if (reflekt)
                        {
                            var tmp2 = Calc(mesh[x, y].X, mesh[x, y].Y, true);
                            int r = tmp.Item1 + tmp2.Item1;
                            int g = tmp.Item2 + tmp2.Item2;
                            int b = tmp.Item3 + tmp2.Item3;
                            if (r > 255) r = 255;
                            if (g > 255) g = 255;
                            if (b > 255) b = 255;
                            mesh[x, y].Color = Color.FromArgb(r, g, b);
                        }
                        else
                            mesh[x, y].Color = Color.FromArgb(tmp.Item1, tmp.Item2, tmp.Item3);
                    }
                Parallel.ForEach<Triangle>(triangles, (t) => {
                    t.InterpolateOnDirectBitmap(picture);
                });
            }
            if (showMeshradioButton.Checked)
                foreach (Triangle t in triangles)
                    t.PrintOnDirectBitmap(picture);
        }
        private void CreateClearBitmap(int width, int height)
        {
            picture= new DirectBitmap(width, height);
            pictureBox1.Image = picture.Bitmap;
            picture.FillWithColor(Color.White);
            pictureBox1.Refresh();

        }

        private void CreateNewMesh(int n,int m)
        {
            mesh = new MyPoint[n, m];
            double x=0, y=0,dx=(double)(picture.Width-1)/(n-1),dy=(double)(picture.Height-1)/(m-1);
      
            for (int i = 0; i < m; i++,y+=dy,x=0)
                for (int j = 0; j < n; j++,x+=dx)
                    mesh[j, i] = new MyPoint((int)x, (int)y);
        }
        private void lightColorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                lightColorButton.BackColor = colorDialog1.Color;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateClearBitmap(pictureBox1.Width, pictureBox1.Height);
            CreateNewMesh(5, 5);
            triangles = Triangle.CreateTrianglesFromMesh(mesh);
            originalPicture = new DirectBitmap(picture.Width, picture.Height);
            originalPicture.ReproducePicture(new Bitmap(System.IO.Directory.GetParent(Application.StartupPath).Parent.FullName+ "\\Sample Bitmaps\\Leica-M-Sample-Image.jpg"));
            normalMap = new DirectBitmap(picture.Width, picture.Height);
            normalMap.ReproducePicture(new Bitmap(System.IO.Directory.GetParent(Application.StartupPath).Parent.FullName + "\\Sample Normal Maps\\a03fc0c460dec4a47ee0794f1bc2c869.png"));
            backgroundWorker1.RunWorkerAsync();
            if(seperateLightSource)
                backgroundWorkerLsource.RunWorkerAsync();
        }

        private void bitmapLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = System.IO.Directory.GetParent(Application.StartupPath).Parent.FullName+"\\Sample Bitmaps";
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                originalPicture = new DirectBitmap(picture.Width, picture.Height);
                originalPicture.ReproducePicture(new Bitmap(fileDialog.FileName));
            }
        }

        private void normalMapLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = System.IO.Directory.GetParent(Application.StartupPath).Parent.FullName + "\\Sample Normal maps";
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                normalMap = new DirectBitmap(picture.Width, picture.Height);
                normalMap.ReproducePicture(new Bitmap(fileDialog.FileName));
            }
        }



        private void textureColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textureColorButton.BackColor = colorDialog1.Color;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int rmin = 60;
            double drmin = 2;
            double dt = 0.1;
            double radius = rmin;
            double rmax = picture.Height * 0.45;
            int x = picture.Width / 2;
            int y = picture.Height / 2;
            double t = 0;
            int s=1;
            double a = picture.Width / picture.Height;
            while (!backgroundWorker1.CancellationPending)
            {
                if (animating&&!seperateLightSource)
                {
                    light.X = x + Math.Cos(t) * radius * a;
                    light.Y = y + Math.Sin(t) * radius;
                    double dr = drmin * (rmin / radius) * s;
                    t += dt;
                    radius += dr;
                    if (radius > rmax) s *= (-1);
                    if (radius < rmin) s *= (-1);
                }
              
                    DrawLightenedPicture();
                    pictureBox1.Refresh();
                
                    
                System.Threading.Thread.Sleep(20);
            }
        }

        private void backgroundWorkerLsource_DoWork(object sender, DoWorkEventArgs e)
        {
            int rmin = 40;
            int dr = 1;
            double dt = 0.02;
            int radius = rmin;
            int rmax = picture.Height / 2;
            int x = picture.Width / 2;
            int y = picture.Height / 2;
            double t = 0;
            double a = picture.Width / picture.Height;
            while (!backgroundWorkerLsource.CancellationPending)
            {
                if (animating)
                {
                    light.X = x + Math.Cos(t) * radius * a;
                    light.Y = y + Math.Sin(t) * radius;
                    t += dt;
                    radius += dr;
                    if (radius > rmax) dr *= (-1);
                    if (radius < rmin) dr *= (-1);
                }

                System.Threading.Thread.Sleep(20);
            }
        }

        private void kdSlider_Scroll(object sender, EventArgs e)
        {
            kdLabel.Text = "kd = " + (float)kdSlider.Value / kdSlider.Maximum;
            //DrawLightenedPicture();
            //pictureBox1.Refresh();
        }

        private void ksSlider_Scroll(object sender, EventArgs e)
        {
            ksLabel.Text = "ks = " + (float)ksSlider.Value / ksSlider.Maximum;
        }

        private void mSlider_Scroll(object sender, EventArgs e)
        {
            mLabel.Text = "m = " + mSlider.Value;
        }



        private void staticLightButton_Click(object sender, EventArgs e)
        {
            animating = false;
        }

        private void animatedLightButton_Click(object sender, EventArgs e)
        {
            animating = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int x = 0; x < mesh.GetLength(0); x++)
                for (int y = 0; y < mesh.GetLength(1); y++)
                    if(mesh[x,y].IsInside(e.Location))
                    {
                        movedPoint = mesh[x, y];
                        return;
                    }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (movedPoint != null)
            {
                movedPoint.Point = e.Location;
                if (movedPoint.Point.X < 0) movedPoint.Point.X = 0;
                if (movedPoint.Point.Y < 0) movedPoint.Point.Y = 0;
                if (movedPoint.Point.X > picture.Width) movedPoint.Point.X = picture.Width-1;
                if (movedPoint.Point.Y > picture.Height) movedPoint.Point.Y = picture.Height-1;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            movedPoint = null;
        }

        private void recreateMeshButton_Click(object sender, EventArgs e)
        {
            CreateNewMesh((int)numericUpDownX.Value,(int)numericUpDownY.Value );
            triangles = Triangle.CreateTrianglesFromMesh(mesh);
        }
        private void ReInitialize()
        {
            if (seperateLightSource)
                backgroundWorkerLsource.CancelAsync();
            else backgroundWorker1.CancelAsync();
            CreateClearBitmap(pictureBox1.Width, pictureBox1.Height);
            CreateNewMesh((int)numericUpDownX.Value, (int)numericUpDownY.Value);
            triangles = Triangle.CreateTrianglesFromMesh(mesh);
            Bitmap tmp = originalPicture.Bitmap;
            originalPicture = new DirectBitmap(picture.Width, picture.Height);
            originalPicture.ReproducePicture(tmp);
            tmp = normalMap.Bitmap;
            normalMap = new DirectBitmap(picture.Width, picture.Height);
            normalMap.ReproducePicture(tmp);
            if (seperateLightSource)
            {
                while (backgroundWorkerLsource.IsBusy)
                    Application.DoEvents();
                backgroundWorkerLsource.RunWorkerAsync();
            }
            else
            {
                while (backgroundWorker1.IsBusy)
                    Application.DoEvents();
                backgroundWorker1.RunWorkerAsync();
            }
        }

    }
}
