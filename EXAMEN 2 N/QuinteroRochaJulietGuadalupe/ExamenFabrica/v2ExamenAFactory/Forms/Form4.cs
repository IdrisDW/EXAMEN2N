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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection gremio = this.downAsig.Items;
            gremio.Add("Rojo");
            gremio.Add("Verde");
            gremio.Add("Blanco");
            gremio.Add(" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
     //       using (SqlConnection conn = new SqlConnection(Conexion.StringConexion())) //;
      //      {
         ///       int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdVehiculo"].Value);
             //   conn.Open();
            //    string query = "DELETE FROM Vehiculo WHERE IdVehiculo = @id";
            //    SqlCommand comando = new SqlCommand(query, conn);
              //  comando.Parameters.AddWithValue("@id", id);

            //    comando.ExecuteNonQuery();
           //     conn.Close();
                //

                //
        //    }
           


 
    }
    }
}
