namespace OOP_lab5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.Text = "Figure Animation";
            this.Width = 800;
            this.Height = 600;

            Button circleButton = new Button
            {
                Text = "Create Circle",
                Location = new System.Drawing.Point(10, 10),
                Width = 120 
            };
            circleButton.Click += (sender, e) =>
            {
                Circle circle = new Circle(100, 200, 50, this);
                circle.MoveRight();
            };

            Button squareButton = new Button
            {
                Text = "Create Square",
                Location = new System.Drawing.Point(10, 40),
                Width = 120
            };
            squareButton.Click += (sender, e) =>
            {
                Square square = new Square(100, 200, 100, this);
                square.MoveRight();
            };

            Button rhombButton = new Button
            {
                Text = "Create Rhomb",
                Location = new System.Drawing.Point(10, 70),
                Width = 120
            };
            rhombButton.Click += (sender, e) =>
            {
                Rhomb rhomb = new Rhomb(100, 200, 120, 80, this);
                rhomb.MoveRight();
            };

            Button triangleButton = new Button
            {
                Text = "Create Triangle",
                Location = new System.Drawing.Point(10, 100),
                Width = 120
            };
            triangleButton.Click += (sender, e) =>
            {
                Triangle triangle = new Triangle(100, 200, 100, this);
                triangle.MoveRight();
            };

            this.Controls.Add(circleButton);
            this.Controls.Add(squareButton);
            this.Controls.Add(rhombButton);
            this.Controls.Add(triangleButton);
        }
    }
}
