using System.Windows.Forms;
using System;

namespace egerkordinata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("Azeg�rkoordin�t�iX:{0},Y:{1}", e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void PanelIgazit()
        {
            panel.Left = (ClientSize.Width - panel.Width) / 2;
            panel.Top = (ClientSize.Height - panel.Height) / 2;
        }
    }
}