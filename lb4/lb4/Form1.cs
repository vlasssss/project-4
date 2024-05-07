using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lb4
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Draw();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Tringle_Click(object sender, EventArgs e)
        {

        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(207, 272);
            Graphics graph = Graphics.FromImage(bmp);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen1 = new Pen(Color.Black, 2);
            Pen pen2 = new Pen(Color.Black, 1);
            pen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            // Draw outer circle
            graph.DrawEllipse(pen1, 20, 20, 166, 166);

            // Draw ticks
            int radius = 78;
            double angle;
            int x1, y1, x2, y2;
            for (int i = 0; i < 360; i += 2)
            {
                angle = i * Math.PI / 180;
                x1 = (int)(Math.Cos(angle) * (radius + 5) + 103);
                y1 = (int)(Math.Sin(angle) * (radius + 5) + 103);
                x2 = (int)(Math.Cos(angle) * (radius - 5) + 103);
                y2 = (int)(Math.Sin(angle) * (radius - 5) + 103);
                graph.DrawLine(pen2, x1, y1, x2, y2);

                if (i % 20 == 0)
                {
                    int labelRadius = radius - 15;
                    int labelX = (int)(Math.Cos(angle) * labelRadius + 103);
                    int labelY = (int)(Math.Sin(angle) * labelRadius + 103);
                    string speed = (i / 2).ToString();
                    Font font = new Font("Arial", 8);
                    Brush brush = Brushes.Black;
                    SizeF speedSize = graph.MeasureString(speed, font);
                    graph.DrawString(speed, font, brush, labelX - speedSize.Width / 2, labelY - speedSize.Height / 2);
                }
            }

            // Draw speedometer needle
            int needleLength = 60;
            angle = 90 * Math.PI / 180;
            int x3 = (int)(Math.Cos(angle) * needleLength + 103);
            int y3 = (int)(Math.Sin(angle) * needleLength + 103);
            graph.DrawLine(pen1, x3, y3, 103, 103);


            // Set image to PictureBox
            Speed.Image = bmp;
        }
        private void run_Click(object sender, EventArgs e)
        {
            string V1astr, V2bstr;

            V1astr = V1aIn.Text;
            V2bstr = V2bIn.Text;

            double del = 3.6;

            double V1a, V1b, V2a, V2b;

            if (double.TryParse(V1astr, out V1a) && double.TryParse(V2bstr, out V2b))
            {
                V1b = V1a * del;

                V1bIn.Text = V1b.ToString();

                V2a = V2b / del;

                V2aIn.Text = V2a.ToString();

                if (V1b > V2b)
                {
                    result.Text = " V1 > V2 ";
                }
                else if (V1a < V1b)
                {
                    result.Text = " V1 < V2 ";
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода. Пожалуйста, введите только цифры.");
            }


        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Відомі дві швидкості, одна за в кілометрахза годину, інша вметрахза секунду. \nЯка з них більша? У разі некоректного введення прийняти число рівним0.\n Ходаківський Владислав КН21");
        }

        private void V2aIn_TextChanged(object sender, EventArgs e)
        {
            V2aIn.ReadOnly = true;
        }

        private void V1bIn_TextChanged(object sender, EventArgs e)
        {
            V1bIn.ReadOnly = true;
        }
    }


}
