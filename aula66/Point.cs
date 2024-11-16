namespace aula66;

struct Point {
    public double X;
    public double Y;

    public override string ToString()
    {
        return string.Format("({0}, {1})", X, Y);
    }
}