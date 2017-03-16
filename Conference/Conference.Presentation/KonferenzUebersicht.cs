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
    public partial class KonferenzUebersicht : Form
    {
        public KonferenzUebersicht()
        {
            InitializeComponent();
        }

        private void btnVerwalten_Click(object sender, EventArgs e)
        {
            var frmKonferenz = new KonferenzVerwalten();
            frmKonferenz.WindowState = FormWindowState.Maximized;
            frmKonferenz.ShowDialog();
        }
    }
}
