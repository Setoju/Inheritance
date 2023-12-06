namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Square sq = new Square(90, 90, 60);
            sq.MoveRight();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Rhomb rb = new Rhomb(90, 90 , 40, 60);
            rb.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Circle cr = new Circle(90, 90, 40);
            cr.MoveRight();
        }
    }
}