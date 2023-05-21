namespace PointsInsidePolygon
{
    public class Solver
    {
        private readonly List<PointF> left;
        private readonly List<PointF> right;

        static float PositionWrtLine(PointF down, PointF up, PointF point) =>
            (point.X - down.X) * (up.Y - down.Y) -
            (point.Y - down.Y) * (up.X - down.X);

        public Solver(List<PointF> polygon)
        {
            left = new List<PointF>();
            right = new List<PointF>();
            if (polygon.Count == 0)
                return;
            int down = 0, up = 0;
            for (int i = 1; i < polygon.Count; i++)
            {
                if (polygon[i].Y < polygon[down].Y)
                    down = i;
                if (polygon[i].Y >= polygon[up].Y)
                    up = i;
            }
            if (down < up)
            {
                for (int i = down; i <= up; i++)
                    left.Add(polygon[i]);
                for (int i = down; i >= 0; i--)
                    right.Add(polygon[i]);
                for (int i = polygon.Count - 1; i >= up; i--)
                    right.Add(polygon[i]);
            }
            else
            {
                for (int i = down; i >= up; i--)
                    left.Add(polygon[i]);
                for (int i = down; i < polygon.Count; i++)
                    right.Add(polygon[i]);
                for (int i = 0; i <= up; i++)
                    right.Add(polygon[i]);
            }
            if (left.Average(point => PositionWrtLine(polygon[down], polygon[up], point)) >
                right.Average(point => PositionWrtLine(polygon[down], polygon[up], point)))
                (left, right) = (right, left);
        }

        private enum RelativePosition { ON_CHAIN, TO_LEFT, TO_RIGHT, NONE }

        private static RelativePosition Where(List<PointF> chain, PointF point)
        {
            const float EPS = 1e-5F;
            if (chain.Count == 0)
                return RelativePosition.NONE;
            if (point.Y < chain[0].Y || point.Y > chain[^1].Y)
                return RelativePosition.NONE;
            int l = 0, r = chain.Count - 1;
            while (r - l > 1)
            {
                int m = (l + r) / 2;
                if (chain[m].Y < point.Y)
                    l = m;
                else
                    r = m;
            }
            float pos = PositionWrtLine(chain[l], chain[r], point);
            return
                pos < -EPS || point.X < Math.Min(chain[l].X, chain[r].X) - EPS ? RelativePosition.TO_LEFT :
                pos > EPS || point.X > Math.Max(chain[l].X, chain[r].X) + EPS ? RelativePosition.TO_RIGHT :
                RelativePosition.ON_CHAIN;
        }

        public bool Inside(PointF point)
        {
            RelativePosition left_res = Where(left, point);
            RelativePosition right_res = Where(right, point);
            return
                left_res != RelativePosition.NONE &&
                right_res != RelativePosition.NONE &&
                left_res != RelativePosition.TO_LEFT &&
                right_res != RelativePosition.TO_RIGHT;
        }
    }
}
