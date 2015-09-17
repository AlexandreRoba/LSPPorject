namespace LSPProject
{
    public class Square : Rectangle
    {
        private int _height;
        private int _width;

        public override int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _height = value;
            }
        }

        public override int Height
        {
            get { return _height; }
            set
            {
                _width = value;
                _height = value;
            }
        }
    }
}