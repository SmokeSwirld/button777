
namespace button777
{
    public partial class Form1 : Form
    {

        Button buttonOK = new Button();

        public Form1()
        {
            Size = new Size(870, 670);
            buttonOK.Size = new Size(70, 70);
            buttonOK.Text = "@";
            buttonOK.BackColor = Color.Bisque;
            Controls.Add(buttonOK);
            buttonOK.Location = new Point(10, 100);
            this.MouseMove += Form1_MouseMove;

        }
        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.X == (buttonOK.Location.X + 70) || e.X == (buttonOK.Location.X-1)
             || e.Y == (buttonOK.Location.Y + 70) || e.Y == (buttonOK.Location.Y-1))
            {              
                int x = new Random().Next(0, 800);
                int y = new Random().Next(0, 600);
                buttonOK.Location = new Point(x, y);
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

    }
}