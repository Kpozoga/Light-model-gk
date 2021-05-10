using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gk_zad2
{  
    public class Triangle
    {
        public MyPoint A { set; get; }
        public MyPoint B { set; get; }
        public MyPoint C { set; get; }

        private readonly bool properInterpolation = true; //po wyłączeniu zastąpia interpolacje prostym wypełnieniem trójkąta jednym kolorem
        public Triangle(MyPoint a,MyPoint b, MyPoint c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void PrintOnDirectBitmap(DirectBitmap map)
        {
            Graphics graph = Graphics.FromImage(map.Bitmap);
            graph.DrawLines(new Pen(Brushes.Black),new Point[] {A.Point,B.Point,C.Point });
            graph.DrawImage(map.Bitmap,map.Width,map.Height);
        }
        public void InterpolateOnDirectBitmap(DirectBitmap map)
        {
            Dictionary<int, List<AETNode>> ET = new Dictionary<int, List<AETNode>>();
            List<AETNode> AET = new List<AETNode>();
            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(A.Point, B.Point));
            edges.Add(new Edge(B.Point, C.Point));
            edges.Add(new Edge(C.Point, A.Point));
            int yMIN=int.MaxValue,yMAX=int.MinValue;
            foreach(Edge e in edges)
            {
                int ymin,ymax, x;
                double ra;
                if(e.A.Y < e.B.Y)
                {
                    ymin = e.A.Y;
                    ymax = e.B.Y;
                    x = e.A.X;
                    ra = (double)(e.B.X - x)/(ymax-ymin);
                }
                else
                {
                    ymin = e.B.Y;
                    ymax = e.A.Y;
                    x = e.B.X;
                    ra = (double)(e.A.X - x) / (ymax - ymin);
                }
                if (ymin < yMIN) yMIN = ymin;
                if (ymax > yMAX) yMAX = ymax;
                if(!ET.ContainsKey(ymin))
                    ET.Add(ymin, new List<AETNode>());
                ET[ymin].Add(new AETNode(ymax, x, ra));
            }
            for(int y=yMIN;y<yMAX;y++)
            {
                if(ET.ContainsKey(y))
                    foreach(AETNode node in ET[y])
                        AET.Add(node);
                AET.Sort((AETNode b, AETNode a) => { return (int)b.x - (int)a.x; });

                if(properInterpolation)
                    //Parallel.For((int)AET[0].x, (int)AET[AET.Count - 1].x, (x) =>
                    for(int x=(int)AET[0].x; x<AET[AET.Count - 1].x;x++)
                    {
                        //int xca = C.X - A.X;      //próba rozwiązania układu równań
                        //int yca = C.Y - A.Y;
                        //int xba = B.X - A.X;
                        //if (xca == 0) continue;
                        //int m = xca * (B.X - A.Y) - yca * (B.X - A.X);
                        //if (m == 0) continue;
                        //double b = (xca * (y - A.Y) - yca * (x - A.X)) / (m);
                        //double c = (x - A.X - b * xba) / xca;
                        //double a = 1 - b - c;
                        double TriangleArea(Point A, Point B, Point C)
                        {
                            return Math.Abs((B.X - A.X) * (C.Y - A.Y) - (B.Y - A.Y) * (C.X - A.X)) / 2;
                        }
                        double a = TriangleArea(new Point(x,y), B.Point, C.Point);
                        double b = TriangleArea(new Point(x, y), A.Point, C.Point);
                        double c = TriangleArea(new Point(x, y), A.Point, B.Point);
                        double n = a + b + c;
                        if (!double.IsNaN(a) && !double.IsNaN(b) && !double.IsNaN(c))
                            map.SetPixel(x, y, Color.FromArgb((int)((A.Color.R * a + B.Color.R * b + C.Color.R * c)/n),
                              (int)((A.Color.G * a + B.Color.G * b + C.Color.G * c)/n),
                              (int)((A.Color.B * a + B.Color.B * b + C.Color.B * c)/n)));
                        else
                        {
                            //map.SetPixel(x, y, map.GetPixel(x, y-1));
                            map.SetPixel(x, y, A.Color);
                        }
                    }
                else for(int x=(int)AET[0].x; x<AET[AET.Count - 1].x; x++)
                        map.SetPixel(x, y, C.Color);

                for (int i=AET.Count-1;i>=0;i--)
                    if (AET[i].ymax == y)
                        AET.Remove(AET[i]);
                foreach (AETNode node in AET)
                    node.x += node.ra;
            }
        }
        public static IEnumerable<Triangle> CreateTrianglesFromMesh(MyPoint[,] mesh)
        {
            List<Triangle> triangles = new List<Triangle>();
            for(int x=0;x<mesh.GetLength(0)-1;x++)
                for (int y = 0; y < mesh.GetLength(1) - 1; y++)
                {
                    triangles.Add(new Triangle(mesh[x, y + 1], mesh[x + 1, y], mesh[x, y]));
                    triangles.Add(new Triangle(mesh[x, y + 1], mesh[x + 1, y+1], mesh[x+1, y]));
                }
            return triangles;
        }
        private struct Edge
        {
            public Point A { get; private set; }
            public Point B { get; private set; }
            public Edge(Point a,Point b)
            {
                A = a;
                B = b;
            }
        }
        private class AETNode
        {
            public int ymax;
            public double x;
            public double ra;
            public AETNode(int ym,int x,double ra)
            {
                ymax = ym;
                this.x = x;
                this.ra = ra;
            }
        }
    }
}
