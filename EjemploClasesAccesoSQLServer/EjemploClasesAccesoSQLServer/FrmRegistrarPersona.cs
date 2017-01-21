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
    public partial class FrmRegistrarPersona : Form
    {
        public FrmRegistrarPersona()
        {
            InitializeComponent();
        }

        private void FrmRegistrarPersona_Load(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            if(NombreTextBox.Text!="" && ApellidoTextBox.Text!="" && DireccionTextBox.Text!="" && TelefonoTextBox.Text!="")
            {
                try
                {
                    using (SqlConnection conexionSQL = new SqlConnection("server=EstebanMena\\SQLEXPRESS ; database=Tarea8Aplicada1DB ; integrated security = true"))
                    {

                        conexionSQL.Open();
                        string comandoString = "INSERT INTO Persona (Nombre, Apellido, Direccion, Telefono) values ('" + NombreTextBox.Text + "', '" + ApellidoTextBox.Text + "' , '" + DireccionTextBox.Text + "', '" + TelefonoTextBox.Text + "');";

                        SqlCommand comando = new SqlCommand(comandoString, conexionSQL);

                        try
                        {
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Persona registrada con exito!");
                            NombreTextBox.Text = "";
                            ApellidoTextBox.Text = "";
                            DireccionTextBox.Text = "";
                            TelefonoTextBox.Text = "";
                        }
                        catch (SqlException E)
                        {
                            MessageBox.Show(E.Message);
                        }

                        conexionSQL.Close();
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar...");
            }
            
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DireccionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
