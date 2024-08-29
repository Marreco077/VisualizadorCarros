namespace VisualizadorCarros
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeFotosCarros = Directory.GetFiles(@"D:\ImagensProjetoCSharp");

            foreach (string imagemCarro in nomeFotosCarros)
            {
                string[] separador = imagemCarro.Split('\\');
                string[] nomeCarro = separador[2].Split('.');


                if (comboBox2.Text == nomeCarro[0])
                {
                    pictureBox2.ImageLocation = @"D:\ImagensProjetoCSharp\" + comboBox2.Text + ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            switch (comboBox1.Text)
            {
                case "Subaru":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Impreza");
                    comboBox2.Items.Add("Wrx");
                    break;

                case "Fiat":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Uno");
                    comboBox2.Items.Add("Mobi");
                    break;

                case "Volkswagen":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Brasilia");
                    comboBox2.Items.Add("Fusca");
                    break;

                case "Porsche":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("911");
                    comboBox2.Items.Add("Cayenne");
                    break;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
