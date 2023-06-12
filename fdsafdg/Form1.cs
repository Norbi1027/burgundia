namespace fdsafdg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void számolj_Click(object sender, EventArgs e)
        {
            lbl.Text = Convert.ToString(nud1.Value / nud2.Value);
        }

        private void kilép_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}