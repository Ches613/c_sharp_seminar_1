namespace Values
{
    // структура для хранения и передачи значений
    public struct LinesValue
    {
        public LinesValue(double b1, double k1, double b2, double k2, double b3, double k3)
        {
            B1 = b1;
            K1 = k1;
            B2 = b2;
            K2 = k2;
            B3 = b3;
            K3 = k3;
        }

        public double B1 { get; }
        public double K1 { get; }
        public double B2 { get; }
        public double K2 { get; }
        public double B3 { get; }
        public double K3 { get; }

        public override string ToString() => $"(b1 = {B1}; k1 = {K1}; b2 = {B2}; k2 = {K2}; b3 = {B3}; k3 = {K3};)";
    }


    // структура для хранения координат точки пересечения
    public struct PointCoord
    {
        public PointCoord(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString() => $"{X} {Y})";
    }
}