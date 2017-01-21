using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploClasesAccesoSQLServer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void RegistrarPersonaButton_Click(object sender, EventArgs e)
        {
            new FrmRegistrarPersona().Show();
        }

        private void BuscarPersonaButton_Click(object sender, EventArgs e)
        {
            new FrmPersonasRegistradas().Show();
        }
    }
}
