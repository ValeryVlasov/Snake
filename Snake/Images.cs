using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {
        //public readonly static ImageSource Empty = LoadImage("Empty.png");
        //public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource SnakeHead = LoadImage("SnakeHead.png");
        public readonly static ImageSource SnakeBody = LoadImage("SnakeBody.png");
        public readonly static ImageSource SnakeLogo = LoadImage("Snake.png");
        public readonly static ImageSource Food = LoadImage("FoodApple.png");
        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }
    }
}
