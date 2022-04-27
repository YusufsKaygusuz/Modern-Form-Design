using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Form_Design_2_
{
    public partial class New_User_Page : Form
    {
        public New_User_Page()
        {
            InitializeComponent();
        }
        private void New_User_Page_Load(object sender, EventArgs e)
        {
            this.Opacity = .9;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
         
            if (bunifuMaterialTextbox1.Text == "User Name")
                bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
                bunifuMaterialTextbox1.Text = "User Name";
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "E-mail Address")
                bunifuMaterialTextbox2.Text = "";
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
                bunifuMaterialTextbox2.Text = "E-mail Address";
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "Password")
                bunifuMaterialTextbox3.Text = "";
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
           // if (bunifuMaterialTextbox3.Text == "")
              //  bunifuMaterialTextbox3.Text = "Password";
        }

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "Password Agin")
                bunifuMaterialTextbox4.Text = "";
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "")
                bunifuMaterialTextbox4.Text = "Password Agin";
        }
        MoveEvent ME = new MoveEvent();

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ME.moveControl = true;
            ME.M_X = e.X;
            ME.M_Y = e.Y;
        }
        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ME.moveControl)
                this.SetDesktopLocation(MousePosition.X - ME.M_X, MousePosition.Y - ME.M_Y);
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            ME.moveControl = false;
        }

        PasswordCheck checkPassword = new PasswordCheck();
        private void bunifuMaterialTextbox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (bunifuMaterialTextbox3.Text != null || bunifuMaterialTextbox3.Text != "")
                {
                    checkPassword.Passw = bunifuMaterialTextbox3.Text;
                    if (checkPassword.Passw != "Invalid Password")
                    {
                        bunifuMaterialTextbox3.Text = "";
                        for (int i = 0; i < checkPassword.Passw.Length; i++)
                        {
                            bunifuMaterialTextbox3.Text += "*";
                        }
                        
                    }
                    else
                        MessageBox.Show("Invalid Password", "Password's Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    bunifuMaterialTextbox3.Text = "Password";
            }
        }
    }
}
