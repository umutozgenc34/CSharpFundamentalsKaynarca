namespace HesapMakinasıYeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Sayi1()
        {
            return Convert.ToDouble(txtSayiBox1.Text);
        }

        private double Sayi2()
        {
            return Convert.ToDouble(txtSayiBox2.Text);
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double toplam = Sayi1() + Sayi2();
            lblSonuc.Visible = true;
            lblSonuc.Text = $"SONUÇ : {toplam}";
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            double cikar = Sayi1() - Sayi2();
            lblSonuc.Visible = true;
            lblSonuc.Text = $"SONUÇ : {cikar}";
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            double carp = Sayi1() * Sayi2();
            lblSonuc.Visible = true;
            lblSonuc.Text = $"SONUÇ : {carp}";
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (Sayi2() != 0)
            {
                double bol = Sayi1() / Sayi2();
                lblSonuc.Visible = true;
                lblSonuc.Text = $"SONUÇ : {bol}";
            }
            else
            {
                MessageBox.Show("Bir sayı 0 a bölünemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "0";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            double pow = MathF.Pow(Convert.ToSingle(Sayi1()), Convert.ToSingle(Sayi2()));
            lblSonuc.Visible = true;
            lblSonuc.Text = $"SONUÇ : {pow}";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            int sqrt = Convert.ToInt32(MathF.Sqrt(Convert.ToSingle(Sayi1())));
            lblSonuc.Visible = true;
            lblSonuc.Text = $"SONUÇ : {sqrt}";
        }
    }
}
