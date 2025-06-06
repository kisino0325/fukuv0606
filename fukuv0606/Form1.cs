using System.Diagnostics.Eventing.Reader;

namespace fukuv0606
{
    public partial class Form1 : Form
    {
        int vx = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -vx;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "kisino";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            if (label1.Left <= 0) ;
            {
                vx = Math.Abs(vx);
            }
            else if(label1.Right>=ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
        }
    }
}
