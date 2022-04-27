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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = .95;
        }

        MoveEvent ControlMech = new MoveEvent();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ControlMech.moveControl = true;
            ControlMech.M_X = e.X;
            ControlMech.M_Y = e.Y;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = false;
            if (ControlMech.moveControl)
            {
                this.SetDesktopLocation(MousePosition.X - ControlMech.M_X, MousePosition.Y - ControlMech.M_Y);
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ControlMech.moveControl = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }

        private void Txt_UserName_Enter(object sender, EventArgs e)
        {
            if (Txt_UserName.Text == "User Name")
                Txt_UserName.Text = "";
        }

        private void Txt_UserName_Leave(object sender, EventArgs e)
        {
            if (Txt_UserName.Text == "")
                Txt_UserName.Text = "User Name"; 
        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            if (Txt_Password.Text == "Password")
                Txt_Password.Text = "";
        }

        private void Txt_Password_Leave(object sender, EventArgs e)
        {
            if (Txt_Password.Text == "")
                Txt_Password.Text = "Password";
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        New_User_Page NewRegistration = new New_User_Page();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NewRegistration.ShowDialog();
        }
              
    }
}
