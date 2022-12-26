using MaterialSkin;
using MaterialSkin.Controls;

namespace Калькулятoр
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.LightBlue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
                TManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToUInt64(materialMaskedTextBox4.Text);
            double rate = Convert.ToDouble(materialMaskedTextBox5.Text);
            double time = Convert.ToUInt16(materialMaskedTextBox6.Text);
            double mestime = time * 12;
            double mesrate = (rate / 100) / 12;
            double u = 1 + mesrate;
            double v = Math.Pow(u, mestime);
            double b = 1 / v;
            double pay = sum * mesrate / (1 - b);
            materialMaskedTextBox1.Text = Convert.ToInt32(pay).ToString();
            double colvoplat = time * 12;
            double obshstoimost = pay * colvoplat;
            materialMaskedTextBox2.Text = Convert.ToInt32(colvoplat).ToString();
            materialMaskedTextBox3.Text = Convert.ToInt32(obshstoimost).ToString();
        }

        private void materialMaskedTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel11_Click(object sender, EventArgs e)
        {

        }
    }
}