using System.Globalization;

namespace PointsInsidePolygon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelLeft_SizeChanged(panelLeft, new EventArgs { });
        }

        private void panelLeft_SizeChanged(object sender, EventArgs e)
        {
            int res = panelLeft.Height;
            foreach (var obj in panelLeft.Controls.OfType<Control>())
                if (obj is not TextBox)
                    res -= obj.Height;
            textBoxPolygon.Height = res / 2;
        }

        bool drawingPolygon = false;
        bool drawingPoints = false;
        float X1 = -10, X2 = 10, Y1 = -10, Y2 = 10;
        Solver? solver = null;

        (float x1, float x2, float y1, float y2) visibleArea()
        {
            float x0 = (X1 + X2) / 2, y0 = (Y1 + Y2) / 2;
            float w = Math.Max(X2 - X1, (Y2 - Y1) / panelDraw.Height * panelDraw.Width) * 1.01F;
            float h = Math.Max(Y2 - Y1, (X2 - X1) / panelDraw.Width * panelDraw.Height) * 1.01F;
            float x1 = x0 - w / 2, x2 = x0 + w / 2, y1 = y0 - h / 2, y2 = y0 + h / 2;
            return (x1, x2, y1, y2);
        }

        (float x, float y) pointToPosition(PointF point)
        {
            var (x1, x2, y1, y2) = visibleArea();
            return ((point.X - x1) / (x2 - x1) * panelDraw.Width,
                    (point.Y - y2) / (y1 - y2) * panelDraw.Height);
        }

        PointF positionToPoint(int x, int y)
        {
            var (x1, x2, y1, y2) = visibleArea();
            return new(x1 + (x2 - x1) * x / panelDraw.Width,
                       y2 + (y1 - y2) * y / panelDraw.Height);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            redraw();
        }

        List<PointF> polygon = new List<PointF>();

        private void buttonDrawPolygon_Click(object sender, EventArgs e)
        {
            if (drawingPoints)
                buttonDrawPoints_Click(buttonDrawPoints, new EventArgs());
            if(drawingPolygon)
            {
                drawingPolygon = false;
                buttonDrawPolygon.Text = "намалювати";
                solver = new(polygon);
                redraw();
            }
            else
            {
                drawingPolygon = true;
                buttonDrawPolygon.Text = "закінчити малювання";
                solver = null;
                textBoxPolygon.Clear();
            }
        }

        private void buttonDrawPoints_Click(object sender, EventArgs e)
        {
            if (drawingPolygon)
                buttonDrawPolygon_Click(buttonDrawPolygon, new EventArgs());
            if (drawingPoints)
                buttonDrawPoints.Text = "намалювати";
            else
                buttonDrawPoints.Text = "закінчити малювання";
            drawingPoints = !drawingPoints;
        }

        List<PointF> points = new List<PointF>();

        void writePolygon()
        {
            textBoxPolygon.Lines = (from point in polygon select 
                                    point.X.ToString(CultureInfo.InvariantCulture) + " " +
                                    point.Y.ToString(CultureInfo.InvariantCulture)).ToArray();
        }

        void updateBounds()
        {
            var (x1, x2, y1, y2) = visibleArea();
            float x1_ = -10, x2_ = 10, y1_ = -10, y2_ = 10;
            foreach (var point in points)
            {
                x1_ = Math.Min(x1_, point.X);
                x2_ = Math.Max(x2_, point.X);
                y1_ = Math.Min(y1_, point.Y);
                y2_ = Math.Max(y2_, point.Y);
            }
            foreach (var point in polygon)
            {
                x1_ = Math.Min(x1_, point.X);
                x2_ = Math.Max(x2_, point.X);
                y1_ = Math.Min(y1_, point.Y);
                y2_ = Math.Max(y2_, point.Y);
            }
            if (x1_ < x1 || x2_ > x2)
                (X1, X2) = (x1_, x2_);
            else if (x1_ < X1 || x2_ > X2)
            {
                float x0 = (x1 + x2) / 2;
                float w = 2 * Math.Max(x0 - x1_, x2_ - x0);
                X1 = x0 - w / 2;
                X2 = x0 + w / 2;
            }
            else if (x2_ - x1_ < (X2 - X1) / 2)
                (X1, X2) = (x1_, x2_);
            if (y1_ < y1 || y2_ > y2)
                (Y1, Y2) = (y1_, y2_);
            else if (y1_ < Y1 || y2_ > Y2)
            {
                float y0 = (y1 + y2) / 2;
                float w = 2 * Math.Max(y0 - y1_, y2_ - y0);
                Y1 = y0 - w / 2;
                Y2 = y0 + w / 2;
            }
            else if (y2_ - y1_ < (Y2 - Y1) / 2)
                (Y1, Y2) = (y1_, y2_);
        }

        private void textBoxPolygon_TextChanged(object sender, EventArgs e)
        {
            polygon.Clear();
            foreach(var line in textBoxPolygon.Lines)
            {
                var items = line.Replace(',', '.').Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);
                if (items.Length == 2 &&
                    float.TryParse(items[0], NumberStyles.Any, CultureInfo.InvariantCulture, out float x) &&
                    float.TryParse(items[1], NumberStyles.Any, CultureInfo.InvariantCulture, out float y))
                    polygon.Add(new PointF(x, y));
            }
            if (!drawingPolygon)
                solver = new(polygon);
            updateBounds();
            redraw();
        }

        private void textBoxPoints_TextChanged(object sender, EventArgs e)
        {
            points.Clear();
            foreach (var line in textBoxPoints.Lines)
            {
                var items = line.Replace(',', '.').Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);
                if (items.Length == 2 &&
                    float.TryParse(items[0], NumberStyles.Any, CultureInfo.InvariantCulture, out float x) &&
                    float.TryParse(items[1], NumberStyles.Any, CultureInfo.InvariantCulture, out float y))
                    points.Add(new PointF(x, y));
            }
            updateBounds();
            redraw();
        }

        private void buttonClearPoints_Click(object sender, EventArgs e)
        {
            textBoxPoints.Clear();
        }

        static Random random = new Random();

        private void buttonGeneratePoints_Click(object sender, EventArgs e)
        {
            int n = (int)Math.Round(numericUpDownGeneratePoints.Value, MidpointRounding.AwayFromZero);
            points = (from i in Enumerable.Range(0, n)
                      select new PointF((float)(random.NextDouble() * (X2 - X1) + X1),
                                        (float)(random.NextDouble() * (Y2 - Y1) + Y1))).ToList();
            writePoints();
        }

        private void buttonGeneratePolygon_Click(object sender, EventArgs e)
        {
            if (drawingPolygon)
                buttonDrawPolygon_Click(buttonDrawPolygon, new EventArgs());
            int n = (int)Math.Round(numericUpDownGeneratePolygon.Value, MidpointRounding.AwayFromZero);
            List<float> xPool = new List<float>();
            List<float> yPool = new List<float>();
            for (int i = 0; i < n; i++)
            {
                xPool.Add((float)random.NextDouble() * (X2 - X1) + X1);
                yPool.Add((float)random.NextDouble() * (Y2 - Y1) + Y1);
            }
            xPool.Sort();
            yPool.Sort();
            float minX = xPool[0];
            float maxX = xPool[n - 1];
            float minY = yPool[0];
            float maxY = yPool[n - 1];
            List<float> xVec = new List<float>();
            List<float> yVec = new List<float>();
            float lastTop = minX, lastBot = minX;
            for (int i = 1; i < n - 1; i++)
            {
                float cur = xPool[i];
                if (random.NextInt64() % 2 == 1)
                {
                    xVec.Add(cur - lastTop);
                    lastTop = cur;
                }
                else
                {
                    xVec.Add(lastBot - cur);
                    lastBot = cur;
                }
            }
            xVec.Add(maxX - lastTop);
            xVec.Add(lastBot - maxX);
            float lastLeft = minY, lastRight = minY;
            for (int i = 1; i < n - 1; i++)
            {
                float cur = yPool[i];
                if (random.NextInt64() % 2 == 1)
                {
                    yVec.Add(cur - lastLeft);
                    lastLeft = cur;
                }
                else
                {
                    yVec.Add(lastRight - cur);
                    lastRight = cur;
                }
            }
            yVec.Add(maxY - lastLeft);
            yVec.Add(lastRight - maxY);
            for(int i=1;i<yVec.Count;i++)
            {
                int j = (int)(random.NextInt64() % (i + 1));
                (yVec[i], yVec[j]) = (yVec[j], yVec[i]);
            }
            List<PointF> vec = new List<PointF>();
            for (int i = 0; i < n; i++)
                vec.Add(new PointF(xVec[i], yVec[i]));
            vec.Sort((v1, v2) => Math.Atan2(v1.Y, v1.X).CompareTo(Math.Atan2(v2.Y, v2.X)));
            float x = 0, y = 0;
            float minPolygonX = 0;
            float minPolygonY = 0;
            float maxPolygonX = 0;
            float maxPolygonY = 0;
            polygon = new List<PointF>();
            for (int i = 0; i < n; i++)
            {
                polygon.Add(new PointF(x, y));
                x += vec[i].X;
                y += vec[i].Y;
                minPolygonX = Math.Min(minPolygonX, x);
                minPolygonY = Math.Min(minPolygonY, y);
                maxPolygonX = Math.Max(maxPolygonX, x);
                maxPolygonY = Math.Max(maxPolygonY, y);
            }
            SizeF shift = new SizeF(minX - minPolygonX, minY - minPolygonY);
            for (int i = 0; i < n; i++)
                polygon[i] += shift;
            writePolygon();
        }

        void writePoints()
        {
            textBoxPoints.Lines = (from point in points select
                                   point.X.ToString(CultureInfo.InvariantCulture) + " " +
                                   point.Y.ToString(CultureInfo.InvariantCulture)).ToArray();
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            PointF p = positionToPoint(e.X, e.Y);
            if (drawingPolygon)
            {
                polygon.Add(p);
                writePolygon();
            }
            if (drawingPoints)
            {
                points.Add(p);
                writePoints();
            }
        }

        void redraw()
        {
            if (panelDraw.Width == 0 || panelDraw.Height == 0)
                return;
            using Bitmap buffer = new Bitmap(panelDraw.Width, panelDraw.Height);
            using Graphics g = Graphics.FromImage(buffer);
            g.Clear(Color.White);
            const float r = 3;
            foreach (var point in polygon)
            {
                var (x, y) = pointToPosition(point);
                g.FillEllipse(Brushes.Black, x - r, y - r, 2 * r, 2 * r);
            }
            foreach (var point in points)
            {
                var (x, y) = pointToPosition(point);
                g.FillEllipse(
                    solver is null ? Brushes.Blue : solver.Inside(point) ? Brushes.LimeGreen : Brushes.Red,
                    x - r, y - r, 2 * r, 2 * r);
            }
            for (int i = 0; i < polygon.Count; i++)
            {
                var (xa, ya) = pointToPosition(polygon[i]);
                var (xb, yb) = pointToPosition(polygon[(i + 1) % polygon.Count]);
                g.DrawLine(drawingPolygon && i == polygon.Count - 1 && polygon.Count >= 3 ? Pens.LightGray : Pens.Black, xa, ya, xb, yb);
            }
            using Graphics panelGraphics = panelDraw.CreateGraphics();
            panelGraphics.DrawImageUnscaled(buffer, 0, 0);
        }
    }
}