namespace ucuncu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbSayi1.Text);
            double b = Convert.ToDouble(tbSayi2.Text);
            tbIslem.Text = tbSayi1.Text + "+" + tbSayi2.Text;
            tbSonuc.Text = (a + b).ToString();
        }

        private void btnCýkar_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbSayi1.Text);
            double b = Convert.ToDouble(tbSayi2.Text);
            tbIslem.Text = tbSayi1.Text + "-" + tbSayi2.Text;
            tbSonuc.Text = (a - b).ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbSayi1.Text);
            double b = Convert.ToDouble(tbSayi2.Text);
            tbIslem.Text = tbSayi1.Text + "*" + tbSayi2.Text;
            tbSonuc.Text = (a * b).ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbSayi1.Text);
            double b = Convert.ToDouble(tbSayi2.Text);
            tbIslem.Text = tbSayi1.Text + "/" + tbSayi2.Text;
            tbSonuc.Text = (a / b).ToString();
        }
    }
}
