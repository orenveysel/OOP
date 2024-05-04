using _8_Polimorfizm_2.CepTelefonlari;

namespace _8_Polimorfizm_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.CallSound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone();
            iphone.CallSound();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.CallSound();
        }
    }
}
