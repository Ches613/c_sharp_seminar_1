namespace Values
{
    // структура для хранения и передачи значений
    public struct LineValues
    {
        public LineValues(double b1, double k1, double b2, double k2)
        {
            B1 = b1;
            K1 = k1;
            B2 = b2;
            K2 = k2;
        }

        public double B1 { get; }
        public double K1 { get; }
        public double B2 { get; }
        public double K2 { get; }

        public override string ToString() => $"(b1 = {B1}; k1 = {K1}; b2 = {B2}; k2 = {K2};)";
    }


    // структура для хранения координат точки пересечения
    public struct PointCoordinates
    {
        public PointCoordinates(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString() => $"{X} {Y})";
    }
}