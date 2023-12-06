namespace Inheritance
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public abstract class Figure
    {
        protected int _centerX;
        protected int _centerY;                

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        
        public void MoveRight()
        {
            for (int i = 0; i < 50; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(100);
                HideDrawingBackGround();
                _centerX++;
            }
        }
    }
}