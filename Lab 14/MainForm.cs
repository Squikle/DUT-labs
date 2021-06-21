using System.Drawing;
using System.Windows.Forms;


namespace Lab_14
{
    public partial class MainForm : Form
    {
        private const int TOTAL_TITLE_FLASHES = 8;
        private const int SHIFT = 20;
        
        private bool _isTitleActive = true;
        private int _x;
        private int _y;
        private int _countOfTitleFlashing;
        private bool _isGameOver;
        public MainForm()
        {
            InitializeComponent();
            CreateAreas();
            UpdatePanelPosition();
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            MousePositionLabel.Text = $"({e.X},{e.Y}) ({OKButton.Location.X},{OKButton.Location.Y})";
            _x = e.X;
            _y = e.Y;
        }
        private void CreateAreas()
        {
            Color color = Color.Transparent;
            int size = 20;
            Panel[] panels = {
                new() { Size = new Size(size,size), BackColor = color, Tag = 0},
                new() { Size = new Size(OKButton.Size.Width,size), BackColor = color, Tag = 1},
                new() { Size = new Size(size,size), BackColor = color, Tag = 2},
                new() { Size = new Size(size,OKButton.Size.Height), BackColor = color, Tag = 3},
                new() { Size = new Size(size,size), BackColor = color, Tag = 4},
                new() { Size = new Size(OKButton.Size.Width,size), BackColor = color, Tag = 5},
                new() { Size = new Size(size,size), BackColor = color, Tag = 6},
                new() { Size = new Size(size,OKButton.Size.Height), BackColor = color, Tag = 7}
            };

            foreach (Panel panel in panels) {
                panel.MouseMove += Panel_MouseMove;
                Controls.Add(panel);
            }
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is not Panel panel) {
                return;
            }
            
            OKButton.Location = GetNewLocation((int)panel.Tag);

            if (OKButton.Location.X + OKButton.Size.Width <= Size.Width) {
                if (OKButton.Location.X < 0) {
                    OKButton.Location = new Point(_x + OKButton.Size.Width, _y);
                }
                else if (OKButton.Location.Y < 0) {
                    OKButton.Location = new Point(_x, _y + OKButton.Size.Height);
                }
                else if (OKButton.Location.Y + OKButton.Size.Height > Size.Height) {
                    OKButton.Location = new Point(_x, _y - OKButton.Size.Height);
                }
            }
            else {
                OKButton.Location = new Point(_x - OKButton.Size.Width, _y);
            }

            UpdatePanelPosition();
            OKButton.Size = new Size(OKButton.Size.Width - 1, OKButton.Size.Height - 1);

            if (OKButton.Size.Height != 0 || _isGameOver) {
                return;
            }
            
            Timer.Tick -= Timer_Tick;
            Timer.Tick += Timer_Tick_Lose;
            Timer.Interval = 800;
            _isGameOver = true;
            Timer.Start();
        }
        
        private void UpdatePanelPosition()
        {
            Point[] points = {
                new(OKButton.Location.X - SHIFT, OKButton.Location.Y - SHIFT),
                new(OKButton.Location.X, OKButton.Location.Y - SHIFT),
                new(OKButton.Location.X + OKButton.Size.Width, OKButton.Location.Y - SHIFT),
                new(OKButton.Location.X + OKButton.Size.Width, OKButton.Location.Y),
                new(OKButton.Location.X + OKButton.Size.Width, OKButton.Location.Y + OKButton.Size.Height),
                new(OKButton.Location.X, OKButton.Location.Y + OKButton.Size.Height),
                new(OKButton.Location.X - SHIFT, OKButton.Location.Y + OKButton.Size.Height),
                new(OKButton.Location.X - SHIFT, OKButton.Location.Y)
            };

            foreach (Control control in Controls) {
                if (control is Panel panel) {
                    panel.Location = points[(int)panel.Tag];
                }
            }
        }
        
        private Point GetNewLocation(int area)
        {
            return area switch {
                0 => new Point(OKButton.Location.X + SHIFT, OKButton.Location.Y + SHIFT),
                1 => new Point(OKButton.Location.X, OKButton.Location.Y + SHIFT),
                2 => new Point(OKButton.Location.X - SHIFT, OKButton.Location.Y + SHIFT),
                3 => new Point(OKButton.Location.X - SHIFT, OKButton.Location.Y),
                4 => new Point(OKButton.Location.X - SHIFT, OKButton.Location.Y - SHIFT),
                5 => new Point(OKButton.Location.X, OKButton.Location.Y - SHIFT),
                6 => new Point(OKButton.Location.X + SHIFT, OKButton.Location.Y - SHIFT),
                7 => new Point(OKButton.Location.X + SHIFT, OKButton.Location.Y),
                _ => new Point(0, 0)
            };
        }
        
        private void Timer_Tick_Lose(object sender, System.EventArgs e)
        {
            if (!_isTitleActive) {
                Text = "Кнопку “Ок” неможливо натиснути";
                _isTitleActive = !_isTitleActive;
            }
            else {
                Text = string.Empty;
                _isTitleActive = !_isTitleActive;
            }
        }
        
        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is not Button) {
                return;
            }
            OKButton.Location = new Point(OKButton.Location.X + 30, OKButton.Location.Y + 30);
            UpdatePanelPosition();
            OKButton.Size = new Size(OKButton.Size.Width - 1, OKButton.Size.Height - 1);
        }
        
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            Timer.Tick += Timer_Tick;
            Timer.Interval = 800;
            Timer.Start();
        }
        
        private void Timer_Tick(object sender, System.EventArgs e)
        {
            if (!_isTitleActive) {
                Text = "Натисніть на кнопку “Ок”";
                _isTitleActive = !_isTitleActive;
            }
            else {
                Text = "";
                _isTitleActive = !_isTitleActive;
            }

            if(_countOfTitleFlashing == TOTAL_TITLE_FLASHES) {
                Text = "Натисніть на кнопку “Ок”";
                _countOfTitleFlashing = 0;
                Timer.Stop();
            }
            
            _countOfTitleFlashing++;
        }
        
        private void ExitButton_Click(object sender, System.EventArgs e)
            => Close();
    }
}