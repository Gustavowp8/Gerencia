using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Gerencia
{
    public partial class TelaInicial : MaterialForm
    {

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public TelaInicial()
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

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
