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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Show();
            frm.ShowDialog();


        }
      public  SqlDataAdapter adapter = new SqlDataAdapter();
      public  DataTable tabla = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection gremio = this.downAsigB.Items;
            //esta variable toma el valor de el boton del form 1 
            //ya sea admin, rojo, verde o blanco
            string v ; 


          v =  nomStorelbl.Text = Form1.variableCompartida;
            //Mostrar Datos de la bd.
            SqlConnection conn = new SqlConnection(Conexion.StringConexion());
            //SqlCommand comando = new SqlCommand("SELECT * FROM Vehiculo; ", conn);

            if (v == "Rojo" || v == "Verde" || v == "Blanco")
            {
                btnElimina.Visible = false;
                btnEliminaGremio.Visible = false;
                btnAsignar.Visible = false;
                btnFiltrar.Visible = false;
                downAsigB.Visible = false;
                //
                //
                SqlCommand comando2 = new SqlCommand("SELECT * FROM Vehiculo WHERE NombreGremio= @gremio; ", conn);
                comando2.Parameters.AddWithValue("@gremio", v);
               
                adapter.SelectCommand = comando2;

                if (v == "Rojo") {
                    gremio.Add("Rojo");
                    gremio.Add(" ");
                } else if (v == "Verde") {
                    gremio.Add(  "Verde");
                    gremio.Add(" ");
                }
                else if(v == "Blanco") {
                    gremio.Add("Blanco");
                    gremio.Add(" ");
                }
            adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;
               
            }


            else {
                  SqlCommand comandi = new SqlCommand("SELECT * FROM Vehiculo; ", conn);
                gremio.Add("Rojo");
                gremio.Add("Verde");
                gremio.Add("Blanco");
                gremio.Add(" ");

                adapter.SelectCommand = comandi;
        
                adapter.Fill(tabla);

               dataGridView1.DataSource = tabla;
            }
            
            /*
            string v = Form1.variableCompartida;string g;
            if (v == "Rojo")
            {
                g = "Rojo";
                btnElimina.Visible = false;
                btnEliminaGremio.Visible = false;
                SqlCommand comando = new SqlCommand("SELECT * FROM Vehiculo WHERE NombreGremio= @gremio; ", conn);
                comando.Parameters.AddWithValue("@gremio", gremio);
            }
            else if (v == "Verde")
            {
                g = "Verde";
                btnElimina.Visible = false;
                btnEliminaGremio.Visible = false;
                SqlCommand comando = new SqlCommand("SELECT * FROM Vehiculo WHERE NombreGremio= @gremio; ", conn);
                comando.Parameters.AddWithValue("@gremio", gremio);


            }
            else if (v == "Blanco")
            {
                g = "Blanco";
                btnElimina.Visible = false;
                btnEliminaGremio.Visible = false;
                SqlCommand comando = new SqlCommand("SELECT * FROM Vehiculo WHERE NombreGremio= @gremio; ", conn);
                comando.Parameters.AddWithValue("@gremio", gremio);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }

            else
            {

                SqlCommand comando = new SqlCommand("SELECT * FROM Vehiculo; ", conn);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                dataGridView1.DataSource = tabla;
            }
            
            */


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            using (SqlConnection conn = new SqlConnection(Conexion.StringConexion())) //;
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdVehiculo"].Value);
                conn.Open();
                string query = "DELETE FROM Vehiculo WHERE IdVehiculo = @id";
                SqlCommand comando = new SqlCommand(query, conn);
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
                conn.Close();
                //
              
                //
            }
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);



            }

        private void button2_Click(object sender, EventArgs e)
        {
           //string lideres= nomStorelbl.Text = Form1.variableCompartida;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdVehiculo"].Value);
            string variable = downAsigB.Text;
          //  string variable = nomStorelbl.Text;
            if (dataGridView1.CurrentRow == null)
                return;


          
            using (SqlConnection conn = new SqlConnection(Conexion.StringConexion())) //;
            {
                conn.Open();
                string query = "UPDATE  Vehiculo SET NombreGremio = @gremio WHERE IdVehiculo = @id";

                /*
                if (lideres == "Verde")
                {

                    
                  
                }
                else if (lideres == "Blanco")
                {

                }
                else if (lideres == "Rojo")
                {

                }
                */

                SqlCommand comando = new SqlCommand(query, conn);
                comando.Parameters.AddWithValue("@id", id);
                //      comando.Parameters.AddWithValue("@gremio", gremio);
                comando.Parameters.AddWithValue("@gremio", variable);
                comando.ExecuteNonQuery();
                conn.Close();
                //

                //
            }
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;




            using (SqlConnection conn = new SqlConnection(Conexion.StringConexion())) //;
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdVehiculo"].Value);
                string gremio = " ";
                conn.Open();
                string query = "UPDATE  Vehiculo SET NombreGremio = @gremio WHERE IdVehiculo = @id";
                SqlCommand comando = new SqlCommand(query, conn);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@gremio", gremio);
                comando.ExecuteNonQuery();
                conn.Close();
                //

                //
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection conn = new SqlConnection(Conexion.StringConexion())) //;
            {
                conn.Open();
                // string gremio = this.downAsigB.Text;
                //  MessageBox.Show(gremio);
                SqlCommand comando2 = new SqlCommand("SELECT * FROM Vehiculo WHERE NombreGremio=@gremio; ", conn);
                comando2.Parameters.AddWithValue("@gremio", this.downAsigB.Text);
                

                comando2.ExecuteNonQuery();
                adapter.SelectCommand = comando2;


                adapter.Fill(tabla);
                dataGridView1.DataSource = tabla;

                conn.Close();


                
            //    string gremio = " ";
             //   conn.Open();
            //    string query = "UPDATE  Vehiculo SET NombreGremio = @gremio WHERE IdVehiculo = @id";
            //    SqlCommand comando = new SqlCommand(query, conn);
            ///    comando.Parameters.AddWithValue("@id", id);
            //    comando.Parameters.AddWithValue("@gremio", gremio);
            //    comando.ExecuteNonQuery();
            //    conn.Close();
                //

                //
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
