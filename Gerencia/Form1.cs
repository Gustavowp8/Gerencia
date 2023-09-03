using MaterialSkin.Controls;

namespace Gerencia
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue700, MaterialSkin.Primary.Blue100, MaterialSkin.Accent.Blue200,
                MaterialSkin.TextShade.WHITE);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Gustavo" && txtSenha.Text == "123456")
            {
                new TelaInicial().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERRO! Verifique os dados e tente novamente");
                txtUsuario.Clear();
                txtSenha.Clear();
            }
        }
    }
}