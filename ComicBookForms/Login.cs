using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ComicBookForms
{
    public partial class Login : MaterialForm
    {
        public static string SetuserIDValue = "";

        public Login()
        {
            InitializeComponent();
            //Dark skin theme using Material Skin package.
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green300, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int intValue))
            {
                SetuserIDValue = txtID.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter an integer value!");
            }

            
        }
    }
}
