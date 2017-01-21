using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploClasesAccesoSQLServer
{
    public partial class FrmPersonasRegistradas : Form
    {
        public FrmPersonasRegistradas()
        {
            InitializeComponent();
            MostrarResultados();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBuscarPersona_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MostrarResultados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void MostrarResultados()
        {
            try
            {
                using (SqlConnection conexionSQL = new SqlConnection("server=EstebanMena\\SQLEXPRESS ; database=Tarea8Aplicada1DB ; integrated security = true"))
                {

                    conexionSQL.Open();

                    DataTable datos = new DataTable();

                    string comandoString = "SELECT * FROM Persona;";

                    SqlCommand comando = new SqlCommand(comandoString, conexionSQL);

                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(datos);
                    DatosDataGridView.DataSource = datos;

                    conexionSQL.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
