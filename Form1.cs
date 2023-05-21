using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TusPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USUARI")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "USUARI";
                txtUser.ForeColor = Color.DarkGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASENYA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if( txtPass.Text == "")
            {
                txtPass.Text = "CONTRASENYA";
                txtPass.ForeColor = Color.DarkGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARI" || txtPass.Text == "CONTRASENYA")
            {
                MessageBox.Show("Siusplau introdueixi un usuari.");
            }
            else
            {
                MessageBox.Show("Benvingut!");
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://insbaixcamp.org");
        }
    }
}