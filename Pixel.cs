namespace _3dconsole
{
    public struct Pixel
    {
        public Pixel(uint y, uint x)
        {
            X = x;
            Y = y;
        }
        public uint X {get; set;}
        public uint Y {get; set;}

        public static Pixel operator +(Pixel a, Pixel b) => new Pixel(a.Y + b.Y, a.X + b.X);
        public static Pixel operator -(Pixel a, Pixel b) => new Pixel(a.Y - b.Y, a.X - b.X);
        public static Pixel operator *(Pixel a, Pixel b) => new Pixel(a.Y * b.Y, a.X * b.X);
        public static Pixel operator /(Pixel a, Pixel b) => new Pixel(a.Y / b.Y, a.X / b.X);

        public void Set(char[,] screen, char ch) => screen[this.Y, this.X] = ch;
    }
}
