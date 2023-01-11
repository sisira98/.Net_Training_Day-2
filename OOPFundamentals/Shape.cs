
    abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

    public virtual double CalculateArea()
    {
        return Height * Width;
    }
}

