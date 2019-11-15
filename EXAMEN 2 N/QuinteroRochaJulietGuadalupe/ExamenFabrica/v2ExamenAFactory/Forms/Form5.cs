using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2ExamenAFactory.Forms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        //internal static string variableCompartida;

        private void button1_Click(object sender, EventArgs e)
        {
            string valida =  Form1.variableCompartida;
            SqlConnection conn = new SqlConnection(Conexion.StringConexion());
            SqlCommand query = new SqlCommand();
            string x = "";

            query.Connection = conn;
            query.CommandText = (@"SELECT Password FROM Usuario WHERE Correo=@User and NombreGremio=@valida");
            query.Parameters.AddWithValue("@User", tbUser.Text);
            query.Parameters.AddWithValue("@valida", valida);

            conn.Open();


            SqlDataReader leer = query.ExecuteReader();

            if (leer.HasRows)
            {
                //da el valor obtenido de la tabla a una variable
                while (leer.Read())
                {
                    x = leer.GetString(0);

                }


                //Abrir ventana que corresponde
                if (tbPass.Text == x)
                {
                    MessageBox.Show("Se ha iniciado sesion.", "Aviso");
                    Form2 frm = new Form2();
                    this.Show();
                    frm.ShowDialog();
                    // Log formUsuario = new Log(tbUser.Text);
                    //   formUsuario.Show();
                    //   formUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("Incorrecto intenta de nuevo.");
                    tbPass.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuario no existe.");
            }

            conn.Close();
            tbPass.Clear();
            tbUser.Clear();
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
