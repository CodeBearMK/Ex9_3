using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex9_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDown1.Items.Add("日全食");
            domainUpDown1.Items.Add("日環食");
            domainUpDown1.Items.Add("日偏食");
            domainUpDown1.SelectedIndex = 0;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedIndex == 0)
            {
                pictureBox1.Location = new Point(167, 23);
                pictureBox1.Size = new Size(100, 85); 
            }
            else if (domainUpDown1.SelectedIndex == 1)
            {
                pictureBox1.Location = new Point(171, 27);
                pictureBox1.Size = new Size(90, 75);
            }
            else if (domainUpDown1.SelectedIndex == 2)
            {
                pictureBox1.Location = new Point(190, 38);
                pictureBox1.Size = new Size(100, 85);
            }
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(100, 85);
            pictureBox1.Location = new Point(hScrollBar1.Value, 23);
        }
    }
}
