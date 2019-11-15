using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace v2ExamenAFactory.Forms
{
    //string user = null;
    //////// Conexion ////////
    //SqlConnection con = new SqlConnection(Conexion.StringConexion());

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            nomStorelbl.Text = Form1.variableCompartida;
            DomainUpDown.DomainUpDownItemCollection tipo = this.dupDownTipoV.Items;
            tipo.Add("Calafia");
            tipo.Add("Camion");
            tipo.Add("Ruta");
            tipo.Add("Privado");

            DomainUpDown.DomainUpDownItemCollection combustible = this.dupDownTcombus.Items;
            combustible.Add("Diesel");
            combustible.Add("Gasolina");
            combustible.Add("Hibrido");

            if (Form1.variableCompartida != "Admin")
            {
                downAsig.Hide();
                lblAsign.Hide();
            }

            DomainUpDown.DomainUpDownItemCollection gremio = this.downAsig.Items;
            gremio.Add("Rojo");
            gremio.Add("Verde");
            gremio.Add("Blanco");
            gremio.Add(" ");

            // Set Text.
            //this.downAsig.Text = "Dot";

        }
        IFabricaVehiculo fabrica;

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //vehiculo tipo conbustible
            if (this.dupDownTcombus.Text == "Diesel")
            {
               // int nt=1;
               fabrica = new FabricaVehiculoDiesel();
                Opciones();
            } 
            else if (this.dupDownTcombus.Text == "Gasolina")
            {
                fabrica = new FabricaVehiculoGasolina();
                Opciones();

            }
            else if (this.dupDownTcombus.Text == "Hibrido")
            {
                fabrica = new FabricaVehiculoHibrido();
                Opciones();
            }

        }
        public void Opciones() {
            Ruta rut ;
            Privado pr;
            Camion cm;
            Calafia cal;
            if (this.dupDownTipoV.Text == "Calafia")
            {
              cal =  fabrica.creaCalafia(txtMarca.Text, this.downAsig.Text, Convert.ToDouble(txtPasaje.Text), txtanio.Text, txtMatric.Text, Convert.ToInt32(txtCpasajeros.Text));
                cal.mostrarCaracteristicas();
                Insertar();
            }
            else if (this.dupDownTipoV.Text == "Ruta")
            {
                rut = fabrica.creaRuta(txtMarca.Text, this.downAsig.Text, Convert.ToDouble(txtPasaje.Text), txtanio.Text, txtMatric.Text, Convert.ToInt32(txtCpasajeros.Text));
                rut.mostrarCaracteristicas();
                Insertar();
            }
            else if (this.dupDownTipoV.Text == "Privado")
            {
                pr = fabrica.creaPrivado(txtMarca.Text, this.downAsig.Text, Convert.ToDouble(txtPasaje.Text), txtanio.Text, txtMatric.Text, Convert.ToInt32(txtCpasajeros.Text));
                pr.mostrarCaracteristicas();
                Insertar();
            }
            else if (this.dupDownTipoV.Text == "Camion")
            {
                cm = fabrica.creaCamion(txtMarca.Text, this.downAsig.Text, Convert.ToDouble(txtPasaje.Text), txtanio.Text, txtMatric.Text, Convert.ToInt32(txtCpasajeros.Text));
                cm.mostrarCaracteristicas();
                Insertar();
            }
        }

        public void Insertar()
        {
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            // Insertar en la base de datos 
            try
            {

                string connectionString = Conexion.StringConexion();
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();

                    
                    //I N I C I O: vehiculo
                    using (var cmd = new SqlCommand("INSERT INTO Vehiculo (TipoVehiculo,Marca,Pasaje,Anio,Placa,Capacidad,Combustible,NombreGremio) VALUES (@TipoVehiculo,@Marca,@Pasaje,@Anio,@Placa,@Capacidad,@Combustible,@NombreGremio)", conn))
                    {
                      
                        cmd.Parameters.AddWithValue("@TipoVehiculo", dupDownTipoV.Text);
                        cmd.Parameters.AddWithValue("@Marca", txtMarca.Text);
                        cmd.Parameters.AddWithValue("@Pasaje", Convert.ToDouble(txtPasaje.Text));
                        cmd.Parameters.AddWithValue("@Anio", txtanio.Text);
                        cmd.Parameters.AddWithValue("@Placa", txtMatric.Text);
                        cmd.Parameters.AddWithValue("@Capacidad", Convert.ToInt32(txtCpasajeros.Text));
                        cmd.Parameters.AddWithValue("@Combustible", this.dupDownTcombus.Text);

                        if (nomStorelbl.Text == "Admin")
                        {
                            cmd.Parameters.AddWithValue("@NombreGremio", this.downAsig.Text);
                        }
                        else if (nomStorelbl.Text != "Admin")
                        {
                            cmd.Parameters.AddWithValue("@NombreGremio", nomStorelbl.Text);
                        }
                           
                        cmd.ExecuteNonQuery();

                    }//F I N: insereccion de vehiculo.


                    conn.Close();
                } //fin using

            }//Excepciones
            catch (Exception ex) { MessageBox.Show("ERROR: " + ex.Message); }
            MessageBox.Show("Proceso : Dar de Alta Finalizado");
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        }

    }
}
