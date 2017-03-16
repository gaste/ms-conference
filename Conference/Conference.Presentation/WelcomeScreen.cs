using Conference.Presentation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference.Presentation
{
    public partial class WelcomeScreen : Form
    {
        private CLogin _login;

        public WelcomeScreen()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            txtBoxEmail.Focus();
            txtBoxEmail.SelectAll();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _login = new CLogin(txtBoxEmail.Text, txtBoxPwd.Text);
            var frmUser = new User(_login);
            frmUser.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //To Do 
            //User Login prüfen

            _login = new CLogin(txtBoxEmail.Text, txtBoxPwd.Text);

            if (_login.IsValid())
            {
                var frmVerwaltung = new KonferenzUebersicht();
                frmVerwaltung.WindowState = FormWindowState.Maximized;
                frmVerwaltung.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login fehlgeschlagen!\nBitte überprüfen Sie Ihre Login-Daten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            if(!CLogin.IsEmailValid(txtBoxEmail.Text))
            {
                MessageBox.Show("Ungültige EMail-Adresse!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtBoxEmail.Focus();
                txtBoxEmail.SelectAll();
            }
        }
    }
}
