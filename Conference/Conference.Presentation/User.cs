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
    public partial class User : Form
    {
        private CLogin _login;
        public User(CLogin loginData)
        {
            InitializeComponent();

            _login = loginData;
        }
    }
}
