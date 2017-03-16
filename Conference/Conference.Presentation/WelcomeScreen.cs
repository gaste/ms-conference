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
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var frmUser = new User();
            frmUser.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //To Do 
            //User Login prüfen
            var frmVerwaltung = new KonferenzUebersicht();
            frmVerwaltung.WindowState = FormWindowState.Maximized;
            frmVerwaltung.ShowDialog();
        }
    }
}
